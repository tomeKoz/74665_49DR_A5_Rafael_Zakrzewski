
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
            this.components = new System.ComponentModel.Container();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblżycie = new System.Windows.Forms.Label();
            this.lblplatinium = new System.Windows.Forms.Label();
            this.lbldoświadczenie = new System.Windows.Forms.Label();
            this.lblpoziom = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblbaterie = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboRepairKits = new System.Windows.Forms.ComboBox();
            this.cboSunSails = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUseRepairKit = new System.Windows.Forms.Button();
            this.btnPrawo = new System.Windows.Forms.Button();
            this.btnLewo = new System.Windows.Forms.Button();
            this.btnProsto = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.btnUseSunSails = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.worldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(12, 13);
            this.lblHitPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(93, 13);
            this.lblHitPoints.TabIndex = 0;
            this.lblHitPoints.Text = "Pkt.Konstrukcyjne";
            this.lblHitPoints.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Platinium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pkt.Doświadczenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poziom";
            // 
            // lblżycie
            // 
            this.lblżycie.AutoSize = true;
            this.lblżycie.Location = new System.Drawing.Point(107, 13);
            this.lblżycie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblżycie.Name = "lblżycie";
            this.lblżycie.Size = new System.Drawing.Size(0, 13);
            this.lblżycie.TabIndex = 4;
            // 
            // lblplatinium
            // 
            this.lblplatinium.AutoSize = true;
            this.lblplatinium.Location = new System.Drawing.Point(73, 39);
            this.lblplatinium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblplatinium.Name = "lblplatinium";
            this.lblplatinium.Size = new System.Drawing.Size(0, 13);
            this.lblplatinium.TabIndex = 5;
            // 
            // lbldoświadczenie
            // 
            this.lbldoświadczenie.AutoSize = true;
            this.lbldoświadczenie.Location = new System.Drawing.Point(111, 58);
            this.lbldoświadczenie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldoświadczenie.Name = "lbldoświadczenie";
            this.lbldoświadczenie.Size = new System.Drawing.Size(0, 13);
            this.lbldoświadczenie.TabIndex = 6;
            // 
            // lblpoziom
            // 
            this.lblpoziom.AutoSize = true;
            this.lblpoziom.Location = new System.Drawing.Point(73, 74);
            this.lblpoziom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpoziom.Name = "lblpoziom";
            this.lblpoziom.Size = new System.Drawing.Size(0, 13);
            this.lblpoziom.TabIndex = 7;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 26);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Baterie";
            this.lbl1.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lblbaterie
            // 
            this.lblbaterie.AutoSize = true;
            this.lblbaterie.Location = new System.Drawing.Point(61, 27);
            this.lblbaterie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbaterie.Name = "lblbaterie";
            this.lblbaterie.Size = new System.Drawing.Size(0, 13);
            this.lblbaterie.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 424);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wybierz Akcję";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(195, 439);
            this.cboWeapons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(114, 21);
            this.cboWeapons.TabIndex = 12;
            // 
            // cboRepairKits
            // 
            this.cboRepairKits.FormattingEnabled = true;
            this.cboRepairKits.Location = new System.Drawing.Point(311, 439);
            this.cboRepairKits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboRepairKits.Name = "cboRepairKits";
            this.cboRepairKits.Size = new System.Drawing.Size(114, 21);
            this.cboRepairKits.TabIndex = 13;
            // 
            // cboSunSails
            // 
            this.cboSunSails.FormattingEnabled = true;
            this.cboSunSails.Location = new System.Drawing.Point(428, 439);
            this.cboSunSails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSunSails.Name = "cboSunSails";
            this.cboSunSails.Size = new System.Drawing.Size(114, 21);
            this.cboSunSails.TabIndex = 14;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(224, 461);
            this.btnUseWeapon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(50, 23);
            this.btnUseWeapon.TabIndex = 15;
            this.btnUseWeapon.Text = "Użyj";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUseRepairKit
            // 
            this.btnUseRepairKit.Location = new System.Drawing.Point(345, 461);
            this.btnUseRepairKit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUseRepairKit.Name = "btnUseRepairKit";
            this.btnUseRepairKit.Size = new System.Drawing.Size(50, 23);
            this.btnUseRepairKit.TabIndex = 16;
            this.btnUseRepairKit.Text = "Użyj";
            this.btnUseRepairKit.UseVisualStyleBackColor = true;
            this.btnUseRepairKit.Click += new System.EventHandler(this.btnUseRepairKit_Click);
            // 
            // btnPrawo
            // 
            this.btnPrawo.Location = new System.Drawing.Point(460, 360);
            this.btnPrawo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrawo.Name = "btnPrawo";
            this.btnPrawo.Size = new System.Drawing.Size(81, 23);
            this.btnPrawo.TabIndex = 17;
            this.btnPrawo.Text = "Leć w Prawo";
            this.btnPrawo.UseVisualStyleBackColor = true;
            this.btnPrawo.Click += new System.EventHandler(this.btnPrawo_Click);
            // 
            // btnLewo
            // 
            this.btnLewo.Location = new System.Drawing.Point(308, 360);
            this.btnLewo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLewo.Name = "btnLewo";
            this.btnLewo.Size = new System.Drawing.Size(79, 23);
            this.btnLewo.TabIndex = 18;
            this.btnLewo.Text = "Leć w Lewo";
            this.btnLewo.UseVisualStyleBackColor = true;
            this.btnLewo.Click += new System.EventHandler(this.btenLewo_Click);
            // 
            // btnProsto
            // 
            this.btnProsto.Location = new System.Drawing.Point(384, 333);
            this.btnProsto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProsto.Name = "btnProsto";
            this.btnProsto.Size = new System.Drawing.Size(79, 23);
            this.btnProsto.TabIndex = 19;
            this.btnProsto.Text = "Leć Prosto";
            this.btnProsto.UseVisualStyleBackColor = true;
            this.btnProsto.Click += new System.EventHandler(this.btnProsto_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(384, 387);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Zawróć";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(231, 96);
            this.rtbMessages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(311, 210);
            this.rtbMessages.TabIndex = 22;
            this.rtbMessages.Text = "";
            // 
            // btnUseSunSails
            // 
            this.btnUseSunSails.Location = new System.Drawing.Point(461, 461);
            this.btnUseSunSails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUseSunSails.Name = "btnUseSunSails";
            this.btnUseSunSails.Size = new System.Drawing.Size(50, 23);
            this.btnUseSunSails.TabIndex = 25;
            this.btnUseSunSails.Text = "Użyj";
            this.btnUseSunSails.UseVisualStyleBackColor = true;
            this.btnUseSunSails.Click += new System.EventHandler(this.btnUseSunSails_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(231, 13);
            this.rtbLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.Size = new System.Drawing.Size(311, 77);
            this.rtbLocation.TabIndex = 26;
            this.rtbLocation.Text = "";
            this.rtbLocation.TextChanged += new System.EventHandler(this.rtbLocation_TextChanged);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(12, 96);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(214, 210);
            this.dgvInventory.TabIndex = 27;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.Location = new System.Drawing.Point(12, 312);
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.Size = new System.Drawing.Size(280, 125);
            this.dgvQuests.TabIndex = 28;
            // 
            // worldBindingSource
            // 
            this.worldBindingSource.DataSource = typeof(silnik.World);
            // 
            // Przygoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 493);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnUseSunSails);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProsto);
            this.Controls.Add(this.btnLewo);
            this.Controls.Add(this.btnPrawo);
            this.Controls.Add(this.btnUseRepairKit);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboSunSails);
            this.Controls.Add(this.cboRepairKits);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblbaterie);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblpoziom);
            this.Controls.Add(this.lbldoświadczenie);
            this.Controls.Add(this.lblplatinium);
            this.Controls.Add(this.lblżycie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHitPoints);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Przygoda";
            this.Text = "Moja gra";
            this.Load += new System.EventHandler(this.Przygoda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblżycie;
        private System.Windows.Forms.Label lblplatinium;
        private System.Windows.Forms.Label lbldoświadczenie;
        private System.Windows.Forms.Label lblpoziom;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblbaterie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboRepairKits;
        private System.Windows.Forms.ComboBox cboSunSails;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUseRepairKit;
        private System.Windows.Forms.Button btnPrawo;
        private System.Windows.Forms.Button btnLewo;
        private System.Windows.Forms.Button btnProsto;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnUseSunSails;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.BindingSource worldBindingSource;
        private System.Windows.Forms.DataGridView dgvQuests;
    }
}

