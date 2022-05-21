namespace Ukol_prevody
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_dec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_bin = new System.Windows.Forms.TextBox();
            this.textBox_hex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_dec
            // 
            this.textBox_dec.Location = new System.Drawing.Point(100, 12);
            this.textBox_dec.Name = "textBox_dec";
            this.textBox_dec.Size = new System.Drawing.Size(100, 20);
            this.textBox_dec.TabIndex = 0;
            this.textBox_dec.TextChanged += new System.EventHandler(this.textBox_dec_TextChanged);
            this.textBox_dec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_dec_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dekadická:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Binární:";
            // 
            // textBox_bin
            // 
            this.textBox_bin.Location = new System.Drawing.Point(100, 38);
            this.textBox_bin.Name = "textBox_bin";
            this.textBox_bin.Size = new System.Drawing.Size(100, 20);
            this.textBox_bin.TabIndex = 2;
            this.textBox_bin.TextChanged += new System.EventHandler(this.textBox_bin_TextChanged);
            this.textBox_bin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_bin_KeyPress);
            // 
            // textBox_hex
            // 
            this.textBox_hex.Location = new System.Drawing.Point(100, 64);
            this.textBox_hex.Name = "textBox_hex";
            this.textBox_hex.Size = new System.Drawing.Size(100, 20);
            this.textBox_hex.TabIndex = 3;
            this.textBox_hex.TextChanged += new System.EventHandler(this.textBox_hex_TextChanged);
            this.textBox_hex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hexadecimální:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 97);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_hex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_bin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_dec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Úkol převody";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_bin;
        private System.Windows.Forms.TextBox textBox_hex;
        private System.Windows.Forms.Label label3;
    }
}

