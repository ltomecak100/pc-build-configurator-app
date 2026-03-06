using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treca_zadaca
{
    public partial class Pocetak : Form
    {
        public static Pocetak Instance { get; private set; }
        public Pocetak()
        {
            InitializeComponent();
            Instance = this;
            FrmUvod uvodForma = new FrmUvod();
            uvodForma.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnZaposlenik_Click(object sender, EventArgs e)
        {
            FrmKomponente frmKomponente = new FrmKomponente(this);
            Hide();
            frmKomponente.ShowDialog();
            Show();
        }

        private void btnKupac_Click(object sender, EventArgs e)
        {
            FrmIzvjestajKonfiguracije frmIzvjestajKonfiguracije = new FrmIzvjestajKonfiguracije();
            Hide();
            frmIzvjestajKonfiguracije.ShowDialog();
            Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
