namespace OknoTestowe
{
    partial class OknoTestowe
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
            this.suwak1 = new Suwak.Suwak();
            ((System.ComponentModel.ISupportInitialize)(this.suwak1)).BeginInit();
            this.SuspendLayout();
            // 
            // suwak1
            // 
            this.suwak1.BackColor = System.Drawing.SystemColors.Control;
            this.suwak1.Kolor = Suwak.Kolory.Domyslny;
            this.suwak1.Location = new System.Drawing.Point(319, 62);
            this.suwak1.Name = "suwak1";
            this.suwak1.Polozenie = Suwak.Orientacja.Pozioma;
            this.suwak1.Size = new System.Drawing.Size(100, 45);
            this.suwak1.Szerokosc = 100;
            this.suwak1.TabIndex = 0;
            this.suwak1.Value = 5;
            this.suwak1.Wartosc = 5;
            this.suwak1.Wysokosc = 200;
            // 
            // OknoTestowe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.suwak1);
            this.Name = "OknoTestowe";
            this.Text = "OknoTestowe";
            ((System.ComponentModel.ISupportInitialize)(this.suwak1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Suwak.Suwak suwak1;
    }
}