namespace tomcMatija
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
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.chbDorucak = new System.Windows.Forms.CheckBox();
            this.chbRucak = new System.Windows.Forms.CheckBox();
            this.chbVecera = new System.Windows.Forms.CheckBox();
            this.chbSakriNarudzbu = new System.Windows.Forms.CheckBox();
            this.btPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(170, 29);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(276, 180);
            this.txtPrikaz.TabIndex = 0;
            this.txtPrikaz.Text = "Odabrali ste: ";
            this.txtPrikaz.TextChanged += new System.EventHandler(this.TxtPrikaz_TextChanged);
            // 
            // chbDorucak
            // 
            this.chbDorucak.AutoSize = true;
            this.chbDorucak.Location = new System.Drawing.Point(65, 56);
            this.chbDorucak.Name = "chbDorucak";
            this.chbDorucak.Size = new System.Drawing.Size(67, 17);
            this.chbDorucak.TabIndex = 1;
            this.chbDorucak.Text = "Dorucak";
            this.chbDorucak.UseVisualStyleBackColor = true;
            // 
            // chbRucak
            // 
            this.chbRucak.AutoSize = true;
            this.chbRucak.Location = new System.Drawing.Point(65, 101);
            this.chbRucak.Name = "chbRucak";
            this.chbRucak.Size = new System.Drawing.Size(58, 17);
            this.chbRucak.TabIndex = 2;
            this.chbRucak.Text = "Rucak";
            this.chbRucak.UseVisualStyleBackColor = true;
            // 
            // chbVecera
            // 
            this.chbVecera.AutoSize = true;
            this.chbVecera.Location = new System.Drawing.Point(65, 158);
            this.chbVecera.Name = "chbVecera";
            this.chbVecera.Size = new System.Drawing.Size(60, 17);
            this.chbVecera.TabIndex = 3;
            this.chbVecera.Text = "Vecera";
            this.chbVecera.UseVisualStyleBackColor = true;
            // 
            // chbSakriNarudzbu
            // 
            this.chbSakriNarudzbu.AutoSize = true;
            this.chbSakriNarudzbu.Location = new System.Drawing.Point(170, 238);
            this.chbSakriNarudzbu.Name = "chbSakriNarudzbu";
            this.chbSakriNarudzbu.Size = new System.Drawing.Size(97, 17);
            this.chbSakriNarudzbu.TabIndex = 4;
            this.chbSakriNarudzbu.Text = "Sakri narudzbu";
            this.chbSakriNarudzbu.UseVisualStyleBackColor = true;
            this.chbSakriNarudzbu.CheckedChanged += new System.EventHandler(this.ChbSakriNarudzbu_CheckedChanged);
            // 
            // btPosalji
            // 
            this.btPosalji.Location = new System.Drawing.Point(65, 234);
            this.btPosalji.Name = "btPosalji";
            this.btPosalji.Size = new System.Drawing.Size(75, 23);
            this.btPosalji.TabIndex = 5;
            this.btPosalji.Text = "Posalji";
            this.btPosalji.UseVisualStyleBackColor = true;
            this.btPosalji.Click += new System.EventHandler(this.BtPosalji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 266);
            this.Controls.Add(this.btPosalji);
            this.Controls.Add(this.chbSakriNarudzbu);
            this.Controls.Add(this.chbVecera);
            this.Controls.Add(this.chbRucak);
            this.Controls.Add(this.chbDorucak);
            this.Controls.Add(this.txtPrikaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrikaz;
        private System.Windows.Forms.CheckBox chbDorucak;
        private System.Windows.Forms.CheckBox chbRucak;
        private System.Windows.Forms.CheckBox chbVecera;
        private System.Windows.Forms.CheckBox chbSakriNarudzbu;
        private System.Windows.Forms.Button btPosalji;
    }
}

