namespace WFA191010MF
{
    partial class FrmFoAblak
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
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnUjAblak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbData.Location = new System.Drawing.Point(166, 12);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(305, 45);
            this.tbData.TabIndex = 0;
            // 
            // btnUjAblak
            // 
            this.btnUjAblak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjAblak.Location = new System.Drawing.Point(12, 87);
            this.btnUjAblak.Name = "btnUjAblak";
            this.btnUjAblak.Size = new System.Drawing.Size(459, 64);
            this.btnUjAblak.TabIndex = 1;
            this.btnUjAblak.Text = "Új Ablak";
            this.btnUjAblak.UseVisualStyleBackColor = true;
            this.btnUjAblak.Click += new System.EventHandler(this.btnUjAblak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "rnd text:";
            // 
            // FrmFoAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUjAblak);
            this.Controls.Add(this.tbData);
            this.Name = "FrmFoAblak";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnUjAblak;
    }
}

