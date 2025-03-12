namespace KisiselFinansTakipSistemi
{
    partial class CariIslemler
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
            bakiyeSilButton = new Button();
            bakiyeEkleButton = new Button();
            tutarTextBox = new TextBox();
            tutarLabel = new Label();
            aciklamaTextBox = new TextBox();
            aciklamaLabel = new Label();
            islemBasligiTextBox = new TextBox();
            islemBasligiLabel = new Label();
            cariHareketlerLabel = new Label();
            sabitGelirCheckBox = new CheckBox();
            cariVerilerList = new ListView();
            baslikCoulmn = new ColumnHeader();
            aciklamaCoulmn = new ColumnHeader();
            tutarCoulmn = new ColumnHeader();
            SuspendLayout();
            // 
            // bakiyeSilButton
            // 
            bakiyeSilButton.Location = new Point(144, 323);
            bakiyeSilButton.Name = "bakiyeSilButton";
            bakiyeSilButton.Size = new Size(94, 29);
            bakiyeSilButton.TabIndex = 15;
            bakiyeSilButton.Text = "Bakiye Sil";
            bakiyeSilButton.UseVisualStyleBackColor = true;
            bakiyeSilButton.Click += bakiyeSilButton_Click;
            // 
            // bakiyeEkleButton
            // 
            bakiyeEkleButton.Location = new Point(44, 323);
            bakiyeEkleButton.Name = "bakiyeEkleButton";
            bakiyeEkleButton.Size = new Size(94, 29);
            bakiyeEkleButton.TabIndex = 14;
            bakiyeEkleButton.Text = "Bakiye Ekle";
            bakiyeEkleButton.UseVisualStyleBackColor = true;
            bakiyeEkleButton.Click += bakiyeEkleButton_Click;
            // 
            // tutarTextBox
            // 
            tutarTextBox.Location = new Point(44, 133);
            tutarTextBox.Name = "tutarTextBox";
            tutarTextBox.Size = new Size(199, 27);
            tutarTextBox.TabIndex = 13;
            // 
            // tutarLabel
            // 
            tutarLabel.AutoSize = true;
            tutarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tutarLabel.Location = new Point(42, 110);
            tutarLabel.Name = "tutarLabel";
            tutarLabel.Size = new Size(46, 20);
            tutarLabel.TabIndex = 12;
            tutarLabel.Text = "Tutar";
            // 
            // aciklamaTextBox
            // 
            aciklamaTextBox.Location = new Point(45, 199);
            aciklamaTextBox.Multiline = true;
            aciklamaTextBox.Name = "aciklamaTextBox";
            aciklamaTextBox.Size = new Size(198, 87);
            aciklamaTextBox.TabIndex = 11;
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            aciklamaLabel.Location = new Point(43, 176);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new Size(73, 20);
            aciklamaLabel.TabIndex = 10;
            aciklamaLabel.Text = "Açıklama";
            // 
            // islemBasligiTextBox
            // 
            islemBasligiTextBox.Location = new Point(41, 69);
            islemBasligiTextBox.Name = "islemBasligiTextBox";
            islemBasligiTextBox.Size = new Size(199, 27);
            islemBasligiTextBox.TabIndex = 9;
            // 
            // islemBasligiLabel
            // 
            islemBasligiLabel.AutoSize = true;
            islemBasligiLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            islemBasligiLabel.Location = new Point(39, 46);
            islemBasligiLabel.Name = "islemBasligiLabel";
            islemBasligiLabel.Size = new Size(97, 20);
            islemBasligiLabel.TabIndex = 8;
            islemBasligiLabel.Text = "İşlem Başlığı";
            // 
            // cariHareketlerLabel
            // 
            cariHareketlerLabel.AutoSize = true;
            cariHareketlerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cariHareketlerLabel.Location = new Point(270, 46);
            cariHareketlerLabel.Name = "cariHareketlerLabel";
            cariHareketlerLabel.Size = new Size(113, 20);
            cariHareketlerLabel.TabIndex = 17;
            cariHareketlerLabel.Text = "Cari Hareketler";
            // 
            // sabitGelirCheckBox
            // 
            sabitGelirCheckBox.AutoSize = true;
            sabitGelirCheckBox.Location = new Point(45, 292);
            sabitGelirCheckBox.Name = "sabitGelirCheckBox";
            sabitGelirCheckBox.Size = new Size(104, 24);
            sabitGelirCheckBox.TabIndex = 19;
            sabitGelirCheckBox.Text = "Sabit İşlem";
            sabitGelirCheckBox.UseVisualStyleBackColor = true;
            // 
            // cariVerilerList
            // 
            cariVerilerList.Activation = ItemActivation.OneClick;
            cariVerilerList.BackColor = SystemColors.Window;
            cariVerilerList.Columns.AddRange(new ColumnHeader[] { baslikCoulmn, aciklamaCoulmn, tutarCoulmn });
            cariVerilerList.HoverSelection = true;
            cariVerilerList.Location = new Point(272, 78);
            cariVerilerList.Name = "cariVerilerList";
            cariVerilerList.Size = new Size(418, 274);
            cariVerilerList.TabIndex = 20;
            cariVerilerList.UseCompatibleStateImageBehavior = false;
            cariVerilerList.View = View.Details;
            // 
            // baslikCoulmn
            // 
            baslikCoulmn.Text = "Başlık";
            baslikCoulmn.Width = 100;
            // 
            // aciklamaCoulmn
            // 
            aciklamaCoulmn.Text = "Açıklama";
            aciklamaCoulmn.Width = 150;
            // 
            // tutarCoulmn
            // 
            tutarCoulmn.Text = "Tutar";
            tutarCoulmn.Width = 160;
            // 
            // CariIslemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(cariVerilerList);
            Controls.Add(sabitGelirCheckBox);
            Controls.Add(cariHareketlerLabel);
            Controls.Add(bakiyeSilButton);
            Controls.Add(bakiyeEkleButton);
            Controls.Add(tutarTextBox);
            Controls.Add(tutarLabel);
            Controls.Add(aciklamaTextBox);
            Controls.Add(aciklamaLabel);
            Controls.Add(islemBasligiTextBox);
            Controls.Add(islemBasligiLabel);
            Name = "CariIslemler";
            Size = new Size(751, 432);
            Load += CariIslemler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bakiyeSilButton;
        private Button bakiyeEkleButton;
        private TextBox tutarTextBox;
        private Label tutarLabel;
        private TextBox aciklamaTextBox;
        private Label aciklamaLabel;
        private TextBox islemBasligiTextBox;
        private Label islemBasligiLabel;
        private Label cariHareketlerLabel;
        private CheckBox sabitGelirCheckBox;
        private ListView cariVerilerList;
        private ColumnHeader baslikCoulmn;
        private ColumnHeader aciklamaCoulmn;
        private ColumnHeader tutarCoulmn;
    }
}
