namespace DoAn_CNPM
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnchoiTiep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Location = new System.Drawing.Point(367, 250);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(173, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.Transparent;
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuide.Location = new System.Drawing.Point(367, 297);
            this.btnGuide.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(173, 23);
            this.btnGuide.TabIndex = 1;
            this.btnGuide.Text = "Hướng dẫn";
            this.btnGuide.UseVisualStyleBackColor = false;
            // 
            // btnHighScore
            // 
            this.btnHighScore.BackColor = System.Drawing.Color.Transparent;
            this.btnHighScore.FlatAppearance.BorderSize = 0;
            this.btnHighScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHighScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScore.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHighScore.Location = new System.Drawing.Point(367, 344);
            this.btnHighScore.Margin = new System.Windows.Forms.Padding(2);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(173, 23);
            this.btnHighScore.TabIndex = 2;
            this.btnHighScore.Text = "Điểm Cao";
            this.btnHighScore.UseVisualStyleBackColor = false;
            // 
            // btnchoiTiep
            // 
            this.btnchoiTiep.BackColor = System.Drawing.Color.Transparent;
            this.btnchoiTiep.FlatAppearance.BorderSize = 0;
            this.btnchoiTiep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnchoiTiep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnchoiTiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchoiTiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchoiTiep.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnchoiTiep.Location = new System.Drawing.Point(367, 201);
            this.btnchoiTiep.Margin = new System.Windows.Forms.Padding(2);
            this.btnchoiTiep.Name = "btnchoiTiep";
            this.btnchoiTiep.Size = new System.Drawing.Size(173, 27);
            this.btnchoiTiep.TabIndex = 3;
            this.btnchoiTiep.Text = "Chơi Tiếp";
            this.btnchoiTiep.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_CNPM.Properties.Resources.trangchu21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 390);
            this.Controls.Add(this.btnchoiTiep);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnGuide);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(631, 429);
            this.MinimumSize = new System.Drawing.Size(631, 427);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnchoiTiep;
    }
}