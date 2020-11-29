
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
            this.lblzłoto = new System.Windows.Forms.Label();
            this.lbldoświadczenie = new System.Windows.Forms.Label();
            this.lblpoziom = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pkt.Życia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "złoto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pkt.Doświadczenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poziom";
            // 
            // lblżycie
            // 
            this.lblżycie.AutoSize = true;
            this.lblżycie.Location = new System.Drawing.Point(110, 19);
            this.lblżycie.Name = "lblżycie";
            this.lblżycie.Size = new System.Drawing.Size(0, 20);
            this.lblżycie.TabIndex = 4;
            // 
            // lblzłoto
            // 
            this.lblzłoto.AutoSize = true;
            this.lblzłoto.Location = new System.Drawing.Point(110, 45);
            this.lblzłoto.Name = "lblzłoto";
            this.lblzłoto.Size = new System.Drawing.Size(0, 20);
            this.lblzłoto.TabIndex = 5;
            // 
            // lbldoświadczenie
            // 
            this.lbldoświadczenie.AutoSize = true;
            this.lbldoświadczenie.Location = new System.Drawing.Point(165, 75);
            this.lbldoświadczenie.Name = "lbldoświadczenie";
            this.lbldoświadczenie.Size = new System.Drawing.Size(0, 20);
            this.lbldoświadczenie.TabIndex = 6;
            // 
            // lblpoziom
            // 
            this.lblpoziom.AutoSize = true;
            this.lblpoziom.Location = new System.Drawing.Point(110, 99);
            this.lblpoziom.Name = "lblpoziom";
            this.lblpoziom.Size = new System.Drawing.Size(0, 20);
            this.lblpoziom.TabIndex = 7;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(575, 160);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(81, 33);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Przygoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 634);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblpoziom);
            this.Controls.Add(this.lbldoświadczenie);
            this.Controls.Add(this.lblzłoto);
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
        private System.Windows.Forms.Label lblzłoto;
        private System.Windows.Forms.Label lbldoświadczenie;
        private System.Windows.Forms.Label lblpoziom;
        private System.Windows.Forms.Button btnTest;
    }
}

