using System;
using System.Linq;
using System.Windows.Forms;
using Treca_zadaca.Models;

namespace Treca_zadaca
{
    public partial class FrmKomponente : Form
    {
        private Pocetak _pocetak;

        public FrmKomponente(Pocetak pocetak = null)
        {
            InitializeComponent();
            _pocetak = pocetak;
            UcitajKomponente();
        }

        private void UcitajKomponente()
        {
            try
            {
                var komponente = Treca_zadaca.Repositories.KomponentaRepository.GetComponents();
                dgvKomponente.DataSource = komponente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška je nastala kod učitavanja komponenti: {ex}", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmKomponente_Load(object sender, EventArgs e)
        {
        }

        private void dgvKomponente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            if (Pocetak.Instance != null && !Pocetak.Instance.IsDisposed)
            {
                Pocetak.Instance.Show();
            }
            else
            {
                Pocetak pocetak = new Pocetak();
                pocetak.Show();
            }
            this.Close();
        }



        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNaziv.Text))
                {
                    MessageBox.Show("Naziv komponente je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTip.Text))
                {
                    MessageBox.Show("Tip komponente je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtProizvodac.Text))
                {
                    MessageBox.Show("Proizvođač je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                float cijena;
                if (string.IsNullOrWhiteSpace(txtCijena.Text) || !float.TryParse(txtCijena.Text, out cijena))
                {
                    MessageBox.Show("Cijena je obavezna i mora biti pozitivan broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idZaposlenika;
                if (string.IsNullOrWhiteSpace(txtIdZaposlenika.Text) || !int.TryParse(txtIdZaposlenika.Text, out idZaposlenika))
                {
                    MessageBox.Show("ID Zaposlenika je obavezan i mora biti prirodan broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var novaKomponenta = new Komponenta
                {
                    Naziv = txtNaziv.Text,
                    Tip = txtTip.Text,
                    Proizvodac = txtProizvodac.Text,
                    Cijena = cijena,
                    IdZaposlenika = idZaposlenika
                };

                Treca_zadaca.Repositories.KomponentaRepository.AddComponent(novaKomponenta);

                UcitajKomponente();
                txtNaziv.Text = "";
                txtTip.Text = "";
                txtProizvodac.Text = "";
                txtCijena.Text = "";
                txtIdZaposlenika.Text = "";

                MessageBox.Show("Komponenta je uspješno dodana!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška je nastala prilikom unosa komponente: {ex.Message}", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPretrazivanje_Click(object sender, EventArgs e)
        {
            try
            {
                var komponente = Treca_zadaca.Repositories.KomponentaRepository.GetComponents();

              
                string nazivZaPretragu = txtNaziv.Text.Trim().ToLower();
                string tipZaPretragu = txtTip.Text.Trim().ToLower();
                string proizvodacZaPretragu = txtProizvodac.Text.Trim().ToLower();
                string cijenaZaPretragu = txtCijena.Text.Trim();
                string idZaposlenikaZaPretragu = txtIdZaposlenika.Text.Trim();

                
                if (!string.IsNullOrEmpty(nazivZaPretragu))
                {
                    komponente = komponente.Where(k => k.Naziv.ToLower().Contains(nazivZaPretragu)).ToList();
                }
                if (!string.IsNullOrEmpty(tipZaPretragu))
                {
                    komponente = komponente.Where(k => k.Tip.ToLower().Contains(tipZaPretragu)).ToList();
                }
                if (!string.IsNullOrEmpty(proizvodacZaPretragu))
                {
                    komponente = komponente.Where(k => k.Proizvodac.ToLower().Contains(proizvodacZaPretragu)).ToList();
                }
                if (!string.IsNullOrEmpty(cijenaZaPretragu))
                {
                   
                    if (float.TryParse(cijenaZaPretragu, out float cijena))
                    {
                        komponente = komponente.Where(k => k.Cijena == cijena).ToList();
                    }
                }
                if (!string.IsNullOrEmpty(idZaposlenikaZaPretragu))
                {
                    
                    if (int.TryParse(idZaposlenikaZaPretragu, out int idZaposlenika))
                    {
                        komponente = komponente.Where(k => k.IdZaposlenika == idZaposlenika).ToList();
                    }
                }

                dgvKomponente.DataSource = komponente;

                if (komponente.Count == 0)
                {
                    MessageBox.Show("Nema komponenti koje odgovaraju pretrazi!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom pretraživanja komponenti: {ex.Message}", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmKomponente_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAzuriranjeBrisanje_Click(object sender, EventArgs e)
        {
            FrmAzuriranjeBrisanje frm = new FrmAzuriranjeBrisanje();
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}