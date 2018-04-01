namespace DoAnCNPM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnbatDau = new System.Windows.Forms.Button();
            this.btnhuongDan = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbatDau
            // 
            this.btnbatDau.BackColor = System.Drawing.Color.Transparent;
            this.btnbatDau.FlatAppearance.BorderSize = 0;
            this.btnbatDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatDau.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnbatDau.Image = global::DoAnCNPM.Properties.Resources.background1;
            this.btnbatDau.Location = new System.Drawing.Point(681, 438);
            this.btnbatDau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbatDau.Name = "btnbatDau";
            this.btnbatDau.Size = new System.Drawing.Size(326, 54);
            this.btnbatDau.TabIndex = 0;
            this.btnbatDau.Text = "Bắt Đầu";
            this.btnbatDau.UseVisualStyleBackColor = false;
            this.btnbatDau.Click += new System.EventHandler(this.btnbatDau_Click);
            // 
            // btnhuongDan
            // 
            this.btnhuongDan.BackColor = System.Drawing.Color.Transparent;
            this.btnhuongDan.FlatAppearance.BorderSize = 0;
            this.btnhuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuongDan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnhuongDan.Image = global::DoAnCNPM.Properties.Resources.background1;
            this.btnhuongDan.Location = new System.Drawing.Point(681, 565);
            this.btnhuongDan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhuongDan.Name = "btnhuongDan";
            this.btnhuongDan.Size = new System.Drawing.Size(326, 54);
            this.btnhuongDan.TabIndex = 1;
            this.btnhuongDan.Text = "Hướng Dẫn";
            this.btnhuongDan.UseVisualStyleBackColor = false;
            // 
            // btnDiem
            // 
            this.btnDiem.BackColor = System.Drawing.Color.Transparent;
            this.btnDiem.FlatAppearance.BorderSize = 0;
            this.btnDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDiem.Image = global::DoAnCNPM.Properties.Resources.background1;
            this.btnDiem.Location = new System.Drawing.Point(681, 691);
            this.btnDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(326, 54);
            this.btnDiem.TabIndex = 2;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCNPM.Properties.Resources.trangchu;
            this.ClientSize = new System.Drawing.Size(1106, 794);
            this.Controls.Add(this.btnDiem);
            this.Controls.Add(this.btnhuongDan);
            this.Controls.Add(this.btnbatDau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbatDau;
        private System.Windows.Forms.Button btnhuongDan;
        private System.Windows.Forms.Button btnDiem;
    }
}