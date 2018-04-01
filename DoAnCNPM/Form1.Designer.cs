namespace DoAnCNPM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbChaoMung = new System.Windows.Forms.GroupBox();
            this.gbChaoMung.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(0, 516);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(739, 10);
            this.progressBar1.TabIndex = 0;
            // 
            // gbChaoMung
            // 
            this.gbChaoMung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbChaoMung.BackgroundImage")));
            this.gbChaoMung.Controls.Add(this.progressBar1);
            this.gbChaoMung.Location = new System.Drawing.Point(0, -7);
            this.gbChaoMung.Name = "gbChaoMung";
            this.gbChaoMung.Size = new System.Drawing.Size(756, 525);
            this.gbChaoMung.TabIndex = 3;
            this.gbChaoMung.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 516);
            this.Controls.Add(this.gbChaoMung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ai Là Triệu Phú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbChaoMung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gbChaoMung;

    }
}

