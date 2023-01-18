
namespace PCI.VisualCheckingUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.UIPalette = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonTableLayoutPanel2 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.Bt_TurnOffCamera = new Krypton.Toolkit.KryptonButton();
            this.Bt_Camera = new Krypton.Toolkit.KryptonButton();
            this.Cb_VideoInput = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Message = new System.Windows.Forms.TextBox();
            this.Tb_Container = new Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lb_Instruction = new System.Windows.Forms.Label();
            this.Bt_Capture = new Krypton.Toolkit.KryptonButton();
            this.Pb_Picture = new System.Windows.Forms.PictureBox();
            this.Vsc_Source = new AForge.Controls.VideoSourcePlayer();
            this.Bt_Reset = new Krypton.Toolkit.KryptonButton();
            this.Layout = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.kryptonTableLayoutPanel4 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.kryptonTableLayoutPanel5 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.kryptonTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_VideoInput)).BeginInit();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Picture)).BeginInit();
            this.Layout.SuspendLayout();
            this.kryptonTableLayoutPanel4.SuspendLayout();
            this.kryptonTableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // UIPalette
            // 
            this.UIPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.UIPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.UIPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UIPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.UIPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 10F;
            this.UIPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.UIPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.UIPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.UIPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // kryptonTableLayoutPanel2
            // 
            this.kryptonTableLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel2.BackgroundImage")));
            this.kryptonTableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonTableLayoutPanel2.ColumnCount = 3;
            this.kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.kryptonTableLayoutPanel2.Controls.Add(this.Bt_TurnOffCamera, 0, 0);
            this.kryptonTableLayoutPanel2.Controls.Add(this.Bt_Camera, 1, 0);
            this.kryptonTableLayoutPanel2.Controls.Add(this.Cb_VideoInput, 0, 0);
            this.kryptonTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel2.Location = new System.Drawing.Point(2, 619);
            this.kryptonTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTableLayoutPanel2.Name = "kryptonTableLayoutPanel2";
            this.kryptonTableLayoutPanel2.RowCount = 1;
            this.kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel2.Size = new System.Drawing.Size(782, 77);
            this.kryptonTableLayoutPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel2.TabIndex = 14;
            // 
            // Bt_TurnOffCamera
            // 
            this.Bt_TurnOffCamera.CornerRoundingRadius = 8F;
            this.Bt_TurnOffCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_TurnOffCamera.Dock = System.Windows.Forms.DockStyle.Right;
            this.Bt_TurnOffCamera.Location = new System.Drawing.Point(353, 10);
            this.Bt_TurnOffCamera.Margin = new System.Windows.Forms.Padding(10);
            this.Bt_TurnOffCamera.Name = "Bt_TurnOffCamera";
            this.Bt_TurnOffCamera.OverrideDefault.Back.Color1 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.OverrideDefault.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.OverrideDefault.Back.ColorAngle = 45F;
            this.Bt_TurnOffCamera.OverrideDefault.Border.Color1 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.OverrideDefault.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.OverrideDefault.Border.ColorAngle = 45F;
            this.Bt_TurnOffCamera.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_TurnOffCamera.OverrideDefault.Border.Rounding = 8F;
            this.Bt_TurnOffCamera.OverrideDefault.Border.Width = 1;
            this.Bt_TurnOffCamera.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_TurnOffCamera.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_TurnOffCamera.OverrideFocus.Back.Color1 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.OverrideFocus.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.OverrideFocus.Back.ColorAngle = 135F;
            this.Bt_TurnOffCamera.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.OverrideFocus.Border.Color1 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.OverrideFocus.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.OverrideFocus.Border.ColorAngle = 135F;
            this.Bt_TurnOffCamera.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_TurnOffCamera.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.OverrideFocus.Border.Rounding = 8F;
            this.Bt_TurnOffCamera.OverrideFocus.Border.Width = 1;
            this.Bt_TurnOffCamera.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_TurnOffCamera.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_TurnOffCamera.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Bt_TurnOffCamera.Size = new System.Drawing.Size(186, 57);
            this.Bt_TurnOffCamera.StateCommon.Back.Color1 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.StateCommon.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.StateCommon.Back.ColorAngle = 45F;
            this.Bt_TurnOffCamera.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_TurnOffCamera.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.StateCommon.Border.Rounding = 8F;
            this.Bt_TurnOffCamera.StateCommon.Border.Width = 1;
            this.Bt_TurnOffCamera.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_TurnOffCamera.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Bt_TurnOffCamera.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_TurnOffCamera.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.Bt_TurnOffCamera.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.Bt_TurnOffCamera.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.Bt_TurnOffCamera.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.Bt_TurnOffCamera.StateNormal.Back.Color1 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.StateNormal.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.StateNormal.Back.ColorAngle = 45F;
            this.Bt_TurnOffCamera.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.StateNormal.Border.Color1 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.StateNormal.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.StateNormal.Border.ColorAngle = 45F;
            this.Bt_TurnOffCamera.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_TurnOffCamera.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.StateNormal.Border.Rounding = 8F;
            this.Bt_TurnOffCamera.StateNormal.Border.Width = 1;
            this.Bt_TurnOffCamera.StatePressed.Back.Color1 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.StatePressed.Back.Color2 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.StatePressed.Back.ColorAngle = 135F;
            this.Bt_TurnOffCamera.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.StatePressed.Border.Color1 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.StatePressed.Border.Color2 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.StatePressed.Border.ColorAngle = 135F;
            this.Bt_TurnOffCamera.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_TurnOffCamera.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.StatePressed.Border.Rounding = 8F;
            this.Bt_TurnOffCamera.StatePressed.Border.Width = 1;
            this.Bt_TurnOffCamera.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.StateTracking.Back.Color2 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.StateTracking.Back.ColorAngle = 45F;
            this.Bt_TurnOffCamera.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.Bt_TurnOffCamera.StateTracking.Border.Color2 = System.Drawing.Color.Crimson;
            this.Bt_TurnOffCamera.StateTracking.Border.ColorAngle = 45F;
            this.Bt_TurnOffCamera.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_TurnOffCamera.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_TurnOffCamera.StateTracking.Border.Rounding = 8F;
            this.Bt_TurnOffCamera.StateTracking.Border.Width = 1;
            this.Bt_TurnOffCamera.TabIndex = 9;
            this.Bt_TurnOffCamera.Values.Text = "Camera OFF";
            this.Bt_TurnOffCamera.Click += new System.EventHandler(this.Bt_TurnOffCamera_Click);
            // 
            // Bt_Camera
            // 
            this.Bt_Camera.CornerRoundingRadius = 8F;
            this.Bt_Camera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Camera.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bt_Camera.Location = new System.Drawing.Point(559, 10);
            this.Bt_Camera.Margin = new System.Windows.Forms.Padding(10);
            this.Bt_Camera.Name = "Bt_Camera";
            this.Bt_Camera.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.OverrideDefault.Back.ColorAngle = 45F;
            this.Bt_Camera.OverrideDefault.Border.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.OverrideDefault.Border.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.OverrideDefault.Border.ColorAngle = 45F;
            this.Bt_Camera.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Camera.OverrideDefault.Border.Rounding = 8F;
            this.Bt_Camera.OverrideDefault.Border.Width = 1;
            this.Bt_Camera.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Camera.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Camera.OverrideFocus.Back.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.OverrideFocus.Back.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.OverrideFocus.Back.ColorAngle = 135F;
            this.Bt_Camera.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.OverrideFocus.Border.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.OverrideFocus.Border.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.OverrideFocus.Border.ColorAngle = 135F;
            this.Bt_Camera.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Camera.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.OverrideFocus.Border.Rounding = 8F;
            this.Bt_Camera.OverrideFocus.Border.Width = 1;
            this.Bt_Camera.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Camera.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Camera.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Bt_Camera.Size = new System.Drawing.Size(186, 57);
            this.Bt_Camera.StateCommon.Back.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.StateCommon.Back.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.StateCommon.Back.ColorAngle = 45F;
            this.Bt_Camera.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Camera.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.StateCommon.Border.Rounding = 8F;
            this.Bt_Camera.StateCommon.Border.Width = 1;
            this.Bt_Camera.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Camera.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Bt_Camera.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Camera.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.Bt_Camera.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.Bt_Camera.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.Bt_Camera.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.Bt_Camera.StateNormal.Back.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.StateNormal.Back.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.StateNormal.Back.ColorAngle = 45F;
            this.Bt_Camera.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.StateNormal.Border.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.StateNormal.Border.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.StateNormal.Border.ColorAngle = 45F;
            this.Bt_Camera.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Camera.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.StateNormal.Border.Rounding = 8F;
            this.Bt_Camera.StateNormal.Border.Width = 1;
            this.Bt_Camera.StatePressed.Back.Color1 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.StatePressed.Back.Color2 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.StatePressed.Back.ColorAngle = 135F;
            this.Bt_Camera.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.StatePressed.Border.Color1 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.StatePressed.Border.Color2 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.StatePressed.Border.ColorAngle = 135F;
            this.Bt_Camera.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Camera.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.StatePressed.Border.Rounding = 8F;
            this.Bt_Camera.StatePressed.Border.Width = 1;
            this.Bt_Camera.StateTracking.Back.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.StateTracking.Back.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.StateTracking.Back.ColorAngle = 45F;
            this.Bt_Camera.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.StateTracking.Border.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.StateTracking.Border.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.StateTracking.Border.ColorAngle = 45F;
            this.Bt_Camera.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Camera.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.StateTracking.Border.Rounding = 8F;
            this.Bt_Camera.StateTracking.Border.Width = 1;
            this.Bt_Camera.TabIndex = 6;
            this.Bt_Camera.Values.Text = "Camera ON";
            this.Bt_Camera.Click += new System.EventHandler(this.Bt_Camera_Click);
            // 
            // Cb_VideoInput
            // 
            this.Cb_VideoInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_VideoInput.CornerRoundingRadius = 20F;
            this.Cb_VideoInput.DropDownWidth = 200;
            this.Cb_VideoInput.IntegralHeight = false;
            this.Cb_VideoInput.Location = new System.Drawing.Point(10, 22);
            this.Cb_VideoInput.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.Cb_VideoInput.Name = "Cb_VideoInput";
            this.Cb_VideoInput.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Cb_VideoInput.Size = new System.Drawing.Size(180, 32);
            this.Cb_VideoInput.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cb_VideoInput.StateCommon.ComboBox.Border.Rounding = 20F;
            this.Cb_VideoInput.StateCommon.ComboBox.Border.Width = 1;
            this.Cb_VideoInput.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Cb_VideoInput.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cb_VideoInput.StateCommon.Item.Border.Rounding = 8F;
            this.Cb_VideoInput.StateCommon.Item.Border.Width = 1;
            this.Cb_VideoInput.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_VideoInput.StateCommon.Item.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.Cb_VideoInput.TabIndex = 8;
            this.Cb_VideoInput.Text = "VideoDevice";
            // 
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage")));
            this.kryptonTableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonTableLayoutPanel1.ColumnCount = 1;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.kryptonTableLayoutPanel1.Controls.Add(this.Tb_Message, 0, 3);
            this.kryptonTableLayoutPanel1.Controls.Add(this.Tb_Container, 0, 1);
            this.kryptonTableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(788, 2);
            this.kryptonTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 4;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(295, 613);
            this.kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(2, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Information :";
            // 
            // Tb_Message
            // 
            this.Tb_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Message.ForeColor = System.Drawing.Color.DimGray;
            this.Tb_Message.Location = new System.Drawing.Point(2, 176);
            this.Tb_Message.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Message.Multiline = true;
            this.Tb_Message.Name = "Tb_Message";
            this.Tb_Message.Size = new System.Drawing.Size(291, 435);
            this.Tb_Message.TabIndex = 4;
            // 
            // Tb_Container
            // 
            this.Tb_Container.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tb_Container.Location = new System.Drawing.Point(3, 53);
            this.Tb_Container.Name = "Tb_Container";
            this.Tb_Container.Size = new System.Drawing.Size(289, 33);
            this.Tb_Container.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Tb_Container.StateCommon.Border.Rounding = 10F;
            this.Tb_Container.TabIndex = 7;
            this.Tb_Container.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bt_Container_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(2, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Scan SN here :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(2, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Instruction :";
            // 
            // Lb_Instruction
            // 
            this.Lb_Instruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Instruction.AutoSize = true;
            this.Lb_Instruction.BackColor = System.Drawing.Color.White;
            this.Lb_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Instruction.Location = new System.Drawing.Point(302, 10);
            this.Lb_Instruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Instruction.Name = "Lb_Instruction";
            this.Lb_Instruction.Size = new System.Drawing.Size(1592, 25);
            this.Lb_Instruction.TabIndex = 9;
            this.Lb_Instruction.Text = "Message";
            // 
            // Bt_Capture
            // 
            this.Bt_Capture.CornerRoundingRadius = 8F;
            this.Bt_Capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Capture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Capture.Enabled = false;
            this.Bt_Capture.Location = new System.Drawing.Point(1145, 627);
            this.Bt_Capture.Margin = new System.Windows.Forms.Padding(60, 10, 80, 10);
            this.Bt_Capture.Name = "Bt_Capture";
            this.Bt_Capture.OverrideDefault.Back.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.OverrideDefault.Back.ColorAngle = 45F;
            this.Bt_Capture.OverrideDefault.Border.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.OverrideDefault.Border.ColorAngle = 45F;
            this.Bt_Capture.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Capture.OverrideDefault.Border.Rounding = 8F;
            this.Bt_Capture.OverrideDefault.Border.Width = 1;
            this.Bt_Capture.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Capture.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Capture.OverrideFocus.Back.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.OverrideFocus.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.OverrideFocus.Back.ColorAngle = 135F;
            this.Bt_Capture.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.OverrideFocus.Border.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.OverrideFocus.Border.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.OverrideFocus.Border.ColorAngle = 135F;
            this.Bt_Capture.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Capture.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.OverrideFocus.Border.Rounding = 8F;
            this.Bt_Capture.OverrideFocus.Border.Width = 1;
            this.Bt_Capture.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Capture.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Capture.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Bt_Capture.Size = new System.Drawing.Size(647, 61);
            this.Bt_Capture.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.StateCommon.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.StateCommon.Back.ColorAngle = 45F;
            this.Bt_Capture.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Capture.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.StateCommon.Border.Rounding = 8F;
            this.Bt_Capture.StateCommon.Border.Width = 1;
            this.Bt_Capture.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Capture.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Bt_Capture.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Capture.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.Bt_Capture.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.Bt_Capture.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.Bt_Capture.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.Bt_Capture.StateNormal.Back.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.StateNormal.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.StateNormal.Back.ColorAngle = 45F;
            this.Bt_Capture.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.StateNormal.Border.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.StateNormal.Border.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.StateNormal.Border.ColorAngle = 45F;
            this.Bt_Capture.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Capture.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.StateNormal.Border.Rounding = 8F;
            this.Bt_Capture.StateNormal.Border.Width = 1;
            this.Bt_Capture.StatePressed.Back.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.StatePressed.Back.ColorAngle = 135F;
            this.Bt_Capture.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.StatePressed.Border.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.StatePressed.Border.ColorAngle = 135F;
            this.Bt_Capture.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Capture.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.StatePressed.Border.Rounding = 8F;
            this.Bt_Capture.StatePressed.Border.Width = 1;
            this.Bt_Capture.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.StateTracking.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.StateTracking.Back.ColorAngle = 45F;
            this.Bt_Capture.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.Bt_Capture.StateTracking.Border.Color2 = System.Drawing.Color.DarkCyan;
            this.Bt_Capture.StateTracking.Border.ColorAngle = 45F;
            this.Bt_Capture.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Capture.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Capture.StateTracking.Border.Rounding = 8F;
            this.Bt_Capture.StateTracking.Border.Width = 1;
            this.Bt_Capture.TabIndex = 5;
            this.Bt_Capture.Values.Text = "CAPTURE";
            this.Bt_Capture.Click += new System.EventHandler(this.Bt_Capture_Click);
            // 
            // Pb_Picture
            // 
            this.Pb_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pb_Picture.Location = new System.Drawing.Point(1087, 2);
            this.Pb_Picture.Margin = new System.Windows.Forms.Padding(2, 2, 20, 2);
            this.Pb_Picture.Name = "Pb_Picture";
            this.Pb_Picture.Size = new System.Drawing.Size(765, 613);
            this.Pb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Picture.TabIndex = 1;
            this.Pb_Picture.TabStop = false;
            // 
            // Vsc_Source
            // 
            this.Vsc_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vsc_Source.Location = new System.Drawing.Point(20, 2);
            this.Vsc_Source.Margin = new System.Windows.Forms.Padding(20, 2, 2, 2);
            this.Vsc_Source.Name = "Vsc_Source";
            this.Vsc_Source.Size = new System.Drawing.Size(764, 613);
            this.Vsc_Source.TabIndex = 0;
            this.Vsc_Source.Text = "videoSourcePlayer1";
            this.Vsc_Source.VideoSource = null;
            this.Vsc_Source.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.Vsc_Source_NewFrame);
            // 
            // Bt_Reset
            // 
            this.Bt_Reset.CornerRoundingRadius = 8F;
            this.Bt_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Reset.Location = new System.Drawing.Point(791, 627);
            this.Bt_Reset.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Bt_Reset.Name = "Bt_Reset";
            this.Bt_Reset.OverrideDefault.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.OverrideDefault.Back.ColorAngle = 45F;
            this.Bt_Reset.OverrideDefault.Border.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.OverrideDefault.Border.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.OverrideDefault.Border.ColorAngle = 45F;
            this.Bt_Reset.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.OverrideDefault.Border.Rounding = 8F;
            this.Bt_Reset.OverrideDefault.Border.Width = 1;
            this.Bt_Reset.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Reset.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Reset.OverrideFocus.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.OverrideFocus.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.OverrideFocus.Back.ColorAngle = 135F;
            this.Bt_Reset.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.OverrideFocus.Border.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.OverrideFocus.Border.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.OverrideFocus.Border.ColorAngle = 135F;
            this.Bt_Reset.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.OverrideFocus.Border.Rounding = 8F;
            this.Bt_Reset.OverrideFocus.Border.Width = 1;
            this.Bt_Reset.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Reset.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Reset.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Bt_Reset.Size = new System.Drawing.Size(289, 61);
            this.Bt_Reset.StateCommon.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.StateCommon.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.StateCommon.Back.ColorAngle = 45F;
            this.Bt_Reset.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StateCommon.Border.Rounding = 8F;
            this.Bt_Reset.StateCommon.Border.Width = 1;
            this.Bt_Reset.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Reset.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Bt_Reset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Reset.StateNormal.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.StateNormal.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.StateNormal.Back.ColorAngle = 45F;
            this.Bt_Reset.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StateNormal.Border.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.StateNormal.Border.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.StateNormal.Border.ColorAngle = 45F;
            this.Bt_Reset.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StateNormal.Border.Rounding = 8F;
            this.Bt_Reset.StateNormal.Border.Width = 1;
            this.Bt_Reset.StatePressed.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.StatePressed.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.StatePressed.Back.ColorAngle = 135F;
            this.Bt_Reset.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StatePressed.Border.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.StatePressed.Border.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.StatePressed.Border.ColorAngle = 135F;
            this.Bt_Reset.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StatePressed.Border.Rounding = 8F;
            this.Bt_Reset.StatePressed.Border.Width = 1;
            this.Bt_Reset.StateTracking.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.StateTracking.Back.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.StateTracking.Back.ColorAngle = 45F;
            this.Bt_Reset.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StateTracking.Border.Color1 = System.Drawing.Color.LimeGreen;
            this.Bt_Reset.StateTracking.Border.Color2 = System.Drawing.Color.MediumSeaGreen;
            this.Bt_Reset.StateTracking.Border.ColorAngle = 45F;
            this.Bt_Reset.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StateTracking.Border.Rounding = 8F;
            this.Bt_Reset.StateTracking.Border.Width = 1;
            this.Bt_Reset.TabIndex = 8;
            this.Bt_Reset.Values.Text = "RESET";
            this.Bt_Reset.Click += new System.EventHandler(this.Bt_Reset_Click);
            // 
            // Layout
            // 
            this.Layout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Layout.BackgroundImage")));
            this.Layout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Layout.ColumnCount = 3;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.Layout.Controls.Add(this.Bt_Reset, 1, 1);
            this.Layout.Controls.Add(this.Vsc_Source, 0, 0);
            this.Layout.Controls.Add(this.Pb_Picture, 2, 0);
            this.Layout.Controls.Add(this.Bt_Capture, 2, 1);
            this.Layout.Controls.Add(this.kryptonTableLayoutPanel1, 1, 0);
            this.Layout.Controls.Add(this.kryptonTableLayoutPanel2, 0, 1);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(15, 2);
            this.Layout.Margin = new System.Windows.Forms.Padding(15, 2, 15, 2);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 2;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.50574F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.49425F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout.Size = new System.Drawing.Size(1872, 698);
            this.Layout.StateCommon.Color1 = System.Drawing.Color.White;
            this.Layout.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.Layout.TabIndex = 0;
            // 
            // kryptonTableLayoutPanel4
            // 
            this.kryptonTableLayoutPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel4.BackgroundImage")));
            this.kryptonTableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonTableLayoutPanel4.ColumnCount = 1;
            this.kryptonTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel4.Controls.Add(this.Layout, 0, 0);
            this.kryptonTableLayoutPanel4.Controls.Add(this.kryptonTableLayoutPanel5, 0, 1);
            this.kryptonTableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonTableLayoutPanel4.Name = "kryptonTableLayoutPanel4";
            this.kryptonTableLayoutPanel4.RowCount = 2;
            this.kryptonTableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.kryptonTableLayoutPanel4.Size = new System.Drawing.Size(1902, 753);
            this.kryptonTableLayoutPanel4.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel4.TabIndex = 3;
            // 
            // kryptonTableLayoutPanel5
            // 
            this.kryptonTableLayoutPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel5.BackgroundImage")));
            this.kryptonTableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonTableLayoutPanel5.ColumnCount = 2;
            this.kryptonTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.kryptonTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.kryptonTableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.kryptonTableLayoutPanel5.Controls.Add(this.Lb_Instruction, 1, 0);
            this.kryptonTableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel5.Location = new System.Drawing.Point(3, 705);
            this.kryptonTableLayoutPanel5.Name = "kryptonTableLayoutPanel5";
            this.kryptonTableLayoutPanel5.RowCount = 1;
            this.kryptonTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel5.Size = new System.Drawing.Size(1896, 45);
            this.kryptonTableLayoutPanel5.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel5.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1902, 753);
            this.Controls.Add(this.kryptonTableLayoutPanel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Palette = this.UIPalette;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "MES Camera Picture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.kryptonTableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cb_VideoInput)).EndInit();
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Picture)).EndInit();
            this.Layout.ResumeLayout(false);
            this.kryptonTableLayoutPanel4.ResumeLayout(false);
            this.kryptonTableLayoutPanel5.ResumeLayout(false);
            this.kryptonTableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette UIPalette;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton Bt_Camera;
        private Krypton.Toolkit.KryptonComboBox Cb_VideoInput;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Message;
        private Krypton.Toolkit.KryptonTextBox Tb_Container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lb_Instruction;
        private Krypton.Toolkit.KryptonButton Bt_Capture;
        private System.Windows.Forms.PictureBox Pb_Picture;
        private AForge.Controls.VideoSourcePlayer Vsc_Source;
        private Krypton.Toolkit.KryptonButton Bt_Reset;
        private Krypton.Toolkit.KryptonTableLayoutPanel Layout;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel4;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel5;
        private Krypton.Toolkit.KryptonButton Bt_TurnOffCamera;
    }
}

