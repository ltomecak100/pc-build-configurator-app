namespace Treca_zadaca
{
    partial class FrmKomponente
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
            this.dgvKomponente = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnAzuriranjeBrisanje = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnPretrazivanje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.txtProizvodac = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtIdZaposlenika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKomponente
            // 
            this.dgvKomponente.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvKomponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomponente.Location = new System.Drawing.Point(13, 12);
            this.dgvKomponente.Name = "dgvKomponente";
            this.dgvKomponente.RowHeadersWidth = 51;
            this.dgvKomponente.RowTemplate.Height = 24;
            this.dgvKomponente.Size = new System.Drawing.Size(1038, 359);
            this.dgvKomponente.TabIndex = 2;
            this.dgvKomponente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomponente_CellContentClick);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Red;
            this.btnPovratak.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPovratak.ForeColor = System.Drawing.Color.White;
            this.btnPovratak.Location = new System.Drawing.Point(71, 526);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(150, 54);
            this.btnPovratak.TabIndex = 3;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnAzuriranjeBrisanje
            // 
            this.btnAzuriranjeBrisanje.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAzuriranjeBrisanje.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriranjeBrisanje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAzuriranjeBrisanje.Location = new System.Drawing.Point(71, 418);
            this.btnAzuriranjeBrisanje.Name = "btnAzuriranjeBrisanje";
            this.btnAzuriranjeBrisanje.Size = new System.Drawing.Size(175, 54);
            this.btnAzuriranjeBrisanje.TabIndex = 4;
            this.btnAzuriranjeBrisanje.Text = "Ažuriranje i brisanje";
            this.btnAzuriranjeBrisanje.UseVisualStyleBackColor = false;
            this.btnAzuriranjeBrisanje.Click += new System.EventHandler(this.btnAzuriranjeBrisanje_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUnos.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnos.Location = new System.Drawing.Point(764, 532);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(150, 54);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = false;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnPretrazivanje
            // 
            this.btnPretrazivanje.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPretrazivanje.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazivanje.Location = new System.Drawing.Point(764, 418);
            this.btnPretrazivanje.Name = "btnPretrazivanje";
            this.btnPretrazivanje.Size = new System.Drawing.Size(150, 54);
            this.btnPretrazivanje.TabIndex = 6;
            this.btnPretrazivanje.Text = "Pretraživanje";
            this.btnPretrazivanje.UseVisualStyleBackColor = false;
            this.btnPretrazivanje.Click += new System.EventHandler(this.btnPretrazivanje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(439, 420);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(232, 22);
            this.txtNaziv.TabIndex = 8;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(441, 456);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(229, 22);
            this.txtTip.TabIndex = 9;
            // 
            // txtProizvodac
            // 
            this.txtProizvodac.Location = new System.Drawing.Point(441, 490);
            this.txtProizvodac.Name = "txtProizvodac";
            this.txtProizvodac.Size = new System.Drawing.Size(228, 22);
            this.txtProizvodac.TabIndex = 10;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(439, 526);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(229, 22);
            this.txtCijena.TabIndex = 11;
            // 
            // txtIdZaposlenika
            // 
            this.txtIdZaposlenika.Location = new System.Drawing.Point(439, 561);
            this.txtIdZaposlenika.Name = "txtIdZaposlenika";
            this.txtIdZaposlenika.Size = new System.Drawing.Size(229, 22);
            this.txtIdZaposlenika.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Proizvodac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cijena (€)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID Zaposlenika";
            // 
            // FrmKomponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdZaposlenika);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtProizvodac);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretrazivanje);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnAzuriranjeBrisanje);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvKomponente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKomponente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dohvat, unos i pretraživanje komponenti";
            this.Load += new System.EventHandler(this.FrmKomponente_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKomponente;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnAzuriranjeBrisanje;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnPretrazivanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.TextBox txtProizvodac;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtIdZaposlenika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}