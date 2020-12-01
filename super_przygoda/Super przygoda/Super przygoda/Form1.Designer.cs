
namespace Super_przygoda
{
    partial class Przygoda
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblżycie = new System.Windows.Forms.Label();
            this.lblplatinium = new System.Windows.Forms.Label();
            this.lbldoświadczenie = new System.Windows.Forms.Label();
            this.lblpoziom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblbaterie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pkt.Konstrukcyjne";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Platinium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pkt.Doświadczenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poziom";
            // 
            // lblżycie
            // 
            this.lblżycie.AutoSize = true;
            this.lblżycie.Location = new System.Drawing.Point(161, 20);
            this.lblżycie.Name = "lblżycie";
            this.lblżycie.Size = new System.Drawing.Size(0, 20);
            this.lblżycie.TabIndex = 4;
            // 
            // lblplatinium
            // 
            this.lblplatinium.AutoSize = true;
            this.lblplatinium.Location = new System.Drawing.Point(110, 60);
            this.lblplatinium.Name = "lblplatinium";
            this.lblplatinium.Size = new System.Drawing.Size(0, 20);
            this.lblplatinium.TabIndex = 5;
            // 
            // lbldoświadczenie
            // 
            this.lbldoświadczenie.AutoSize = true;
            this.lbldoświadczenie.Location = new System.Drawing.Point(167, 89);
            this.lbldoświadczenie.Name = "lbldoświadczenie";
            this.lbldoświadczenie.Size = new System.Drawing.Size(0, 20);
            this.lbldoświadczenie.TabIndex = 6;
            // 
            // lblpoziom
            // 
            this.lblpoziom.AutoSize = true;
            this.lblpoziom.Location = new System.Drawing.Point(110, 114);
            this.lblpoziom.Name = "lblpoziom";
            this.lblpoziom.Size = new System.Drawing.Size(0, 20);
            this.lblpoziom.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Baterie";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lblbaterie
            // 
            this.lblbaterie.AutoSize = true;
            this.lblbaterie.Location = new System.Drawing.Point(91, 41);
            this.lblbaterie.Name = "lblbaterie";
            this.lblbaterie.Size = new System.Drawing.Size(0, 20);
            this.lblbaterie.TabIndex = 10;
            // 
            // Przygoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 634);
            this.Controls.Add(this.lblbaterie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblpoziom);
            this.Controls.Add(this.lbldoświadczenie);
            this.Controls.Add(this.lblplatinium);
            this.Controls.Add(this.lblżycie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Przygoda";
            this.Text = "Moja gra";
            this.Load += new System.EventHandler(this.Przygoda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblżycie;
        private System.Windows.Forms.Label lblplatinium;
        private System.Windows.Forms.Label lbldoświadczenie;
        private System.Windows.Forms.Label lblpoziom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblbaterie;
    }
}

