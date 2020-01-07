namespace NBA_LP_Projekt
{
    partial class FormNBA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNBA));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProvjeri = new System.Windows.Forms.Button();
            this.txtIgrac = new System.Windows.Forms.TextBox();
            this.lblIgrac = new System.Windows.Forms.Label();
            this.btnDodajIgraca = new System.Windows.Forms.Button();
            this.txtKlub = new System.Windows.Forms.TextBox();
            this.lblKlub = new System.Windows.Forms.Label();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvjeri.Location = new System.Drawing.Point(65, 472);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(133, 51);
            this.btnProvjeri.TabIndex = 1;
            this.btnProvjeri.Text = "Provjeri";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // txtIgrac
            // 
            this.txtIgrac.Location = new System.Drawing.Point(65, 402);
            this.txtIgrac.Name = "txtIgrac";
            this.txtIgrac.Size = new System.Drawing.Size(351, 22);
            this.txtIgrac.TabIndex = 2;
            // 
            // lblIgrac
            // 
            this.lblIgrac.AutoSize = true;
            this.lblIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgrac.Location = new System.Drawing.Point(62, 362);
            this.lblIgrac.Name = "lblIgrac";
            this.lblIgrac.Size = new System.Drawing.Size(75, 29);
            this.lblIgrac.TabIndex = 3;
            this.lblIgrac.Text = "Igrač:";
            // 
            // btnDodajIgraca
            // 
            this.btnDodajIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajIgraca.Location = new System.Drawing.Point(731, 472);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(179, 51);
            this.btnDodajIgraca.TabIndex = 4;
            this.btnDodajIgraca.Text = "Dodaj igrača";
            this.btnDodajIgraca.UseVisualStyleBackColor = true;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // txtKlub
            // 
            this.txtKlub.Location = new System.Drawing.Point(731, 402);
            this.txtKlub.Name = "txtKlub";
            this.txtKlub.Size = new System.Drawing.Size(351, 22);
            this.txtKlub.TabIndex = 2;
            // 
            // lblKlub
            // 
            this.lblKlub.AutoSize = true;
            this.lblKlub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlub.Location = new System.Drawing.Point(726, 362);
            this.lblKlub.Name = "lblKlub";
            this.lblKlub.Size = new System.Drawing.Size(71, 29);
            this.lblKlub.TabIndex = 3;
            this.lblKlub.Text = "Klub:";
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(731, 580);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(46, 17);
            this.lblPomoc.TabIndex = 5;
            this.lblPomoc.Text = "label1";
            // 
            // FormNBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 706);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.btnDodajIgraca);
            this.Controls.Add(this.lblKlub);
            this.Controls.Add(this.lblIgrac);
            this.Controls.Add(this.txtKlub);
            this.Controls.Add(this.txtIgrac);
            this.Controls.Add(this.btnProvjeri);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormNBA";
            this.Text = "NBA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNBA_FormClosing);
            this.Load += new System.EventHandler(this.FormNBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProvjeri;
        private System.Windows.Forms.TextBox txtIgrac;
        private System.Windows.Forms.Label lblIgrac;
        private System.Windows.Forms.Button btnDodajIgraca;
        private System.Windows.Forms.TextBox txtKlub;
        private System.Windows.Forms.Label lblKlub;
        private System.Windows.Forms.Label lblPomoc;
    }
}

