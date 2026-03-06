using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Treca_zadaca
{
    public partial class FrmIzvjestajKonfiguracije : Form
    {
        public FrmIzvjestajKonfiguracije()
        {
            InitializeComponent();

            try
            {
                string putanjaDatoteke = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Konfiguracije.txt");
                if (!File.Exists(putanjaDatoteke))
                {
                    MessageBox.Show("Datoteka Konfiguracije.txt nije pronađena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboKonfiguracije.Enabled = false;
                    btnGenerirajIzvjestaj.Enabled = false;
                    return;
                }

                string[] linije = File.ReadAllLines(putanjaDatoteke);
                List<string> konfiguracije = new List<string>();

                foreach (string linija in linije)
                {
                    string obradjenaLinija = linija.Trim();
                    if (string.IsNullOrWhiteSpace(obradjenaLinija) || obradjenaLinija.Contains("------") || obradjenaLinija.Contains("Ukupna cijena"))
                    {
                        continue;
                    }

                    if (!obradjenaLinija.Contains(","))
                    {
                        konfiguracije.Add(obradjenaLinija);
                    }
                }

                if (konfiguracije.Count > 0)
                {
                    cboKonfiguracije.DataSource = konfiguracije;
                }
                else
                {
                    MessageBox.Show("Nema dostupnih konfiguracija u datoteci!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboKonfiguracije.Enabled = false;
                    btnGenerirajIzvjestaj.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom čitanja datoteke: {ex.Message}", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboKonfiguracije.Enabled = false;
                btnGenerirajIzvjestaj.Enabled = false;
            }
        }

        private void btnGenerirajIzvjestaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboKonfiguracije.SelectedItem == null)
                {
                    MessageBox.Show("Odaberite konfiguraciju!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string odabranaKonfiguracija = cboKonfiguracije.SelectedItem.ToString();
                string putanjaDatoteke = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Konfiguracije.txt");
                string[] linije = File.ReadAllLines(putanjaDatoteke);

                List<string> komponente = new List<string>();
                float ukupnaCijena = 0;
                bool pronadjenaKonfiguracija = false;

                for (int i = 0; i < linije.Length; i++)
                {
                    string linija = linije[i].Trim();

                    if (linija == odabranaKonfiguracija)
                    {
                        pronadjenaKonfiguracija = true;
                        continue;
                    }

                    if (pronadjenaKonfiguracija)
                    {
                        if (string.IsNullOrWhiteSpace(linija) || linija.Contains("------") || linija.Contains("Ukupna cijena"))
                        {
                            break;
                        }

                        string[] dijelovi = linija.Split(',');
                        if (dijelovi.Length == 4 && float.TryParse(dijelovi[3], out float cijena))
                        {
                            komponente.Add(linija);
                            ukupnaCijena += cijena;
                        }
                    }
                }

                if (!pronadjenaKonfiguracija || komponente.Count == 0)
                {
                    MessageBox.Show("Odabrana konfiguracija nema komponenti!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIzvjestaj.Text = "";
                    return;
                }

                string izvjestaj = $"Izvještaj za {odabranaKonfiguracija}\r\n";
                izvjestaj += "------------------------------------------------------\r\n";
                foreach (string komponenta in komponente)
                {
                    string[] dijelovi = komponenta.Split(',');
                    izvjestaj += $"{dijelovi[0]} ({dijelovi[1]}, {dijelovi[2]}) - {dijelovi[3]} €\r\n";
                }
                izvjestaj += "------------------------------------------------------\r\n";
                izvjestaj += $"Ukupna cijena: {ukupnaCijena:F2} €\r\n";

                txtIzvjestaj.Text = izvjestaj;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom generiranja izvještaja: {ex.Message}", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIzvjestaj.Text = "";
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIzvjestajKonfiguracije_Load(object sender, EventArgs e)
        {

        }
    }
}