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
        }

        private void FormNBA_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"prolog");
            Environment.SetEnvironmentVariable("Path", @"prolog");
            Environment.SetEnvironmentVariable("Path", @"prolog\bin");
            string[] p = { "-q", "-f", @"nba.pl" };
            PlEngine.Initialize(p);
            PlQuery postojiDatoteka = new PlQuery("postojiDatoteka");
            postojiDatoteka.NextSolution();
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            PlQuery nba = new PlQuery("igrac(E,C)");
            nba.Variables["E"].Unify(txtIgrac.Text.ToLower());
            if (nba.NextSolution() == true)
            {
                MessageBox.Show("Igrač " + txtIgrac.Text + " igra za klub " + nba.Variables["C"].ToString().ToUpper());
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
                    txtKlub.Visible = true;
                    btnDodajIgraca.Visible = true;
                    lblPomoc.Text = "Klub za koji igra igrač " + txtIgrac.Text + " je";
                    txtKlub.Focus();
                }
                else
                    MessageBox.Show("Igrač dodan!");
            }
        }

        private void FormNBA_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlQuery q = new PlQuery("zatvoriDatoteku");
            q.NextSolution();
            PlEngine.PlCleanup();
        }

        private void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            PlQuery add = new PlQuery("dodajIgraca(E, C)");
            add.Variables["E"].Unify(txtIgrac.Text.ToLower());
            add.Variables["C"].Unify(txtKlub.Text.ToLower());
            add.NextSolution();
            txtKlub.Visible = false;
            btnDodajIgraca.Visible = false;
            lblKlub.Visible = false;
            MessageBox.Show("Igrač uspješno dodan");
        }
    }
    }

