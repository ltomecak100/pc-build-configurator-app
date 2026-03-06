using System;
using System.Windows.Forms;
using Treca_zadaca.Models;
using Treca_zadaca.Repositories;

namespace Treca_zadaca
{
    public partial class FrmAzuriranjeBrisanje : Form
    {
        public FrmAzuriranjeBrisanje()
        {
            InitializeComponent();
            UcitajKomponente();
            dgvKomponente.SelectionChanged += DgvKomponente_SelectionChanged;
        }

        private void UcitajKomponente()
        {
            try
            {
                var komponente = KomponentaRepository.GetComponents();
                dgvKomponente.DataSource = komponente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja komponenti: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvKomponente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKomponente.SelectedRows.Count > 0)
            {
                var odabranaKomponenta = (Komponenta)dgvKomponente.SelectedRows[0].DataBoundItem;
                txtNaziv.Text = odabranaKomponenta.Naziv;
                txtTip.Text = odabranaKomponenta.Tip;
                txtProizvodac.Text = odabranaKomponenta.Proizvodac;
                txtCijena.Text = odabranaKomponenta.Cijena.ToString();
                txtIdZaposlenika.Text = odabranaKomponenta.IdZaposlenika.ToString();
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKomponente.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Odaberite komponentu za ažuriranje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNaziv.Text) || string.IsNullOrWhiteSpace(txtTip.Text) ||
                    string.IsNullOrWhiteSpace(txtProizvodac.Text) || !float.TryParse(txtCijena.Text, out float cijena) ||
                    !int.TryParse(txtIdZaposlenika.Text, out int idZaposlenika))
                {
                    MessageBox.Show("Sva polja moraju biti ispravno popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var odabranaKomponenta = (Komponenta)dgvKomponente.SelectedRows[0].DataBoundItem;
                odabranaKomponenta.Naziv = txtNaziv.Text;
                odabranaKomponenta.Tip = txtTip.Text;
                odabranaKomponenta.Proizvodac = txtProizvodac.Text;
                odabranaKomponenta.Cijena = cijena;
                odabranaKomponenta.IdZaposlenika = idZaposlenika;

                KomponentaRepository.UpdateComponent(odabranaKomponenta);
                MessageBox.Show("Komponenta uspješno ažurirana!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UcitajKomponente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom ažuriranja: {ex.Message}", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAzuriranjeBrisanje_Load(object sender, EventArgs e)
        {

        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKomponente.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Odaberite komponentu za brisanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var odabranaKomponenta = (Komponenta)dgvKomponente.SelectedRows[0].DataBoundItem;
                var rezultat = MessageBox.Show($"Jeste li sigurni da želite obrisati komponentu '{odabranaKomponenta.Naziv}'?",
                    "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezultat == DialogResult.Yes)
                {
                    KomponentaRepository.DeleteComponent(odabranaKomponenta.IdKomponente);
                    MessageBox.Show("Komponenta uspješno obrisana!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UcitajKomponente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja: {ex.Message}", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

