namespace MINI_PRESS_Framework
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_General = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_StartStop = new System.Windows.Forms.TableLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnl_UpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.btnAlarms = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTestStop = new System.Windows.Forms.Button();
            this.btnTestStart = new System.Windows.Forms.Button();
            this.btnTestCall = new System.Windows.Forms.Button();
            this.btnTestFinished = new System.Windows.Forms.Button();
            this.pnlDesktop = new System.Windows.Forms.SplitContainer();
            this.pnlLeft = new System.Windows.Forms.TableLayoutPanel();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.lblStateInf = new System.Windows.Forms.Label();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblForce = new System.Windows.Forms.Label();
            this.txtStateInf = new System.Windows.Forms.TextBox();
            this.pnl_General.SuspendLayout();
            this.pnl_StartStop.SuspendLayout();
            this.pnl_UpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesktop)).BeginInit();
            this.pnlDesktop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_General
            // 
            this.pnl_General.ColumnCount = 2;
            this.pnl_General.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.86983F));
            this.pnl_General.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.13017F));
            this.pnl_General.Controls.Add(this.pnl_StartStop, 0, 0);
            this.pnl_General.Controls.Add(this.pnl_UpButton, 1, 0);
            this.pnl_General.Controls.Add(this.pnlDesktop, 1, 1);
            this.pnl_General.Controls.Add(this.pnlLeft, 0, 1);
            this.pnl_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_General.Location = new System.Drawing.Point(0, 0);
            this.pnl_General.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_General.Name = "pnl_General";
            this.pnl_General.RowCount = 2;
            this.pnl_General.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.pnl_General.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnl_General.Size = new System.Drawing.Size(1264, 681);
            this.pnl_General.TabIndex = 0;
            // 
            // pnl_StartStop
            // 
            this.pnl_StartStop.ColumnCount = 2;
            this.pnl_StartStop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_StartStop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_StartStop.Controls.Add(this.btnStop, 1, 0);
            this.pnl_StartStop.Controls.Add(this.btnStart, 0, 0);
            this.pnl_StartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_StartStop.Location = new System.Drawing.Point(0, 0);
            this.pnl_StartStop.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_StartStop.Name = "pnl_StartStop";
            this.pnl_StartStop.RowCount = 1;
            this.pnl_StartStop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_StartStop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_StartStop.Size = new System.Drawing.Size(213, 73);
            this.pnl_StartStop.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStop.Location = new System.Drawing.Point(106, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 73);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Sistem Durdur";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseDown);
            this.btnStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 73);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Sistem Başlat";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnl_UpButton
            // 
            this.pnl_UpButton.ColumnCount = 9;
            this.pnl_UpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pnl_UpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pnl_UpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pnl_UpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pnl_UpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pnl_UpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pnl_UpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pnl_UpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pnl_UpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pnl_UpButton.Controls.Add(this.btnExit, 8, 0);
            this.pnl_UpButton.Controls.Add(this.btnCalibration, 7, 0);
            this.pnl_UpButton.Controls.Add(this.btnAlarms, 6, 0);
            this.pnl_UpButton.Controls.Add(this.btnCompare, 5, 0);
            this.pnl_UpButton.Controls.Add(this.btnReport, 4, 0);
            this.pnl_UpButton.Controls.Add(this.btnTestStop, 2, 0);
            this.pnl_UpButton.Controls.Add(this.btnTestStart, 1, 0);
            this.pnl_UpButton.Controls.Add(this.btnTestCall, 0, 0);
            this.pnl_UpButton.Controls.Add(this.btnTestFinished, 3, 0);
            this.pnl_UpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_UpButton.Location = new System.Drawing.Point(213, 0);
            this.pnl_UpButton.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_UpButton.Name = "pnl_UpButton";
            this.pnl_UpButton.RowCount = 1;
            this.pnl_UpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnl_UpButton.Size = new System.Drawing.Size(1051, 73);
            this.pnl_UpButton.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(928, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 73);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalibration
            // 
            this.btnCalibration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalibration.FlatAppearance.BorderSize = 0;
            this.btnCalibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalibration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCalibration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalibration.Location = new System.Drawing.Point(812, 0);
            this.btnCalibration.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(116, 73);
            this.btnCalibration.TabIndex = 17;
            this.btnCalibration.Text = "Kalibrasyon";
            this.btnCalibration.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCalibration.UseVisualStyleBackColor = false;
            // 
            // btnAlarms
            // 
            this.btnAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlarms.FlatAppearance.BorderSize = 0;
            this.btnAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAlarms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlarms.Location = new System.Drawing.Point(696, 0);
            this.btnAlarms.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlarms.Name = "btnAlarms";
            this.btnAlarms.Size = new System.Drawing.Size(116, 73);
            this.btnAlarms.TabIndex = 16;
            this.btnAlarms.Text = "Alarmlar";
            this.btnAlarms.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAlarms.UseVisualStyleBackColor = false;
            // 
            // btnCompare
            // 
            this.btnCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompare.FlatAppearance.BorderSize = 0;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCompare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompare.Location = new System.Drawing.Point(580, 0);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(116, 73);
            this.btnCompare.TabIndex = 15;
            this.btnCompare.Text = "Karşılaştır";
            this.btnCompare.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            this.btnCompare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCompare_MouseDown);
            this.btnCompare.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCompare_MouseUp);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReport.Location = new System.Drawing.Point(464, 0);
            this.btnReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(116, 73);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Rapor";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnTestStop
            // 
            this.btnTestStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestStop.FlatAppearance.BorderSize = 0;
            this.btnTestStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestStop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTestStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTestStop.Location = new System.Drawing.Point(232, 0);
            this.btnTestStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnTestStop.Name = "btnTestStop";
            this.btnTestStop.Size = new System.Drawing.Size(116, 73);
            this.btnTestStop.TabIndex = 12;
            this.btnTestStop.Text = "Test Durdur";
            this.btnTestStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTestStop.UseVisualStyleBackColor = false;
            // 
            // btnTestStart
            // 
            this.btnTestStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestStart.FlatAppearance.BorderSize = 0;
            this.btnTestStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTestStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTestStart.Location = new System.Drawing.Point(116, 0);
            this.btnTestStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnTestStart.Name = "btnTestStart";
            this.btnTestStart.Size = new System.Drawing.Size(116, 73);
            this.btnTestStart.TabIndex = 11;
            this.btnTestStart.Text = "Test Başlat";
            this.btnTestStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTestStart.UseVisualStyleBackColor = false;
            // 
            // btnTestCall
            // 
            this.btnTestCall.BackColor = System.Drawing.Color.Transparent;
            this.btnTestCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestCall.FlatAppearance.BorderSize = 0;
            this.btnTestCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestCall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTestCall.Location = new System.Drawing.Point(0, 0);
            this.btnTestCall.Margin = new System.Windows.Forms.Padding(0);
            this.btnTestCall.Name = "btnTestCall";
            this.btnTestCall.Size = new System.Drawing.Size(116, 73);
            this.btnTestCall.TabIndex = 10;
            this.btnTestCall.Text = "Test Çağır";
            this.btnTestCall.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTestCall.UseVisualStyleBackColor = true;
            this.btnTestCall.Click += new System.EventHandler(this.btnTestCall_Click);
            this.btnTestCall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTestCall_MouseDown);
            this.btnTestCall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTestCall_MouseUp);
            // 
            // btnTestFinished
            // 
            this.btnTestFinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestFinished.FlatAppearance.BorderSize = 0;
            this.btnTestFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestFinished.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTestFinished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTestFinished.Location = new System.Drawing.Point(348, 0);
            this.btnTestFinished.Margin = new System.Windows.Forms.Padding(0);
            this.btnTestFinished.Name = "btnTestFinished";
            this.btnTestFinished.Size = new System.Drawing.Size(116, 73);
            this.btnTestFinished.TabIndex = 13;
            this.btnTestFinished.Text = "Test Bitir";
            this.btnTestFinished.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTestFinished.UseVisualStyleBackColor = false;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.pnlDesktop.Location = new System.Drawing.Point(213, 73);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDesktop.Name = "pnlDesktop";
            // 
            // pnlDesktop.Panel1
            // 
            this.pnlDesktop.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // pnlDesktop.Panel2
            // 
            this.pnlDesktop.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlDesktop.Size = new System.Drawing.Size(1051, 608);
            this.pnlDesktop.SplitterDistance = 187;
            this.pnlDesktop.SplitterWidth = 2;
            this.pnlDesktop.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.ColumnCount = 1;
            this.pnlLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlLeft.Controls.Add(this.picBox1, 0, 6);
            this.pnlLeft.Controls.Add(this.lblStateInf, 0, 0);
            this.pnlLeft.Controls.Add(this.txtForce, 0, 5);
            this.pnlLeft.Controls.Add(this.lblPosition, 0, 2);
            this.pnlLeft.Controls.Add(this.txtPosition, 0, 3);
            this.pnlLeft.Controls.Add(this.lblForce, 0, 4);
            this.pnlLeft.Controls.Add(this.txtStateInf, 0, 1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 73);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.RowCount = 7;
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.662665F));
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.662665F));
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.662665F));
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.662665F));
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.662665F));
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.662665F));
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.02401F));
            this.pnlLeft.Size = new System.Drawing.Size(213, 608);
            this.pnlLeft.TabIndex = 2;
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox1.BackgroundImage")));
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox1.Location = new System.Drawing.Point(0, 240);
            this.picBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(213, 348);
            this.picBox1.TabIndex = 5;
            this.picBox1.TabStop = false;
            // 
            // lblStateInf
            // 
            this.lblStateInf.AutoSize = true;
            this.lblStateInf.BackColor = System.Drawing.Color.Transparent;
            this.lblStateInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStateInf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStateInf.Location = new System.Drawing.Point(0, 5);
            this.lblStateInf.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblStateInf.Name = "lblStateInf";
            this.lblStateInf.Size = new System.Drawing.Size(213, 35);
            this.lblStateInf.TabIndex = 4;
            this.lblStateInf.Text = "DURUM BİLGİSİ";
            this.lblStateInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtForce
            // 
            this.txtForce.BackColor = System.Drawing.SystemColors.Window;
            this.txtForce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtForce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtForce.ForeColor = System.Drawing.Color.Black;
            this.txtForce.Location = new System.Drawing.Point(10, 203);
            this.txtForce.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.txtForce.MinimumSize = new System.Drawing.Size(50, 15);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(193, 29);
            this.txtForce.TabIndex = 3;
            this.txtForce.Text = "0 N";
            this.txtForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPosition.Location = new System.Drawing.Point(0, 80);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(213, 40);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Pozisyon (Position)";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.SystemColors.Window;
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPosition.ForeColor = System.Drawing.Color.White;
            this.txtPosition.Location = new System.Drawing.Point(10, 123);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.txtPosition.MinimumSize = new System.Drawing.Size(50, 15);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(193, 29);
            this.txtPosition.TabIndex = 3;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.BackColor = System.Drawing.Color.Transparent;
            this.lblForce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblForce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblForce.Location = new System.Drawing.Point(0, 160);
            this.lblForce.Margin = new System.Windows.Forms.Padding(0);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(213, 40);
            this.lblForce.TabIndex = 4;
            this.lblForce.Text = "Kuvvet (Force)";
            this.lblForce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStateInf
            // 
            this.txtStateInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(111)))), ((int)(((byte)(135)))));
            this.txtStateInf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStateInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStateInf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStateInf.ForeColor = System.Drawing.Color.White;
            this.txtStateInf.Location = new System.Drawing.Point(0, 43);
            this.txtStateInf.Margin = new System.Windows.Forms.Padding(0, 3, 0, 10);
            this.txtStateInf.MinimumSize = new System.Drawing.Size(50, 15);
            this.txtStateInf.Name = "txtStateInf";
            this.txtStateInf.Size = new System.Drawing.Size(213, 29);
            this.txtStateInf.TabIndex = 3;
            this.txtStateInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_General);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_General.ResumeLayout(false);
            this.pnl_StartStop.ResumeLayout(false);
            this.pnl_UpButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesktop)).EndInit();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnl_General;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtStateInf;
        private System.Windows.Forms.Label lblStateInf;
        private System.Windows.Forms.TextBox txtForce;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblForce;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox picBox1;
        public System.Windows.Forms.SplitContainer pnlDesktop;
        private System.Windows.Forms.TableLayoutPanel pnl_UpButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalibration;
        public System.Windows.Forms.Button btnCompare;
        public System.Windows.Forms.Button btnTestStart;
        public System.Windows.Forms.Button btnTestCall;
        private System.Windows.Forms.TableLayoutPanel pnl_StartStop;
        public System.Windows.Forms.Button btnReport;
        public System.Windows.Forms.Button btnTestStop;
        public System.Windows.Forms.Button btnTestFinished;
        private System.Windows.Forms.Button btnAlarms;
        private System.Windows.Forms.TableLayoutPanel pnlLeft;
    }
}

