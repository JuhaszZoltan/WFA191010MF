namespace WFA191010MF
{
    partial class FrmMasikAblak
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
            this.lblSzoveg = new System.Windows.Forms.Label();
            this.rbK = new System.Windows.Forms.RadioButton();
            this.rbP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSzoveg
            // 
            this.lblSzoveg.AutoSize = true;
            this.lblSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzoveg.Location = new System.Drawing.Point(300, 45);
            this.lblSzoveg.Name = "lblSzoveg";
            this.lblSzoveg.Size = new System.Drawing.Size(183, 39);
            this.lblSzoveg.TabIndex = 0;
            this.lblSzoveg.Text = "rnd szöveg";
            // 
            // rbK
            // 
            this.rbK.AutoSize = true;
            this.rbK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbK.Location = new System.Drawing.Point(90, 277);
            this.rbK.Name = "rbK";
            this.rbK.Size = new System.Drawing.Size(97, 43);
            this.rbK.TabIndex = 1;
            this.rbK.TabStop = true;
            this.rbK.Text = "Kék";
            this.rbK.UseVisualStyleBackColor = true;
            // 
            // rbP
            // 
            this.rbP.AutoSize = true;
            this.rbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbP.Location = new System.Drawing.Point(90, 326);
            this.rbP.Name = "rbP";
            this.rbP.Size = new System.Drawing.Size(116, 43);
            this.rbP.TabIndex = 1;
            this.rbP.TabStop = true;
            this.rbP.Text = "Piros";
            this.rbP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Milyen legyen a gomb szine?";
            // 
            // FrmMasikAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 422);
            this.Controls.Add(this.rbP);
            this.Controls.Add(this.rbK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSzoveg);
            this.Name = "FrmMasikAblak";
            this.Text = "FrmMasikAblak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSzoveg;
        private System.Windows.Forms.RadioButton rbK;
        private System.Windows.Forms.RadioButton rbP;
        private System.Windows.Forms.Label label1;
    }
}