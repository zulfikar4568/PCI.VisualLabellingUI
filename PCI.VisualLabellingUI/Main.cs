﻿using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using PCI.VisualLabellingUI.Config;
using PCI.VisualLabellingUI.Entity;
using PCI.VisualLabellingUI.UseCase;
using PCI.VisualLabellingUI.Util;
using static PCI.VisualLabellingUI.Util.CameraUtil;

namespace PCI.VisualLabellingUI
{
    public partial class Main : Krypton.Toolkit.KryptonForm
    {
        private static bool needSnapshot = false;
        private readonly CameraUtil _camera;
        private readonly TransferImage _usecaseTransferImage;
        private byte[] _currentImage = null;

        public Main(CameraUtil camera, TransferImage usecaseTransferImage)
        {
            // Component Initialization Default
            InitializeComponent();
            KeyPreview = true;

            // Initialize Form Position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width / 2, Screen.PrimaryScreen.WorkingArea.Size.Height);

            Tb_Message.Enabled = false;
            Tb_Container.Focus();
            Tb_Container.SelectionStart = Tb_Container.Text.Length;

            _camera = camera;
            _usecaseTransferImage = usecaseTransferImage;

            // Initialize Camera
            GetListCameraUSB();

            //Reset the State
            ResetState();


            Bt_TurnOffCamera.Enabled = false;
            Bt_Camera.Enabled = true;
            Cb_VideoInput.DropDownStyle = ComboBoxStyle.DropDownList;
            Tb_Message.ReadOnly = true;
            Tb_Message.BackColor= Color.White;
        }
        private void ExitCamera()
        {
            Vsc_Source.SignalToStop();
            Vsc_Source = null;
        }

