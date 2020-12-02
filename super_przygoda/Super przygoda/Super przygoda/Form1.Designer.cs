
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
            this.label6 = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.cboSunSails = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnPrawo = new System.Windows.Forms.Button();
            this.btenLewo = new System.Windows.Forms.Button();
            this.btnProsto = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.btnUseSunSails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 653);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wybierz Akcję";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(322, 676);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 28);
            this.cboWeapons.TabIndex = 12;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(449, 676);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 28);
            this.cboPotions.TabIndex = 13;
            // 
            // cboSunSails
            // 
            this.cboSunSails.FormattingEnabled = true;
            this.cboSunSails.Location = new System.Drawing.Point(576, 676);
            this.cboSunSails.Name = "cboSunSails";
            this.cboSunSails.Size = new System.Drawing.Size(121, 28);
            this.cboSunSails.TabIndex = 14;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(347, 710);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 35);
            this.btnUseWeapon.TabIndex = 15;
            this.btnUseWeapon.Text = "Użyj";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(478, 710);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 35);
            this.btnUsePotion.TabIndex = 16;
            this.btnUsePotion.Text = "Użyj";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            // 
            // btnPrawo
            // 
            this.btnPrawo.Location = new System.Drawing.Point(564, 513);
            this.btnPrawo.Name = "btnPrawo";
            this.btnPrawo.Size = new System.Drawing.Size(121, 36);
            this.btnPrawo.TabIndex = 17;
            this.btnPrawo.Text = "Leć w Prawo";
            this.btnPrawo.UseVisualStyleBackColor = true;
            this.btnPrawo.Click += new System.EventHandler(this.btnPrawo_Click);
            // 
            // btenLewo
            // 
            this.btenLewo.Location = new System.Drawing.Point(354, 513);
            this.btenLewo.Name = "btenLewo";
            this.btenLewo.Size = new System.Drawing.Size(118, 36);
            this.btenLewo.TabIndex = 18;
            this.btenLewo.Text = "Leć w Lewo";
            this.btenLewo.UseVisualStyleBackColor = true;
            this.btenLewo.Click += new System.EventHandler(this.btenLewo_Click);
            // 
            // btnProsto
            // 
            this.btnProsto.Location = new System.Drawing.Point(461, 471);
            this.btnProsto.Name = "btnProsto";
            this.btnProsto.Size = new System.Drawing.Size(118, 36);
            this.btnProsto.TabIndex = 19;
            this.btnProsto.Text = "Leć Prosto";
            this.btnProsto.UseVisualStyleBackColor = true;
            this.btnProsto.Click += new System.EventHandler(this.btnProsto_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(461, 555);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 36);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Zawróć";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnback_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(347, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 105);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(347, 147);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(360, 286);
            this.richTextBox2.TabIndex = 22;
            this.richTextBox2.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(12, 147);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventory.RowTemplate.Height = 28;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 23;
            this.dgvInventory.Visible = false;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToOrderColumns = true;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(12, 462);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersWidth = 62;
            this.dgvQuests.RowTemplate.Height = 28;
            this.dgvQuests.Size = new System.Drawing.Size(312, 185);
            this.dgvQuests.TabIndex = 24;
            this.dgvQuests.Visible = false;
            // 
            // btnUseSunSails
            // 
            this.btnUseSunSails.Location = new System.Drawing.Point(612, 710);
            this.btnUseSunSails.Name = "btnUseSunSails";
            this.btnUseSunSails.Size = new System.Drawing.Size(75, 23);
            this.btnUseSunSails.TabIndex = 25;
            this.btnUseSunSails.Text = "Użyj";
            this.btnUseSunSails.UseVisualStyleBackColor = true;
            // 
            // Przygoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 750);
            this.Controls.Add(this.btnUseSunSails);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProsto);
            this.Controls.Add(this.btenLewo);
            this.Controls.Add(this.btnPrawo);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboSunSails);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.label6);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.ComboBox cboSunSails;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnPrawo;
        private System.Windows.Forms.Button btenLewo;
        private System.Windows.Forms.Button btnProsto;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.Button btnUseSunSails;
    }
}

