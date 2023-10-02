namespace form13
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
            this.cmbDogru = new System.Windows.Forms.ComboBox();
            this.cmbYanlıs = new System.Windows.Forms.ComboBox();
            this.lblDoğru = new System.Windows.Forms.Label();
            this.lblYanlış = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDogru
            // 
            this.cmbDogru.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmbDogru.FormattingEnabled = true;
            this.cmbDogru.Location = new System.Drawing.Point(70, 32);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.Size = new System.Drawing.Size(121, 21);
            this.cmbDogru.TabIndex = 0;
            // 
            // cmbYanlıs
            // 
            this.cmbYanlıs.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmbYanlıs.FormattingEnabled = true;
            this.cmbYanlıs.Location = new System.Drawing.Point(70, 60);
            this.cmbYanlıs.Name = "cmbYanlıs";
            this.cmbYanlıs.Size = new System.Drawing.Size(121, 21);
            this.cmbYanlıs.TabIndex = 1;
            // 
            // lblDoğru
            // 
            this.lblDoğru.AutoSize = true;
            this.lblDoğru.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoğru.Location = new System.Drawing.Point(-6, 28);
            this.lblDoğru.Name = "lblDoğru";
            this.lblDoğru.Size = new System.Drawing.Size(70, 25);
            this.lblDoğru.TabIndex = 2;
            this.lblDoğru.Text = "Doğru:";
            // 
            // lblYanlış
            // 
            this.lblYanlış.AutoSize = true;
            this.lblYanlış.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYanlış.Location = new System.Drawing.Point(-2, 60);
            this.lblYanlış.Name = "lblYanlış";
            this.lblYanlış.Size = new System.Drawing.Size(66, 25);
            this.lblYanlış.TabIndex = 3;
            this.lblYanlış.Text = "Yanlış:";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.Location = new System.Drawing.Point(16, 134);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(48, 25);
            this.lblNet.TabIndex = 4;
            this.lblNet.Text = "Net:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHesapla.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(70, 182);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(121, 51);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesaplama";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(269, 284);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblYanlış);
            this.Controls.Add(this.lblDoğru);
            this.Controls.Add(this.cmbYanlıs);
            this.Controls.Add(this.cmbDogru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDogru;
        private System.Windows.Forms.ComboBox cmbYanlıs;
        private System.Windows.Forms.Label lblDoğru;
        private System.Windows.Forms.Label lblYanlış;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Button btnHesapla;
    }
}

