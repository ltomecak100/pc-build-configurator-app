namespace Treca_zadaca
{
    partial class Pocetak
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
            this.btnZaposlenik = new System.Windows.Forms.Button();
            this.btnKupac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZaposlenik
            // 
            this.btnZaposlenik.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnZaposlenik.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposlenik.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnZaposlenik.Location = new System.Drawing.Point(61, 246);
            this.btnZaposlenik.Name = "btnZaposlenik";
            this.btnZaposlenik.Size = new System.Drawing.Size(313, 205);
            this.btnZaposlenik.TabIndex = 0;
            this.btnZaposlenik.Text = "Zaposlenik";
            this.btnZaposlenik.UseVisualStyleBackColor = false;
            this.btnZaposlenik.Click += new System.EventHandler(this.btnZaposlenik_Click);
            // 
            // btnKupac
            // 
            this.btnKupac.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKupac.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.btnKupac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKupac.Location = new System.Drawing.Point(395, 246);
            this.btnKupac.Name = "btnKupac";
            this.btnKupac.Size = new System.Drawing.Size(313, 205);
            this.btnKupac.TabIndex = 2;
            this.btnKupac.Text = "Kupac";
            this.btnKupac.UseVisualStyleBackColor = false;
            this.btnKupac.Click += new System.EventHandler(this.btnKupac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "ODABERI ZAPOSLENIKA ILI KUPCA ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pocetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKupac);
            this.Controls.Add(this.btnZaposlenik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pocetak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir uloga";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btnKupac_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZaposlenik;
        private System.Windows.Forms.Button btnKupac;
        private System.Windows.Forms.Label label1;
    }
}

