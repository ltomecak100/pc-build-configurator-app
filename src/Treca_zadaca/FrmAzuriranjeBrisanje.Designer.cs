namespace Treca_zadaca
{
    partial class FrmAzuriranjeBrisanje
    {
     
        private System.ComponentModel.IContainer components = null;

       
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
            this.dgvKomponente = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnAzuriranje = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.txtProizvodac = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtIdZaposlenika = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKomponente
            // 
            this.dgvKomponente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvKomponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomponente.Location = new System.Drawing.Point(3, 2);
            this.dgvKomponente.Name = "dgvKomponente";
            this.dgvKomponente.RowHeadersWidth = 51;
            this.dgvKomponente.RowTemplate.Height = 24;
            this.dgvKomponente.Size = new System.Drawing.Size(1054, 348);
            this.dgvKomponente.TabIndex = 0;
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Red;
            this.btnPovratak.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPovratak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPovratak.Location = new System.Drawing.Point(12, 370);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(140, 54);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnAzuriranje
            // 
            this.btnAzuriranje.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAzuriranje.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriranje.Location = new System.Drawing.Point(749, 370);
            this.btnAzuriranje.Name = "btnAzuriranje";
            this.btnAzuriranje.Size = new System.Drawing.Size(140, 54);
            this.btnAzuriranje.TabIndex = 2;
            this.btnAzuriranje.Text = "Ažuriranje";
            this.btnAzuriranje.UseVisualStyleBackColor = false;
            this.btnAzuriranje.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBrisanje.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisanje.Location = new System.Drawing.Point(749, 491);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(140, 54);
            this.btnBrisanje.TabIndex = 3;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(407, 370);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(41, 16);
            this.lblNaziv.TabIndex = 4;
            this.lblNaziv.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proizvodac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cijena (€)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Zaposlenika";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(463, 423);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(210, 22);
            this.txtTip.TabIndex = 9;
            // 
            // txtProizvodac
            // 
            this.txtProizvodac.Location = new System.Drawing.Point(463, 475);
            this.txtProizvodac.Name = "txtProizvodac";
            this.txtProizvodac.Size = new System.Drawing.Size(210, 22);
            this.txtProizvodac.TabIndex = 10;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(463, 529);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(210, 22);
            this.txtCijena.TabIndex = 11;
            // 
            // txtIdZaposlenika
            // 
            this.txtIdZaposlenika.Location = new System.Drawing.Point(463, 582);
            this.txtIdZaposlenika.Name = "txtIdZaposlenika";
            this.txtIdZaposlenika.Size = new System.Drawing.Size(210, 22);
            this.txtIdZaposlenika.TabIndex = 12;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(463, 370);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(210, 22);
            this.txtNaziv.TabIndex = 13;
            // 
            // FrmAzuriranjeBrisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtIdZaposlenika);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtProizvodac);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnAzuriranje);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvKomponente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAzuriranjeBrisanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriranje i brisanje komponenti";
            this.Load += new System.EventHandler(this.FrmAzuriranjeBrisanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKomponente;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnAzuriranje;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.TextBox txtProizvodac;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtIdZaposlenika;
        private System.Windows.Forms.TextBox txtNaziv;
    }
}