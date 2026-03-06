namespace Treca_zadaca
{
    partial class FrmIzvjestajKonfiguracije
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
            this.cboKonfiguracije = new System.Windows.Forms.ComboBox();
            this.btnGenerirajIzvjestaj = new System.Windows.Forms.Button();
            this.txtIzvjestaj = new System.Windows.Forms.TextBox();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboKonfiguracije
            // 
            this.cboKonfiguracije.FormattingEnabled = true;
            this.cboKonfiguracije.Location = new System.Drawing.Point(244, 34);
            this.cboKonfiguracije.Name = "cboKonfiguracije";
            this.cboKonfiguracije.Size = new System.Drawing.Size(291, 24);
            this.cboKonfiguracije.TabIndex = 0;
            // 
            // btnGenerirajIzvjestaj
            // 
            this.btnGenerirajIzvjestaj.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGenerirajIzvjestaj.Location = new System.Drawing.Point(344, 69);
            this.btnGenerirajIzvjestaj.Name = "btnGenerirajIzvjestaj";
            this.btnGenerirajIzvjestaj.Size = new System.Drawing.Size(190, 44);
            this.btnGenerirajIzvjestaj.TabIndex = 1;
            this.btnGenerirajIzvjestaj.Text = "Generiraj Izvještaj";
            this.btnGenerirajIzvjestaj.UseVisualStyleBackColor = false;
            this.btnGenerirajIzvjestaj.Click += new System.EventHandler(this.btnGenerirajIzvjestaj_Click);
            // 
            // txtIzvjestaj
            // 
            this.txtIzvjestaj.BackColor = System.Drawing.Color.Lavender;
            this.txtIzvjestaj.Location = new System.Drawing.Point(11, 130);
            this.txtIzvjestaj.Multiline = true;
            this.txtIzvjestaj.Name = "txtIzvjestaj";
            this.txtIzvjestaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIzvjestaj.Size = new System.Drawing.Size(777, 309);
            this.txtIzvjestaj.TabIndex = 2;
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Red;
            this.btnPovratak.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPovratak.ForeColor = System.Drawing.Color.White;
            this.btnPovratak.Location = new System.Drawing.Point(29, 69);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(173, 44);
            this.btnPovratak.TabIndex = 3;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // FrmIzvjestajKonfiguracije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.txtIzvjestaj);
            this.Controls.Add(this.btnGenerirajIzvjestaj);
            this.Controls.Add(this.cboKonfiguracije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIzvjestajKonfiguracije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generiranje izvještaja";
            this.Load += new System.EventHandler(this.FrmIzvjestajKonfiguracije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKonfiguracije;
        private System.Windows.Forms.Button btnGenerirajIzvjestaj;
        private System.Windows.Forms.TextBox txtIzvjestaj;
        private System.Windows.Forms.Button btnPovratak;
    }
}