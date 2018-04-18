namespace DoAn_CNPM
{
    partial class PlayGame
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.lblSTT = new System.Windows.Forms.Label();
            this.btn50 = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnAu = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblQues = new System.Windows.Forms.Label();
            this.btndapanA = new System.Windows.Forms.Button();
            this.btndapanB = new System.Windows.Forms.Button();
            this.btndapanC = new System.Windows.Forms.Button();
            this.btndapanD = new System.Windows.Forms.Button();
            this.tmSec = new System.Windows.Forms.Timer(this.components);
            this.pnlCall = new System.Windows.Forms.Panel();
            this.rtxtBoxCall = new DoAn_CNPM.CustomListView();
            this.pnlAu = new System.Windows.Forms.Panel();
            this.rtxtBoxAu = new DoAn_CNPM.CustomListView();
            this.Percent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmCall = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.pnlCall.SuspendLayout();
            this.pnlAu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Percent)).BeginInit();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.BackColor = System.Drawing.Color.Transparent;
            this.lblSTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSTT.Location = new System.Drawing.Point(164, 342);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(62, 26);
            this.lblSTT.TabIndex = 0;
            this.lblSTT.Text = "Câu:";
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.Transparent;
            this.btn50.FlatAppearance.BorderSize = 0;
            this.btn50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn50.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn50.Location = new System.Drawing.Point(27, 40);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(62, 57);
            this.btn50.TabIndex = 1;
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.Transparent;
            this.btnCall.FlatAppearance.BorderSize = 0;
            this.btnCall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCall.Location = new System.Drawing.Point(108, 40);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(62, 57);
            this.btnCall.TabIndex = 2;
            this.btnCall.UseVisualStyleBackColor = false;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnAu
            // 
            this.btnAu.BackColor = System.Drawing.Color.Transparent;
            this.btnAu.FlatAppearance.BorderSize = 0;
            this.btnAu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAu.Location = new System.Drawing.Point(194, 40);
            this.btnAu.Name = "btnAu";
            this.btnAu.Size = new System.Drawing.Size(62, 57);
            this.btnAu.TabIndex = 3;
            this.btnAu.UseVisualStyleBackColor = false;
            this.btnAu.Click += new System.EventHandler(this.btnAu_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(738, 52);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 41);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "30";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMoney.Location = new System.Drawing.Point(660, 342);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(48, 26);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "$$$";
            // 
            // lblQues
            // 
            this.lblQues.AutoSize = true;
            this.lblQues.BackColor = System.Drawing.Color.Transparent;
            this.lblQues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQues.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQues.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQues.Location = new System.Drawing.Point(159, 432);
            this.lblQues.Name = "lblQues";
            this.lblQues.Size = new System.Drawing.Size(0, 36);
            this.lblQues.TabIndex = 6;
            // 
            // btndapanA
            // 
            this.btndapanA.BackColor = System.Drawing.Color.Transparent;
            this.btndapanA.FlatAppearance.BorderSize = 0;
            this.btndapanA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndapanA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndapanA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndapanA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndapanA.Location = new System.Drawing.Point(160, 528);
            this.btndapanA.Name = "btndapanA";
            this.btndapanA.Size = new System.Drawing.Size(268, 57);
            this.btndapanA.TabIndex = 7;
            this.btndapanA.UseVisualStyleBackColor = false;
            this.btndapanA.Click += new System.EventHandler(this.btndapanA_Click);
            // 
            // btndapanB
            // 
            this.btndapanB.BackColor = System.Drawing.Color.Transparent;
            this.btndapanB.FlatAppearance.BorderSize = 0;
            this.btndapanB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndapanB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndapanB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndapanB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndapanB.Location = new System.Drawing.Point(524, 528);
            this.btndapanB.Name = "btndapanB";
            this.btndapanB.Size = new System.Drawing.Size(268, 57);
            this.btndapanB.TabIndex = 8;
            this.btndapanB.UseVisualStyleBackColor = false;
            this.btndapanB.Click += new System.EventHandler(this.btndapanB_Click);
            // 
            // btndapanC
            // 
            this.btndapanC.BackColor = System.Drawing.Color.Transparent;
            this.btndapanC.FlatAppearance.BorderSize = 0;
            this.btndapanC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndapanC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndapanC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndapanC.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndapanC.Location = new System.Drawing.Point(160, 615);
            this.btndapanC.Name = "btndapanC";
            this.btndapanC.Size = new System.Drawing.Size(268, 57);
            this.btndapanC.TabIndex = 9;
            this.btndapanC.UseVisualStyleBackColor = false;
            this.btndapanC.Click += new System.EventHandler(this.btndapanC_Click);
            // 
            // btndapanD
            // 
            this.btndapanD.BackColor = System.Drawing.Color.Transparent;
            this.btndapanD.FlatAppearance.BorderSize = 0;
            this.btndapanD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndapanD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndapanD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndapanD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndapanD.Location = new System.Drawing.Point(524, 612);
            this.btndapanD.Name = "btndapanD";
            this.btndapanD.Size = new System.Drawing.Size(268, 57);
            this.btndapanD.TabIndex = 10;
            this.btndapanD.UseVisualStyleBackColor = false;
            this.btndapanD.Click += new System.EventHandler(this.btndapanD_Click);
            // 
            // tmSec
            // 
            this.tmSec.Interval = 1000;
            this.tmSec.Tick += new System.EventHandler(this.tmSec_Tick);
            // 
            // pnlCall
            // 
            this.pnlCall.BackColor = System.Drawing.Color.Transparent;
            this.pnlCall.BackgroundImage = global::DoAn_CNPM.Properties.Resources.background12;
            this.pnlCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCall.Controls.Add(this.rtxtBoxCall);
            this.pnlCall.Controls.Add(this.pnlAu);
            this.pnlCall.Controls.Add(this.btnClose);
            this.pnlCall.Controls.Add(this.listView1);
            this.pnlCall.Location = new System.Drawing.Point(262, 2);
            this.pnlCall.Name = "pnlCall";
            this.pnlCall.Size = new System.Drawing.Size(675, 337);
            this.pnlCall.TabIndex = 11;
            this.pnlCall.Visible = false;
            // 
            // rtxtBoxCall
            // 
            this.rtxtBoxCall.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBoxCall.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxtBoxCall.Location = new System.Drawing.Point(0, 38);
            this.rtxtBoxCall.Name = "rtxtBoxCall";
            this.rtxtBoxCall.Size = new System.Drawing.Size(675, 299);
            this.rtxtBoxCall.TabIndex = 4;
            this.rtxtBoxCall.Text = "";
            this.rtxtBoxCall.Visible = false;
            // 
            // pnlAu
            // 
            this.pnlAu.Controls.Add(this.rtxtBoxAu);
            this.pnlAu.Controls.Add(this.Percent);
            this.pnlAu.Location = new System.Drawing.Point(3, 38);
            this.pnlAu.Name = "pnlAu";
            this.pnlAu.Size = new System.Drawing.Size(672, 292);
            this.pnlAu.TabIndex = 3;
            this.pnlAu.Visible = false;
            // 
            // rtxtBoxAu
            // 
            this.rtxtBoxAu.BackColor = System.Drawing.Color.Transparent;
            this.rtxtBoxAu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtBoxAu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtBoxAu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBoxAu.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxtBoxAu.Location = new System.Drawing.Point(387, 0);
            this.rtxtBoxAu.Name = "rtxtBoxAu";
            this.rtxtBoxAu.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtBoxAu.Size = new System.Drawing.Size(285, 292);
            this.rtxtBoxAu.TabIndex = 1;
            this.rtxtBoxAu.Text = "";
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.Color.Transparent;
            this.Percent.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.Percent.ChartAreas.Add(chartArea1);
            this.Percent.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.Percent.Legends.Add(legend1);
            this.Percent.Location = new System.Drawing.Point(0, 0);
            this.Percent.Name = "Percent";
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelBorderWidth = 0;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series1.Name = "Percent";
            this.Percent.Series.Add(series1);
            this.Percent.Size = new System.Drawing.Size(387, 292);
            this.Percent.TabIndex = 0;
            this.Percent.Text = "Percent";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(592, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = global::DoAn_CNPM.Properties.Resources.background12;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colJob});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 296);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 275;
            // 
            // colJob
            // 
            this.colJob.Text = "Job";
            this.colJob.Width = 184;
            // 
            // tmCall
            // 
            this.tmCall.Interval = 1000;
            this.tmCall.Tick += new System.EventHandler(this.tmCall_Tick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(683, 23);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(53, 90);
            this.btnPause.TabIndex = 12;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.BackgroundImage = global::DoAn_CNPM.Properties.Resources.background12;
            this.pnlSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Controls.Add(this.lblHighScore);
            this.pnlSave.Controls.Add(this.label2);
            this.pnlSave.Controls.Add(this.txtUserName);
            this.pnlSave.Controls.Add(this.label1);
            this.pnlSave.Location = new System.Drawing.Point(99, 292);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(742, 413);
            this.pnlSave.TabIndex = 13;
            this.pnlSave.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(321, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 53);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Location = new System.Drawing.Point(368, 114);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(0, 36);
            this.lblHighScore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(161, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chúc mừng bạn đã được số điểm";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(259, 207);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(310, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(144, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblCheck.ForeColor = System.Drawing.Color.Transparent;
            this.lblCheck.Location = new System.Drawing.Point(3, 273);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(0, 20);
            this.lblCheck.TabIndex = 14;
            this.lblCheck.Visible = false;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_CNPM.Properties.Resources.giaodien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 724);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.pnlSave);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pnlCall);
            this.Controls.Add(this.btndapanD);
            this.Controls.Add(this.btndapanC);
            this.Controls.Add(this.btndapanB);
            this.Controls.Add(this.btndapanA);
            this.Controls.Add(this.lblQues);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnAu);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.lblSTT);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 780);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(956, 727);
            this.Name = "PlayGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ai là triệu phú";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            this.pnlCall.ResumeLayout(false);
            this.pnlAu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Percent)).EndInit();
            this.pnlSave.ResumeLayout(false);
            this.pnlSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnAu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblQues;
        private System.Windows.Forms.Button btndapanA;
        private System.Windows.Forms.Button btndapanB;
        private System.Windows.Forms.Button btndapanC;
        private System.Windows.Forms.Button btndapanD;
        private System.Windows.Forms.Timer tmSec;
        private System.Windows.Forms.Panel pnlCall;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colJob;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer tmCall;
        private System.Windows.Forms.Panel pnlAu;
        private System.Windows.Forms.DataVisualization.Charting.Chart Percent;
        private CustomListView rtxtBoxAu;
        private CustomListView rtxtBoxCall;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblCheck;
    }
}