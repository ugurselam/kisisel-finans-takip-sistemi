namespace KisiselFinansTakipSistemi
{
    partial class Grafikler
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
            grafikFiltreComboBox = new ComboBox();
            grafikPaneli = new Panel();
            bilgilendirmeLabel = new Label();
            SuspendLayout();
            // 
            // grafikFiltreComboBox
            // 
            grafikFiltreComboBox.BackColor = SystemColors.Window;
            grafikFiltreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            grafikFiltreComboBox.FormattingEnabled = true;
            grafikFiltreComboBox.Items.AddRange(new object[] { "Gelir-Gider Grafiği", "Gelir Grafiği", "Gider Grafiği" });
            grafikFiltreComboBox.Location = new Point(69, 31);
            grafikFiltreComboBox.Name = "grafikFiltreComboBox";
            grafikFiltreComboBox.Size = new Size(168, 28);
            grafikFiltreComboBox.TabIndex = 0;
            grafikFiltreComboBox.SelectedIndexChanged += grafikFiltreComboBox_SelectedIndexChanged;
            // 
            // grafikPaneli
            // 
            grafikPaneli.Location = new Point(31, 80);
            grafikPaneli.Name = "grafikPaneli";
            grafikPaneli.Size = new Size(662, 337);
            grafikPaneli.TabIndex = 1;
            // 
            // bilgilendirmeLabel
            // 
            bilgilendirmeLabel.AutoSize = true;
            bilgilendirmeLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bilgilendirmeLabel.ForeColor = SystemColors.ControlText;
            bilgilendirmeLabel.Location = new Point(252, 36);
            bilgilendirmeLabel.Name = "bilgilendirmeLabel";
            bilgilendirmeLabel.Size = new Size(365, 18);
            bilgilendirmeLabel.TabIndex = 2;
            bilgilendirmeLabel.Text = "Menüden seçim yaparak grafiği filtreleyebilirsiniz.";
            // 
            // Grafikler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(bilgilendirmeLabel);
            Controls.Add(grafikPaneli);
            Controls.Add(grafikFiltreComboBox);
            Name = "Grafikler";
            Size = new Size(751, 432);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox grafikFiltreComboBox;
        private Panel grafikPaneli;
        private Label bilgilendirmeLabel;
    }
}