        private void GetListCameraUSB()
        {
            _camera.videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (_camera.videoDevices.Count != 0)
            {
                foreach (FilterInfo device in _camera.videoDevices)
                {
                    Cb_VideoInput.Items.Add(device.Name);
                }
            }
            else
            {
                Cb_VideoInput.Items.Add(MessageDefinition.NoDeviceFound);
            }

            Cb_VideoInput.SelectedIndex = 0;
        }
        private void OnCapture()
        {
            if (Vsc_Source.VideoSource == null)
            {
                MessageBox.Show(MessageDefinition.CameraNotConnected, "Device Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                needSnapshot = true;
            }
        }
        private void StartCamera()
        {
            try
            {
                _camera.Usbcamera = Cb_VideoInput.SelectedIndex.ToString();
                _camera.videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (_camera.videoDevices.Count != 0)
                {
                    // add all devices to combo
                    foreach (FilterInfo device in _camera.videoDevices)
                    {
                        _camera.listCamera.Add(device.Name);
                    }
                }
                else
                {
                    MessageBox.Show(MessageDefinition.NoDeviceFound, "Device Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                _camera.videoDevice = new VideoCaptureDevice(_camera.videoDevices[Convert.ToInt32(_camera.Usbcamera)].MonikerString);
                _camera.snapshotCapabilities = _camera.videoDevice.SnapshotCapabilities;
                if (_camera.snapshotCapabilities.Length == 0)
                {
                    // MessageBox.Show("Camera Capture Not supported");
                }
                OpenVideoSource(_camera.videoDevice);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Device Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void OpenVideoSource(IVideoSource source)
        {
            try
            {
                // set busy cursor
                this.Cursor = Cursors.WaitCursor;
                // stop current video source
                CloseCurrentVideoSource();
                // start new video source
                Vsc_Source.VideoSource = source;
                Vsc_Source.Start();
                // reset stop watch
                _camera.stopWatch = null;
                this.Cursor = Cursors.Default;

                Bt_TurnOffCamera.Enabled = true;
                Bt_Camera.Enabled = false;

                Tb_Container.Focus();
                Tb_Container.SelectionStart = Tb_Container.Text.Length;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
            }
        }

        private void EnabledCapturing()
        {
            if (Pb_Picture.Image != null)
            {
                Bt_RetryCapture.Enabled = true;
                Bt_PassCapture.Enabled = true;
                Bt_Capture.Enabled = false;
            }
        }

        public void UpdateCaptureSnapshotManifast(Bitmap image)
        {
            try
            {
                needSnapshot = false;
                Pb_Picture.Image = image;
                Pb_Picture.Update();
                
                _currentImage = _camera.ImageToByte(image);

                EnabledCapturing();
            }
            catch (Exception ex) 
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
            }
        }

        public void CloseCurrentVideoSource()
        {
            try
            {
                if (Vsc_Source.VideoSource != null)
                {
                    Vsc_Source.SignalToStop();
                    // wait ~ 3 seconds
                    for (int i = 0; i < 30; i++)
                    {
                        if (!Vsc_Source.IsRunning)
                            break;
                        System.Threading.Thread.Sleep(100);
                    }
                    if (Vsc_Source.IsRunning)
                    {
                        Vsc_Source.Stop();
                    }
                    Vsc_Source.VideoSource = null;
                }
            }
            catch { }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitCamera();
            Thread.Sleep(1000);
        }

        private void Bt_Capture_Click(object sender, EventArgs e)
        {
            OnCapture();
        }

        private void Vsc_Source_NewFrame(object sender, ref Bitmap image)
        {
            try
            {
                DateTime now = DateTime.Now;
                Graphics g = Graphics.FromImage(image);
                // paint current time
                SolidBrush brush = new SolidBrush(Color.White);
                FontFamily fontFamily = new FontFamily("Arial");
                Font font = new Font(
                   fontFamily,
                   25,
                   FontStyle.Regular,
                   GraphicsUnit.Pixel);

                g.DrawString(now.ToString(), font, brush, new PointF(5, 5));
                brush.Dispose();
                if (needSnapshot)
                {
                    this.Invoke(new CaptureSnapshotManifast(UpdateCaptureSnapshotManifast), image);
                }
                g.Dispose();
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex.Message);
            }
        }

        private void Bt_Reset_Click(object sender, EventArgs e)
        {
            ResetState();
        }

        private void ResetState()
        {
            Tb_Container.Enabled = true;
            Tb_Container.Text = "";
            Tb_Container.Focus();
            Tb_Container.SelectionStart = Tb_Container.Text.Length;
            Pb_Picture.Image = null;
            Bt_Capture.Enabled = false;
            Tb_Message.Text = "";
            Lb_Instruction.Text = MessageDefinition.MessageBeforeScan;
            Lb_Instruction.ForeColor = Color.White;
            Lb_Instruction.BackColor = Color.Green;


            Bt_RetryCapture.Enabled = false;
            Bt_PassCapture.Enabled = false;
        }

        private void Bt_Camera_Click(object sender, EventArgs e)
        {
            StartCamera();
        }
        private void Bt_Container_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ContainerModel dataContainer = _usecaseTransferImage.ContainerStatusData(Tb_Container.Text);
                if (dataContainer is null)
                {
                    MessageBox.Show(MessageDefinition.ProductNotFound, "Opcenter Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    // Operation Enforcement
                    if (!_usecaseTransferImage.OperationEnforcement(dataContainer)) return;

                    Bt_Capture.Enabled = true;
                    Tb_Container.Enabled = false;
                    Lb_Instruction.Text = MessageDefinition.MessageAfterScan;
                    Lb_Instruction.ForeColor = Color.White;
                    Lb_Instruction.BackColor = Color.YellowGreen;

                    Tb_Message.Text += $"Product: {dataContainer.Product}\r\n";
                    Tb_Message.Text += $"Product Description: {dataContainer.ProductDescription}\r\n";
                    Tb_Message.Text += $"Unit: {dataContainer.Unit}\r\n";
                    Tb_Message.Text += $"Qty: {dataContainer.Qty}\r\n";
                    Tb_Message.Text += $"Operation: {dataContainer.Operation}\r\n";
                }
            }

        }

        private void Bt_TurnOffCamera_Click(object sender, EventArgs e)
        {
            if (Vsc_Source.VideoSource == null)
            {
                MessageBox.Show(MessageDefinition.CameraNotConnected, "Device Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CloseCurrentVideoSource();
                Bt_TurnOffCamera.Enabled = false;
                Bt_Camera.Enabled = true;
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && Bt_Capture.Enabled)
            {
                OnCapture();
            } else if (e.KeyCode == Keys.F3 && Bt_PassCapture.Enabled)
            {
                PassCapturing();
            } else if (e.KeyCode == Keys.F2 && Bt_RetryCapture.Enabled)
            {
                RetryCapturing();
            }
        }

        private void PassCapturing()
        {
            using (var ms = new MemoryStream(_currentImage))
            {
                Bitmap bmp = new Bitmap(ms);
                Pb_Picture.Image = bmp;
                Pb_Picture.Update();
            }

            bool status = _usecaseTransferImage.MainLogic(Pb_Picture, Tb_Container.Text, $"{AppSettings.PrefixDocumentName}{Tb_Container.Text}", AppSettings.DocumentRevision, AppSettings.DocumentDescription);
            Lb_Instruction.Text = MessageDefinition.Waiting;
            Lb_Instruction.ForeColor = Color.White;
            Lb_Instruction.BackColor = Color.Blue;
            if (status)
            {
                MessageBox.Show(MessageDefinition.SendImageSuccess, "Sending the Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetState();
            }
            else
            {
                MessageBox.Show(MessageDefinition.SendImageFailed, "Sending the Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetState();
            }
        }

        private void Bt_PassCapture_Click(object sender, EventArgs e)
        {
            PassCapturing();
        }

        private void RetryCapturing()
        {
            Pb_Picture.Image = null;
            Bt_Capture.Enabled = true;
            Bt_RetryCapture.Enabled = false;
            Bt_PassCapture.Enabled = false;
        }

        private void Bt_RetryCapture_Click(object sender, EventArgs e)
        {
            RetryCapturing();
        }
    } 
}
