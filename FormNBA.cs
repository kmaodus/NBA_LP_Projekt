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
            dodajIgraca.Variables["I"].Unify(txtIgrac.Text.ToLower());
            dodajIgraca.Variables["K"].Unify(txtKlub.Text.ToLower());
            dodajIgraca.NextSolution();
            txtKlub.Visible = false;
            btnDodajIgraca.Visible = false;
            lblKlub.Visible = false;
            lblPomoc.Text = "";
            MessageBox.Show("Igrač uspješno dodan");
            }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            PlQuery obrisiIgraca = new PlQuery("obrisiIgraca(I)");
            obrisiIgraca.Variables["I"].Unify(txtObrisiIgraca.Text.ToLower());
            obrisiIgraca.NextSolution();
            MessageBox.Show("Igrač uspješno obrisan");
        }
    }
    }

