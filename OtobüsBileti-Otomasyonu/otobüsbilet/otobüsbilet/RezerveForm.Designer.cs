namespace otobüsbilet
{
    partial class RezerveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(164, 103);
            this.txtisim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(128, 20);
            this.txtisim.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(164, 140);
            this.txtSoyisim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(128, 20);
            this.txtSoyisim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim :";
            // 
            // mskTel
            // 
            this.mskTel.AutoSize = true;
            this.mskTel.Location = new System.Drawing.Point(95, 173);
            this.mskTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(50, 13);
            this.mskTel.TabIndex = 4;
            this.mskTel.Text = "Telefon";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(164, 166);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(128, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // RezerveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 361);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RezerveForm";
            this.Text = "RezerveForm";
            this.Load += new System.EventHandler(this.RezerveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mskTel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}