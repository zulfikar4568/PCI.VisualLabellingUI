
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
            this.Layout = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.Vsc_Source = new AForge.Controls.VideoSourcePlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bt_Capture = new Krypton.Toolkit.KryptonButton();
            this.Bt_Reset = new Krypton.Toolkit.KryptonButton();
            this.Bt_Camera = new Krypton.Toolkit.KryptonButton();
            this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.Cb_VideoDevice = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonTableLayoutPanel2 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonTableLayoutPanel3 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.Tb_Container = new Krypton.Toolkit.KryptonTextBox();
            this.Bt_Container = new Krypton.Toolkit.KryptonTextBox();
            this.Tb_Message = new System.Windows.Forms.TextBox();
            this.Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_VideoDevice)).BeginInit();
            this.kryptonTableLayoutPanel2.SuspendLayout();
            this.kryptonTableLayoutPanel3.SuspendLayout();
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
            this.Layout.Controls.Add(this.pictureBox1, 2, 0);
            this.Layout.Controls.Add(this.Bt_Capture, 2, 1);
            this.Layout.Controls.Add(this.kryptonTableLayoutPanel1, 1, 0);
            this.Layout.Controls.Add(this.kryptonTableLayoutPanel2, 0, 1);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 2;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.70482F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.29518F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout.Size = new System.Drawing.Size(1398, 664);
            this.Layout.StateCommon.Color1 = System.Drawing.Color.White;
            this.Layout.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.Layout.TabIndex = 0;
            // 
            // Vsc_Source
            // 
            this.Vsc_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vsc_Source.Location = new System.Drawing.Point(20, 3);
            this.Vsc_Source.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.Vsc_Source.Name = "Vsc_Source";
            this.Vsc_Source.Size = new System.Drawing.Size(564, 582);
            this.Vsc_Source.TabIndex = 0;
            this.Vsc_Source.Text = "videoSourcePlayer1";
            this.Vsc_Source.VideoSource = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(813, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Bt_Capture
            // 
            this.Bt_Capture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Capture.CornerRoundingRadius = 8F;
            this.Bt_Capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Capture.Location = new System.Drawing.Point(870, 603);
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
            this.Bt_Capture.Size = new System.Drawing.Size(448, 45);
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
            this.Bt_Capture.Values.Text = "Capture";
            // 
            // Bt_Reset
            // 
            this.Bt_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Reset.CornerRoundingRadius = 8F;
            this.Bt_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Reset.Location = new System.Drawing.Point(592, 603);
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
            this.Bt_Reset.Size = new System.Drawing.Size(213, 45);
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
            this.Bt_Reset.Values.Text = "Reset";
            // 
            // Bt_Camera
            // 
            this.Bt_Camera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Camera.CornerRoundingRadius = 8F;
            this.Bt_Camera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Camera.Location = new System.Drawing.Point(249, 12);
            this.Bt_Camera.Margin = new System.Windows.Forms.Padding(60, 10, 60, 10);
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
            this.Bt_Camera.Size = new System.Drawing.Size(272, 45);
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
            this.Bt_Camera.StatePressed.Back.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.StatePressed.Back.Color2 = System.Drawing.Color.MediumOrchid;
            this.Bt_Camera.StatePressed.Back.ColorAngle = 135F;
            this.Bt_Camera.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Camera.StatePressed.Border.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.Bt_Camera.StatePressed.Border.Color2 = System.Drawing.Color.MediumOrchid;
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
            this.Bt_Camera.Values.Text = "Show Camera";
            // 
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage")));
            this.kryptonTableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonTableLayoutPanel1.ColumnCount = 1;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel1.Controls.Add(this.kryptonTableLayoutPanel3, 0, 0);
            this.kryptonTableLayoutPanel1.Controls.Add(this.Tb_Message, 0, 1);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(590, 3);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 2;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07216F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.92783F));
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(217, 582);
            this.kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel1.TabIndex = 9;
            // 
            // Cb_VideoDevice
            // 
            this.Cb_VideoDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_VideoDevice.CornerRoundingRadius = 20F;
            this.Cb_VideoDevice.DropDownWidth = 200;
            this.Cb_VideoDevice.IntegralHeight = false;
            this.Cb_VideoDevice.Location = new System.Drawing.Point(10, 19);
            this.Cb_VideoDevice.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Cb_VideoDevice.Name = "Cb_VideoDevice";
            this.Cb_VideoDevice.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Cb_VideoDevice.Size = new System.Drawing.Size(169, 32);
            this.Cb_VideoDevice.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cb_VideoDevice.StateCommon.ComboBox.Border.Rounding = 20F;
            this.Cb_VideoDevice.StateCommon.ComboBox.Border.Width = 1;
            this.Cb_VideoDevice.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Cb_VideoDevice.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cb_VideoDevice.StateCommon.Item.Border.Rounding = 8F;
            this.Cb_VideoDevice.StateCommon.Item.Border.Width = 1;
            this.Cb_VideoDevice.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_VideoDevice.StateCommon.Item.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.Cb_VideoDevice.TabIndex = 8;
            this.Cb_VideoDevice.Text = "VideoDevice";
            // 
            // kryptonTableLayoutPanel2
            // 
            this.kryptonTableLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel2.BackgroundImage")));
            this.kryptonTableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonTableLayoutPanel2.ColumnCount = 2;
            this.kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.70224F));
            this.kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.29776F));
            this.kryptonTableLayoutPanel2.Controls.Add(this.Bt_Camera, 1, 0);
            this.kryptonTableLayoutPanel2.Controls.Add(this.Cb_VideoDevice, 0, 0);
            this.kryptonTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel2.Location = new System.Drawing.Point(3, 591);
            this.kryptonTableLayoutPanel2.Name = "kryptonTableLayoutPanel2";
            this.kryptonTableLayoutPanel2.RowCount = 1;
            this.kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel2.Size = new System.Drawing.Size(581, 70);
            this.kryptonTableLayoutPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scan the Unit Here!";
            // 
            // kryptonTableLayoutPanel3
            // 
            this.kryptonTableLayoutPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonTableLayoutPanel3.BackgroundImage")));
            this.kryptonTableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kryptonTableLayoutPanel3.ColumnCount = 1;
            this.kryptonTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.kryptonTableLayoutPanel3.Controls.Add(this.Bt_Container, 0, 1);
            this.kryptonTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.kryptonTableLayoutPanel3.Name = "kryptonTableLayoutPanel3";
            this.kryptonTableLayoutPanel3.RowCount = 2;
            this.kryptonTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.53846F));
            this.kryptonTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.46154F));
            this.kryptonTableLayoutPanel3.Size = new System.Drawing.Size(211, 104);
            this.kryptonTableLayoutPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel3.TabIndex = 1;
            // 
            // Tb_Container
            // 
            this.Tb_Container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Container.Location = new System.Drawing.Point(3, 40);
            this.Tb_Container.Name = "Tb_Container";
            this.Tb_Container.Size = new System.Drawing.Size(205, 33);
            this.Tb_Container.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Tb_Container.StateCommon.Border.Rounding = 8F;
            this.Tb_Container.StateCommon.Border.Width = 1;
            this.Tb_Container.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Container.TabIndex = 0;
            this.Tb_Container.Text = "Container001";
            // 
            // Bt_Container
            // 
            this.Bt_Container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Container.Location = new System.Drawing.Point(3, 40);
            this.Bt_Container.Name = "Bt_Container";
            this.Bt_Container.Size = new System.Drawing.Size(205, 37);
            this.Bt_Container.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Container.StateCommon.Border.Rounding = 15F;
            this.Bt_Container.StateCommon.Border.Width = 1;
            this.Bt_Container.TabIndex = 2;
            this.Bt_Container.Text = "Container001";
            // 
            // Tb_Message
            // 
            this.Tb_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_Message.Location = new System.Drawing.Point(3, 113);
            this.Tb_Message.Multiline = true;
            this.Tb_Message.Name = "Tb_Message";
            this.Tb_Message.Size = new System.Drawing.Size(211, 466);
            this.Tb_Message.TabIndex = 4;
            this.Tb_Message.Text = "PO: PO1235435";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1398, 664);
            this.Controls.Add(this.Layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Palette = this.UIPalette;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "MES Camera Picture";
            this.Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_VideoDevice)).EndInit();
            this.kryptonTableLayoutPanel2.ResumeLayout(false);
            this.kryptonTableLayoutPanel3.ResumeLayout(false);
            this.kryptonTableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette UIPalette;
        private Krypton.Toolkit.KryptonTableLayoutPanel Layout;
        private AForge.Controls.VideoSourcePlayer Vsc_Source;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton Bt_Capture;
        private Krypton.Toolkit.KryptonButton Bt_Reset;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton Bt_Camera;
        private Krypton.Toolkit.KryptonComboBox Cb_VideoDevice;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox Tb_Container;
        private Krypton.Toolkit.KryptonTextBox Bt_Container;
        private System.Windows.Forms.TextBox Tb_Message;
    }
}

