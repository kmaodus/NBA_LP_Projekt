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
            this.btnObrisiIgraca = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDodavanje = new System.Windows.Forms.TabPage();
            this.tabBrisanje = new System.Windows.Forms.TabPage();
            this.lblObrisiKlub = new System.Windows.Forms.Label();
            this.txtObrisiKlub = new System.Windows.Forms.TextBox();
            this.btnObrisiKlub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPozadina = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDodavanje.SuspendLayout();
            this.tabBrisanje.SuspendLayout();
            this.panelPozadina.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 276);
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
            this.btnDodajIgraca.Location = new System.Drawing.Point(40, 422);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(179, 51);
            this.btnDodajIgraca.TabIndex = 4;
            this.btnDodajIgraca.Text = "Dodaj igrača";
            this.btnDodajIgraca.UseVisualStyleBackColor = true;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // txtKlub
            // 
            this.txtKlub.Location = new System.Drawing.Point(40, 368);
            this.txtKlub.Name = "txtKlub";
            this.txtKlub.Size = new System.Drawing.Size(351, 27);
            this.txtKlub.TabIndex = 2;
            // 
            // lblKlub
            // 
            this.lblKlub.AutoSize = true;
            this.lblKlub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlub.Location = new System.Drawing.Point(40, 320);
            this.lblKlub.Name = "lblKlub";
            this.lblKlub.Size = new System.Drawing.Size(71, 29);
            this.lblKlub.TabIndex = 3;
            this.lblKlub.Text = "Klub:";
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(171, 331);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(98, 25);
            this.lblPomoc.TabIndex = 5;
            this.lblPomoc.Text = "lblPomoc";
            // 
            // txtObrisiIgraca
            // 
            this.txtObrisiIgraca.BackColor = System.Drawing.SystemColors.Window;
            this.txtObrisiIgraca.Location = new System.Drawing.Point(40, 90);
            this.txtObrisiIgraca.Name = "txtObrisiIgraca";
            this.txtObrisiIgraca.Size = new System.Drawing.Size(351, 27);
            this.txtObrisiIgraca.TabIndex = 7;
            // 
            // btnObrisiIgraca
            // 
            this.btnObrisiIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiIgraca.Location = new System.Drawing.Point(40, 150);
            this.btnObrisiIgraca.Name = "btnObrisiIgraca";
            this.btnObrisiIgraca.Size = new System.Drawing.Size(133, 51);
            this.btnObrisiIgraca.TabIndex = 6;
            this.btnObrisiIgraca.Text = "Obriši";
            this.btnObrisiIgraca.UseVisualStyleBackColor = true;
            this.btnObrisiIgraca.Click += new System.EventHandler(this.btnObrisiIgraca_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDodavanje);
            this.tabControl1.Controls.Add(this.tabBrisanje);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(729, 277);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 555);
            this.tabControl1.TabIndex = 10;
            // 
            // tabDodavanje
            // 
            this.tabDodavanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(183)))));
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
            this.tabDodavanje.Size = new System.Drawing.Size(634, 522);
            this.tabDodavanje.TabIndex = 0;
            this.tabDodavanje.Text = "Dodavanje";
            // 
            // tabBrisanje
            // 
            this.tabBrisanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(23)))), ((int)(((byte)(75)))));
            this.tabBrisanje.Controls.Add(this.lblObrisiKlub);
            this.tabBrisanje.Controls.Add(this.txtObrisiKlub);
            this.tabBrisanje.Controls.Add(this.btnObrisiKlub);
            this.tabBrisanje.Controls.Add(this.label1);
            this.tabBrisanje.Controls.Add(this.txtObrisiIgraca);
            this.tabBrisanje.Controls.Add(this.btnObrisiIgraca);
            this.tabBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBrisanje.Location = new System.Drawing.Point(4, 29);
            this.tabBrisanje.Name = "tabBrisanje";
            this.tabBrisanje.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrisanje.Size = new System.Drawing.Size(634, 522);
            this.tabBrisanje.TabIndex = 1;
            this.tabBrisanje.Text = "Brisanje";
            // 
            // lblObrisiKlub
            // 
            this.lblObrisiKlub.AutoSize = true;
            this.lblObrisiKlub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrisiKlub.Location = new System.Drawing.Point(40, 320);
            this.lblObrisiKlub.Name = "lblObrisiKlub";
            this.lblObrisiKlub.Size = new System.Drawing.Size(273, 29);
            this.lblObrisiKlub.TabIndex = 11;
            this.lblObrisiKlub.Text = "Klub koji želite obrisati:";
            // 
            // txtObrisiKlub
            // 
            this.txtObrisiKlub.Location = new System.Drawing.Point(40, 367);
            this.txtObrisiKlub.Name = "txtObrisiKlub";
            this.txtObrisiKlub.Size = new System.Drawing.Size(351, 27);
            this.txtObrisiKlub.TabIndex = 10;
            // 
            // btnObrisiKlub
            // 
            this.btnObrisiKlub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKlub.Location = new System.Drawing.Point(40, 419);
            this.btnObrisiKlub.Name = "btnObrisiKlub";
            this.btnObrisiKlub.Size = new System.Drawing.Size(133, 51);
            this.btnObrisiKlub.TabIndex = 9;
            this.btnObrisiKlub.Text = "Obriši";
            this.btnObrisiKlub.UseVisualStyleBackColor = true;
            this.btnObrisiKlub.Click += new System.EventHandler(this.btnObrisiKlub_Click);
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
            // panelPozadina
            // 
            this.panelPozadina.AutoSize = true;
            this.panelPozadina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPozadina.BackgroundImage")));
            this.panelPozadina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPozadina.Controls.Add(this.tabControl1);
            this.panelPozadina.Controls.Add(this.pictureBox1);
            this.panelPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPozadina.Location = new System.Drawing.Point(0, 0);
            this.panelPozadina.Name = "panelPozadina";
            this.panelPozadina.Size = new System.Drawing.Size(1421, 845);
            this.panelPozadina.TabIndex = 11;
            // 
            // FormNBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1421, 845);
            this.Controls.Add(this.panelPozadina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNBA";
            this.Text = "Logičko programiranje - NBA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNBA_FormClosing);
            this.Load += new System.EventHandler(this.FormNBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDodavanje.ResumeLayout(false);
            this.tabDodavanje.PerformLayout();
            this.tabBrisanje.ResumeLayout(false);
            this.tabBrisanje.PerformLayout();
            this.panelPozadina.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtObrisiIgraca;
        private System.Windows.Forms.Button btnObrisiIgraca;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDodavanje;
        private System.Windows.Forms.TabPage tabBrisanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblObrisiKlub;
        private System.Windows.Forms.TextBox txtObrisiKlub;
        private System.Windows.Forms.Button btnObrisiKlub;
        private System.Windows.Forms.Panel panelPozadina;
    }
}

