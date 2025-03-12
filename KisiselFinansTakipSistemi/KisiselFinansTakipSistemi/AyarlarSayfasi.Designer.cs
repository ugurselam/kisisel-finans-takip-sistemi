namespace KisiselFinansTakipSistemi
{
    partial class AyarlarSayfasi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            kisiselAyarlarLabel = new Label();
            paraBirimiComboBox = new ComboBox();
            paraBirimiLabel = new Label();
            kisiselAyarlarPanel = new Panel();
            dilComboBox = new ComboBox();
            dilLabel = new Label();
            grafikAyarlariLabel = new Label();
            grafikAyarlariPanel = new Panel();
            grafikYaziRengiButton = new Button();
            giderCizgiRengiButton = new Button();
            gelirCizgiRengiButton = new Button();
            cizgiTuruComboBox = new ComboBox();
            cizgiTuruLabel = new Label();
            giderCizgiRengi = new ColorDialog();
            gelirCizgiRengi = new ColorDialog();
            yaziRengi = new ColorDialog();
            kisiselAyarlarPanel.SuspendLayout();
            grafikAyarlariPanel.SuspendLayout();
            SuspendLayout();
            // 
            // kisiselAyarlarLabel
            // 
            kisiselAyarlarLabel.AutoSize = true;
            kisiselAyarlarLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kisiselAyarlarLabel.ForeColor = SystemColors.Control;
            kisiselAyarlarLabel.Location = new Point(302, 19);
            kisiselAyarlarLabel.Name = "kisiselAyarlarLabel";
            kisiselAyarlarLabel.Size = new Size(122, 23);
            kisiselAyarlarLabel.TabIndex = 0;
            kisiselAyarlarLabel.Text = "Kişisel Ayarlar";
            // 
            // paraBirimiComboBox
            // 
            paraBirimiComboBox.FormattingEnabled = true;
            paraBirimiComboBox.Items.AddRange(new object[] { "Türk Lirası", "ABD Doları", "Euro" });
            paraBirimiComboBox.Location = new Point(150, 15);
            paraBirimiComboBox.Name = "paraBirimiComboBox";
            paraBirimiComboBox.Size = new Size(151, 28);
            paraBirimiComboBox.TabIndex = 1;
            paraBirimiComboBox.SelectedIndexChanged += paraBirimiComboBox_SelectedIndexChanged;
            // 
            // paraBirimiLabel
            // 
            paraBirimiLabel.AutoSize = true;
            paraBirimiLabel.ForeColor = SystemColors.ControlText;
            paraBirimiLabel.Location = new Point(66, 18);
            paraBirimiLabel.Name = "paraBirimiLabel";
            paraBirimiLabel.Size = new Size(83, 20);
            paraBirimiLabel.TabIndex = 2;
            paraBirimiLabel.Text = "Para Birimi:";
            // 
            // kisiselAyarlarPanel
            // 
            kisiselAyarlarPanel.BackColor = Color.Gainsboro;
            kisiselAyarlarPanel.BorderStyle = BorderStyle.FixedSingle;
            kisiselAyarlarPanel.Controls.Add(dilComboBox);
            kisiselAyarlarPanel.Controls.Add(dilLabel);
            kisiselAyarlarPanel.Controls.Add(paraBirimiComboBox);
            kisiselAyarlarPanel.Controls.Add(paraBirimiLabel);
            kisiselAyarlarPanel.Location = new Point(29, 61);
            kisiselAyarlarPanel.Name = "kisiselAyarlarPanel";
            kisiselAyarlarPanel.Size = new Size(674, 66);
            kisiselAyarlarPanel.TabIndex = 3;
            // 
            // dilComboBox
            // 
            dilComboBox.FormattingEnabled = true;
            dilComboBox.Items.AddRange(new object[] { "Türkçe", "English", "Deutsch" });
            dilComboBox.Location = new Point(391, 16);
            dilComboBox.Name = "dilComboBox";
            dilComboBox.Size = new Size(151, 28);
            dilComboBox.TabIndex = 3;
            dilComboBox.SelectedIndexChanged += dilComboBox_SelectedIndexChanged;
            // 
            // dilLabel
            // 
            dilLabel.AutoSize = true;
            dilLabel.ForeColor = SystemColors.ControlText;
            dilLabel.Location = new Point(354, 19);
            dilLabel.Name = "dilLabel";
            dilLabel.Size = new Size(31, 20);
            dilLabel.TabIndex = 4;
            dilLabel.Text = "Dil:";
            // 
            // grafikAyarlariLabel
            // 
            grafikAyarlariLabel.AutoSize = true;
            grafikAyarlariLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grafikAyarlariLabel.ForeColor = SystemColors.Control;
            grafikAyarlariLabel.Location = new Point(302, 150);
            grafikAyarlariLabel.Name = "grafikAyarlariLabel";
            grafikAyarlariLabel.Size = new Size(128, 23);
            grafikAyarlariLabel.TabIndex = 4;
            grafikAyarlariLabel.Text = "Grafik Ayarları";
            // 
            // grafikAyarlariPanel
            // 
            grafikAyarlariPanel.BackColor = Color.Gainsboro;
            grafikAyarlariPanel.BorderStyle = BorderStyle.FixedSingle;
            grafikAyarlariPanel.Controls.Add(grafikYaziRengiButton);
            grafikAyarlariPanel.Controls.Add(giderCizgiRengiButton);
            grafikAyarlariPanel.Controls.Add(gelirCizgiRengiButton);
            grafikAyarlariPanel.Controls.Add(cizgiTuruComboBox);
            grafikAyarlariPanel.Controls.Add(cizgiTuruLabel);
            grafikAyarlariPanel.Location = new Point(29, 183);
            grafikAyarlariPanel.Name = "grafikAyarlariPanel";
            grafikAyarlariPanel.Size = new Size(674, 125);
            grafikAyarlariPanel.TabIndex = 5;
            // 
            // grafikYaziRengiButton
            // 
            grafikYaziRengiButton.Location = new Point(391, 18);
            grafikYaziRengiButton.Name = "grafikYaziRengiButton";
            grafikYaziRengiButton.Size = new Size(151, 29);
            grafikYaziRengiButton.TabIndex = 7;
            grafikYaziRengiButton.Text = "Yazı Rengi";
            grafikYaziRengiButton.UseVisualStyleBackColor = true;
            grafikYaziRengiButton.Click += grafikYaziRengiButton_Click;
            // 
            // giderCizgiRengiButton
            // 
            giderCizgiRengiButton.Location = new Point(391, 72);
            giderCizgiRengiButton.Name = "giderCizgiRengiButton";
            giderCizgiRengiButton.Size = new Size(151, 29);
            giderCizgiRengiButton.TabIndex = 6;
            giderCizgiRengiButton.Text = "Gider Çizgi Rengi";
            giderCizgiRengiButton.UseVisualStyleBackColor = true;
            giderCizgiRengiButton.Click += giderCizgiRengiButton_Click;
            // 
            // gelirCizgiRengiButton
            // 
            gelirCizgiRengiButton.Location = new Point(150, 72);
            gelirCizgiRengiButton.Name = "gelirCizgiRengiButton";
            gelirCizgiRengiButton.Size = new Size(151, 29);
            gelirCizgiRengiButton.TabIndex = 5;
            gelirCizgiRengiButton.Text = "Gelir Çizgi Rengi";
            gelirCizgiRengiButton.UseVisualStyleBackColor = true;
            gelirCizgiRengiButton.Click += gelirCizgiRengiButton_Click;
            // 
            // cizgiTuruComboBox
            // 
            cizgiTuruComboBox.FormattingEnabled = true;
            cizgiTuruComboBox.Items.AddRange(new object[] { "Keskin", "Yumuşak" });
            cizgiTuruComboBox.Location = new Point(150, 19);
            cizgiTuruComboBox.Name = "cizgiTuruComboBox";
            cizgiTuruComboBox.Size = new Size(151, 28);
            cizgiTuruComboBox.TabIndex = 3;
            cizgiTuruComboBox.SelectedIndexChanged += cizgiTuruComboBox_SelectedIndexChanged;
            // 
            // cizgiTuruLabel
            // 
            cizgiTuruLabel.AutoSize = true;
            cizgiTuruLabel.ForeColor = SystemColors.ControlText;
            cizgiTuruLabel.Location = new Point(71, 22);
            cizgiTuruLabel.Name = "cizgiTuruLabel";
            cizgiTuruLabel.Size = new Size(78, 20);
            cizgiTuruLabel.TabIndex = 4;
            cizgiTuruLabel.Text = "Çizgi Türü:";
            // 
            // AyarlarSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(grafikAyarlariPanel);
            Controls.Add(grafikAyarlariLabel);
            Controls.Add(kisiselAyarlarPanel);
            Controls.Add(kisiselAyarlarLabel);
            Name = "AyarlarSayfasi";
            Size = new Size(751, 432);
            kisiselAyarlarPanel.ResumeLayout(false);
            kisiselAyarlarPanel.PerformLayout();
            grafikAyarlariPanel.ResumeLayout(false);
            grafikAyarlariPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kisiselAyarlarLabel;
        private ComboBox paraBirimiComboBox;
        private Label paraBirimiLabel;
        private Panel kisiselAyarlarPanel;
        private ComboBox dilComboBox;
        private Label dilLabel;
        private Label grafikAyarlariLabel;
        private Panel grafikAyarlariPanel;
        private ComboBox cizgiTuruComboBox;
        private Label cizgiTuruLabel;
        private Button gelirCizgiRengiButton;
        private Button giderCizgiRengiButton;
        private Button grafikYaziRengiButton;
        private ColorDialog giderCizgiRengi;
        private ColorDialog gelirCizgiRengi;
        private ColorDialog yaziRengi;
    }
}
