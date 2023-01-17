using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Autofac;
using PCI.VisualCheckingUI.Config;
using PCI.VisualCheckingUI.UseCase;
using PCI.VisualCheckingUI.UseCase.Model;
using PCI.VisualCheckingUI.Util;
using static PCI.VisualCheckingUI.Util.CameraUtil;

namespace PCI.VisualCheckingUI
{
    public partial class Main : Krypton.Toolkit.KryptonForm
    {
        private static bool needSnapshot = false;
        private CameraUtil _camera;
        private TransferImage _usecaseTransferImage;

        public void DependencyInjectionInit()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new Util.Util());
            containerBuilder.RegisterModule(new Driver.Driver());
            containerBuilder.RegisterModule(new Repository.Repository());
            containerBuilder.RegisterModule(new UseCase.UseCase());

            var container = containerBuilder.Build();

            _camera = container.Resolve<CameraUtil>();
            _usecaseTransferImage = container.Resolve<TransferImage>();
        }

        private void ConnectDirectoryServer()
        {
            try
            {
                NetworkUNC.Connect();
            }
            catch (Exception ex)
            {
                EventLogUtil.LogErrorEvent(AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source, ex);
            }
        }
        public Main()
        {
            DependencyInjectionInit();
            InitializeComponent();
            GetListCameraUSB();
            Bt_Capture.Enabled = false;
            ConnectDirectoryServer();
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
                Cb_VideoInput.Items.Add("No Direct Show devices found");
            }

            Cb_VideoInput.SelectedIndex = 0;
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
                    MessageBox.Show("Camera devices not found");
                }

                _camera.videoDevice = new VideoCaptureDevice(_camera.videoDevices[Convert.ToInt32(_camera.Usbcamera)].MonikerString);
                _camera.snapshotCapabilities = _camera.videoDevice.SnapshotCapabilities;
                if (_camera.snapshotCapabilities.Length == 0)
                {
                    MessageBox.Show("Camera Capture Not supported");
                }
                OpenVideoSource(_camera.videoDevice);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
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
            }
            catch { }
        }

        public void UpdateCaptureSnapshotManifast(Bitmap image)
        {
            try
            {
                needSnapshot = false;
                Pb_Picture.Image = image;
                Pb_Picture.Update();

                string namaImage = "sampleImage";
                string nameCapture = namaImage + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";
                /*if (Directory.Exists(pathFolder))
                {
                    Pb_Picture.Image.Save(pathFolder + nameCapture, ImageFormat.Bmp);
                }
                else
                {
                    Directory.CreateDirectory(pathFolder);
                    Pb_Picture.Image.Save(pathFolder + nameCapture, ImageFormat.Bmp);
                }*/
            }
            catch { }
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
            needSnapshot = true;
        }

        private void Vsc_Source_NewFrame(object sender, ref Bitmap image)
        {
            try
            {
                DateTime now = DateTime.Now;
                Graphics g = Graphics.FromImage(image);
                // paint current time
                SolidBrush brush = new SolidBrush(Color.Red);
                g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
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
            Pb_Picture.Image = null;
            Bt_Capture.Enabled = false;
            Tb_Message.Text = "";
            Tb_Container.Text = "";
        }

        private void Bt_Camera_Click(object sender, EventArgs e)
        {
            StartCamera();
        }
        private void Bt_Container_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Bt_Capture.Enabled = true;
                Tb_Message.Text = "PO: PO8GH123 \r\nProduct: Versana Premier";
                /*ContainerStatusModel dataContainer = _usecaseTransferImage.ContainerStatusData(Tb_Container.Text);
                string jsonString = JsonSerializer.Serialize(dataContainer);
                Tb_Message.Text = jsonString;*/
            }

        }
    } 
}
