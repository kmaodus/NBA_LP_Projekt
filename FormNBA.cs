using System;
using System.Windows.Forms;
using SbsSW.SwiPlCs;

namespace NBA_LP_Projekt
{
    public partial class FormNBA : Form
    {
        public FormNBA()
        {
            InitializeComponent();
            lblKlub.Hide();
            txtKlub.Hide();
            lblPomoc.Hide();
            btnDodajIgraca.Hide();
        }

        private void FormNBA_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"prolog");
            Environment.SetEnvironmentVariable("Path", @"prolog");
            Environment.SetEnvironmentVariable("Path", @"prolog\bin");
            string[] parametri = { "-q", "-f", @"nba.pl" };
            PlEngine.Initialize(parametri);
            PlQuery postojiDatoteka = new PlQuery("postojiDatoteka");
            postojiDatoteka.NextSolution();
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            PlQuery nba = new PlQuery("igrac(I,K)");
            nba.Variables["I"].Unify(txtIgrac.Text.ToLower());
            if (nba.NextSolution() == true)
            {
                MessageBox.Show("Igrač " + txtIgrac.Text + " igra za klub " + nba.Variables["K"].ToString().ToUpper());
                txtIgrac.Text = "";
                txtIgrac.Focus();
            }
            else
            {
                MessageBox.Show("Igrač nije pronađen!");
                DialogResult r = MessageBox.Show("Dodaj igrača?", "", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    lblPomoc.Visible = true;
                    lblKlub.Visible = true;
                    txtKlub.Visible = true;
                    btnDodajIgraca.Visible = true;
                    lblPomoc.Text = "Klub za koji igra igrač " + txtIgrac.Text + " je";
                    txtKlub.Focus();
                }
                else
                    MessageBox.Show("U redu.");
            }
        }

        private void FormNBA_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlQuery zatvoriDatoteku = new PlQuery("zatvoriDatoteku");
            zatvoriDatoteku.NextSolution();
            PlEngine.PlCleanup();
        }


        private void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            PlQuery dodajIgraca = new PlQuery("dodajIgraca(I, K)");
            PlQuery dodajKlub = new PlQuery("dodajKlub(K)");
            dodajKlub.Variables["K"].Unify(txtKlub.Text.ToLower());
            if (dodajKlub.NextSolution() == true)
            {
                dodajKlub.NextSolution();
            }
            else
            {
                MessageBox.Show("Klub " + txtKlub.Text + " već je dodan!");
            }
            
            dodajIgraca.Variables["I"].Unify(txtIgrac.Text.ToLower());
            dodajIgraca.Variables["K"].Unify(txtKlub.Text.ToLower());
            dodajIgraca.NextSolution();
            txtKlub.Visible = false;
            btnDodajIgraca.Visible = false;
            lblKlub.Visible = false;
            lblPomoc.Text = "";
            MessageBox.Show("Igrač uspješno dodan");
            }

        private void btnObrisiIgraca_Click(object sender, EventArgs e)
        {
            PlQuery obrisiIgraca = new PlQuery("obrisiIgraca(I)");
            obrisiIgraca.Variables["I"].Unify(txtObrisiIgraca.Text.ToLower());
            if (obrisiIgraca.NextSolution() == true)
            {
                obrisiIgraca.NextSolution();
                MessageBox.Show("Igrač " + txtObrisiIgraca.Text + " uspješno obrisan");
            }
            else
            {
                MessageBox.Show("Igrač " + txtObrisiIgraca.Text + " nije prethodno dodan!");
            }
        }

        private void btnObrisiKlub_Click(object sender, EventArgs e)
        {
            PlQuery obrisiKlub = new PlQuery("obrisiKlub(K)");
            obrisiKlub.Variables["K"].Unify(txtObrisiKlub.Text.ToLower());
            obrisiKlub.NextSolution();
            
            if (obrisiKlub.NextSolution() == true)
            {
                obrisiKlub.NextSolution();
                MessageBox.Show("Klub " + txtObrisiKlub.Text + " uspješno obrisan");
            }
            else
            {
                MessageBox.Show("Klub " + txtObrisiKlub.Text + " nije prethodno dodan!");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Kristijan Maoduš " + "\n" 
                          + "Kolegij: Logičko programiranje" + "\n"
                          + "Copyright 2020." + "\n"
                          + "Sva prava pridržana");
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program omogućuje provjeru i unos NBA igrača, kao i klubova za koje igraju u trenutnoj 2019./2020. sezoni." + "\n" + "Također, možete obrisati određene igrače i klubove.");
        }

        private void zatvoriAplikacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

