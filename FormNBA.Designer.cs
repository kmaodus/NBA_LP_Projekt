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
            this.txtObrisiIgraca = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDodavanje = new System.Windows.Forms.TabPage();
            this.tabBrisanje = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDodavanje.SuspendLayout();
            this.tabBrisanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvjeri.Location = new System.Drawing.Point(40, 150);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(133, 51);
            this.btnProvjeri.TabIndex = 1;
            this.btnProvjeri.Text = "Provjeri";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // txtIgrac
            // 
            this.txtIgrac.Location = new System.Drawing.Point(40, 90);
            this.txtIgrac.Name = "txtIgrac";
            this.txtIgrac.Size = new System.Drawing.Size(351, 27);
            this.txtIgrac.TabIndex = 2;
            // 
            // lblIgrac
            // 
            this.lblIgrac.AutoSize = true;
            this.lblIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgrac.Location = new System.Drawing.Point(40, 40);
            this.lblIgrac.Name = "lblIgrac";
            this.lblIgrac.Size = new System.Drawing.Size(249, 29);
            this.lblIgrac.TabIndex = 3;
            this.lblIgrac.Text = "Ime i prezime igrača:";
            // 
            // btnDodajIgraca
            // 
            this.btnDodajIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajIgraca.Location = new System.Drawing.Point(45, 435);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(179, 51);
            this.btnDodajIgraca.TabIndex = 4;
            this.btnDodajIgraca.Text = "Dodaj igrača";
            this.btnDodajIgraca.UseVisualStyleBackColor = true;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // txtKlub
            // 
            this.txtKlub.Location = new System.Drawing.Point(45, 376);
            this.txtKlub.Name = "txtKlub";
            this.txtKlub.Size = new System.Drawing.Size(351, 27);
            this.txtKlub.TabIndex = 2;
            // 
            // lblKlub
            // 
            this.lblKlub.AutoSize = true;
            this.lblKlub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlub.Location = new System.Drawing.Point(40, 336);
            this.lblKlub.Name = "lblKlub";
            this.lblKlub.Size = new System.Drawing.Size(71, 29);
            this.lblKlub.TabIndex = 3;
            this.lblKlub.Text = "Klub:";
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(171, 344);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(53, 20);
            this.lblPomoc.TabIndex = 5;
            this.lblPomoc.Text = "label1";
            // 
            // txtObrisiIgraca
            // 
            this.txtObrisiIgraca.Location = new System.Drawing.Point(40, 90);
            this.txtObrisiIgraca.Name = "txtObrisiIgraca";
            this.txtObrisiIgraca.Size = new System.Drawing.Size(351, 27);
            this.txtObrisiIgraca.TabIndex = 7;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(40, 150);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(133, 51);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDodavanje);
            this.tabControl1.Controls.Add(this.tabBrisanje);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(49, 251);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 555);
            this.tabControl1.TabIndex = 10;
            // 
            // tabDodavanje
            // 
            this.tabDodavanje.Controls.Add(this.lblIgrac);
            this.tabDodavanje.Controls.Add(this.btnProvjeri);
            this.tabDodavanje.Controls.Add(this.txtIgrac);
            this.tabDodavanje.Controls.Add(this.lblKlub);
            this.tabDodavanje.Controls.Add(this.lblPomoc);
            this.tabDodavanje.Controls.Add(this.txtKlub);
            this.tabDodavanje.Controls.Add(this.btnDodajIgraca);
            this.tabDodavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDodavanje.Location = new System.Drawing.Point(4, 29);
            this.tabDodavanje.Name = "tabDodavanje";
            this.tabDodavanje.Padding = new System.Windows.Forms.Padding(3);
            this.tabDodavanje.Size = new System.Drawing.Size(832, 522);
            this.tabDodavanje.TabIndex = 0;
            this.tabDodavanje.Text = "Dodavanje";
            this.tabDodavanje.UseVisualStyleBackColor = true;
            // 
            // tabBrisanje
            // 
            this.tabBrisanje.Controls.Add(this.label1);
            this.tabBrisanje.Controls.Add(this.txtObrisiIgraca);
            this.tabBrisanje.Controls.Add(this.btnObrisi);
            this.tabBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBrisanje.Location = new System.Drawing.Point(4, 25);
            this.tabBrisanje.Name = "tabBrisanje";
            this.tabBrisanje.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrisanje.Size = new System.Drawing.Size(664, 559);
            this.tabBrisanje.TabIndex = 1;
            this.tabBrisanje.Text = "Brisanje";
            this.tabBrisanje.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime i prezime igrača:";
            // 
            // FormNBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 845);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormNBA";
            this.Text = "NBA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNBA_FormClosing);
            this.Load += new System.EventHandler(this.FormNBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDodavanje.ResumeLayout(false);
            this.tabDodavanje.PerformLayout();
            this.tabBrisanje.ResumeLayout(false);
            this.tabBrisanje.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtObrisiIgraca;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDodavanje;
        private System.Windows.Forms.TabPage tabBrisanje;
        private System.Windows.Forms.Label label1;
    }
}

