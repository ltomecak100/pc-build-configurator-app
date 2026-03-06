namespace Treca_zadaca
{
    partial class FrmUvod
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.picNaslovna = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNaslovna)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli u ConnectIT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNastavi
            // 
            this.btnNastavi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNastavi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNastavi.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNastavi.Location = new System.Drawing.Point(0, 390);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(800, 60);
            this.btnNastavi.TabIndex = 1;
            this.btnNastavi.Text = "Nastavi";
            this.btnNastavi.UseVisualStyleBackColor = false;
            this.btnNastavi.Click += new System.EventHandler(this.btnNastavi_Click);
            // 
            // picNaslovna
            // 
            this.picNaslovna.Image = global::Treca_zadaca.Properties.Resources.Trgovina_informatičke_opreme_slika;
            this.picNaslovna.Location = new System.Drawing.Point(197, 112);
            this.picNaslovna.Name = "picNaslovna";
            this.picNaslovna.Size = new System.Drawing.Size(377, 254);
            this.picNaslovna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNaslovna.TabIndex = 2;
            this.picNaslovna.TabStop = false;
            this.picNaslovna.Click += new System.EventHandler(this.picNaslovna_Click);
            // 
            // FrmUvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picNaslovna);
            this.Controls.Add(this.btnNastavi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectIT";
            this.Load += new System.EventHandler(this.FrmUvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNaslovna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNastavi;
        private System.Windows.Forms.PictureBox picNaslovna;
    }
}