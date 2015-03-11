namespace PI_VJ4
{
    partial class RM_01
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
            this.lstRezultati = new System.Windows.Forms.ListBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.chkSpremi = new System.Windows.Forms.CheckBox();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.txtPolumjer = new System.Windows.Forms.TextBox();
            this.lblOpseg = new System.Windows.Forms.Label();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.lblPolumjer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRezultati
            // 
            this.lstRezultati.FormattingEnabled = true;
            this.lstRezultati.Location = new System.Drawing.Point(222, 29);
            this.lstRezultati.Name = "lstRezultati";
            this.lstRezultati.Size = new System.Drawing.Size(135, 69);
            this.lstRezultati.TabIndex = 19;
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(106, 159);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(100, 23);
            this.btnOcisti.TabIndex = 18;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(106, 130);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(100, 23);
            this.btnIzracunaj.TabIndex = 17;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // chkSpremi
            // 
            this.chkSpremi.AutoSize = true;
            this.chkSpremi.Location = new System.Drawing.Point(106, 107);
            this.chkSpremi.Name = "chkSpremi";
            this.chkSpremi.Size = new System.Drawing.Size(88, 17);
            this.chkSpremi.TabIndex = 16;
            this.chkSpremi.Text = "Spremi u listu";
            this.chkSpremi.UseVisualStyleBackColor = true;
            // 
            // txtOpseg
            // 
            this.txtOpseg.Location = new System.Drawing.Point(106, 81);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.ReadOnly = true;
            this.txtOpseg.Size = new System.Drawing.Size(100, 20);
            this.txtOpseg.TabIndex = 15;
            this.txtOpseg.Text = "0,00";
            this.txtOpseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.Location = new System.Drawing.Point(106, 55);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.ReadOnly = true;
            this.txtPovrsina.Size = new System.Drawing.Size(100, 20);
            this.txtPovrsina.TabIndex = 14;
            this.txtPovrsina.Text = "0,00";
            this.txtPovrsina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPolumjer
            // 
            this.txtPolumjer.Location = new System.Drawing.Point(106, 29);
            this.txtPolumjer.Name = "txtPolumjer";
            this.txtPolumjer.Size = new System.Drawing.Size(100, 20);
            this.txtPolumjer.TabIndex = 13;
            this.txtPolumjer.Text = "0,00";
            this.txtPolumjer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOpseg
            // 
            this.lblOpseg.AutoSize = true;
            this.lblOpseg.Location = new System.Drawing.Point(28, 84);
            this.lblOpseg.Name = "lblOpseg";
            this.lblOpseg.Size = new System.Drawing.Size(41, 13);
            this.lblOpseg.TabIndex = 12;
            this.lblOpseg.Text = "Opseg:";
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(27, 58);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(51, 13);
            this.lblPovrsina.TabIndex = 11;
            this.lblPovrsina.Text = "Površina:";
            // 
            // lblPolumjer
            // 
            this.lblPolumjer.AutoSize = true;
            this.lblPolumjer.Location = new System.Drawing.Point(28, 32);
            this.lblPolumjer.Name = "lblPolumjer";
            this.lblPolumjer.Size = new System.Drawing.Size(50, 13);
            this.lblPolumjer.TabIndex = 10;
            this.lblPolumjer.Text = "Polumjer:";
            // 
            // RM_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.lstRezultati);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.chkSpremi);
            this.Controls.Add(this.txtOpseg);
            this.Controls.Add(this.txtPovrsina);
            this.Controls.Add(this.txtPolumjer);
            this.Controls.Add(this.lblOpseg);
            this.Controls.Add(this.lblPovrsina);
            this.Controls.Add(this.lblPolumjer);
            this.Name = "RM_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI USER";
            this.Load += new System.EventHandler(this.RM_01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRezultati;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.CheckBox chkSpremi;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.TextBox txtPolumjer;
        private System.Windows.Forms.Label lblOpseg;
        private System.Windows.Forms.Label lblPovrsina;
        private System.Windows.Forms.Label lblPolumjer;
    }
}