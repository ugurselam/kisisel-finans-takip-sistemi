namespace KisiselFinansTakipSistemi
{
    partial class AnaSayfa
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
            toplamBakiyePanel = new Panel();
            bakiyeLabel = new Label();
            bakiyeBaslikLabel = new Label();
            toplamGelirPanel = new Panel();
            toplamGelirLabel = new Label();
            toplamGelirBaslikLabel = new Label();
            toplamGiderPanel = new Panel();
            toplamGiderLabel = new Label();
            toplamGiderBaslikLabel = new Label();
            toplamKazancPanel = new Panel();
            aylikKazancLabel = new Label();
            toplamKazancBaslikLabel = new Label();
            grafikPanel = new Panel();
            toplamBakiyePanel.SuspendLayout();
            toplamGelirPanel.SuspendLayout();
            toplamGiderPanel.SuspendLayout();
            toplamKazancPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toplamBakiyePanel
            // 
            toplamBakiyePanel.BackColor = Color.White;
            toplamBakiyePanel.Controls.Add(bakiyeLabel);
            toplamBakiyePanel.Controls.Add(bakiyeBaslikLabel);
            toplamBakiyePanel.Location = new Point(18, 14);
            toplamBakiyePanel.Name = "toplamBakiyePanel";
            toplamBakiyePanel.Size = new Size(154, 89);
            toplamBakiyePanel.TabIndex = 0;
            // 
            // bakiyeLabel
            // 
            bakiyeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bakiyeLabel.AutoSize = true;
            bakiyeLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bakiyeLabel.Location = new Point(49, 38);
            bakiyeLabel.Margin = new Padding(0, 0, 3, 0);
            bakiyeLabel.Name = "bakiyeLabel";
            bakiyeLabel.Size = new Size(51, 31);
            bakiyeLabel.TabIndex = 1;
            bakiyeLabel.Text = "0 $";
            // 
            // bakiyeBaslikLabel
            // 
            bakiyeBaslikLabel.AutoSize = true;
            bakiyeBaslikLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bakiyeBaslikLabel.Location = new Point(4, 4);
            bakiyeBaslikLabel.Name = "bakiyeBaslikLabel";
            bakiyeBaslikLabel.Size = new Size(63, 20);
            bakiyeBaslikLabel.TabIndex = 0;
            bakiyeBaslikLabel.Text = "Bakiye";
            // 
            // toplamGelirPanel
            // 
            toplamGelirPanel.BackColor = Color.White;
            toplamGelirPanel.Controls.Add(toplamGelirLabel);
            toplamGelirPanel.Controls.Add(toplamGelirBaslikLabel);
            toplamGelirPanel.Location = new Point(199, 14);
            toplamGelirPanel.Name = "toplamGelirPanel";
            toplamGelirPanel.Size = new Size(154, 89);
            toplamGelirPanel.TabIndex = 1;
            // 
            // toplamGelirLabel
            // 
            toplamGelirLabel.AutoSize = true;
            toplamGelirLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toplamGelirLabel.Location = new Point(48, 38);
            toplamGelirLabel.Name = "toplamGelirLabel";
            toplamGelirLabel.Size = new Size(51, 31);
            toplamGelirLabel.TabIndex = 1;
            toplamGelirLabel.Text = "0 $";
            // 
            // toplamGelirBaslikLabel
            // 
            toplamGelirBaslikLabel.AutoSize = true;
            toplamGelirBaslikLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toplamGelirBaslikLabel.Location = new Point(4, 4);
            toplamGelirBaslikLabel.Name = "toplamGelirBaslikLabel";
            toplamGelirBaslikLabel.Size = new Size(113, 20);
            toplamGelirBaslikLabel.TabIndex = 0;
            toplamGelirBaslikLabel.Text = "Toplam Gelir";
            // 
            // toplamGiderPanel
            // 
            toplamGiderPanel.BackColor = Color.White;
            toplamGiderPanel.Controls.Add(toplamGiderLabel);
            toplamGiderPanel.Controls.Add(toplamGiderBaslikLabel);
            toplamGiderPanel.Location = new Point(380, 14);
            toplamGiderPanel.Name = "toplamGiderPanel";
            toplamGiderPanel.Size = new Size(154, 89);
            toplamGiderPanel.TabIndex = 2;
            // 
            // toplamGiderLabel
            // 
            toplamGiderLabel.AutoSize = true;
            toplamGiderLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toplamGiderLabel.Location = new Point(48, 38);
            toplamGiderLabel.Name = "toplamGiderLabel";
            toplamGiderLabel.Size = new Size(51, 31);
            toplamGiderLabel.TabIndex = 1;
            toplamGiderLabel.Text = "0 $";
            // 
            // toplamGiderBaslikLabel
            // 
            toplamGiderBaslikLabel.AutoSize = true;
            toplamGiderBaslikLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toplamGiderBaslikLabel.Location = new Point(4, 4);
            toplamGiderBaslikLabel.Name = "toplamGiderBaslikLabel";
            toplamGiderBaslikLabel.Size = new Size(118, 20);
            toplamGiderBaslikLabel.TabIndex = 0;
            toplamGiderBaslikLabel.Text = "Toplam Gider";
            // 
            // toplamKazancPanel
            // 
            toplamKazancPanel.BackColor = Color.White;
            toplamKazancPanel.Controls.Add(aylikKazancLabel);
            toplamKazancPanel.Controls.Add(toplamKazancBaslikLabel);
            toplamKazancPanel.Location = new Point(561, 14);
            toplamKazancPanel.Name = "toplamKazancPanel";
            toplamKazancPanel.Size = new Size(154, 89);
            toplamKazancPanel.TabIndex = 3;
            // 
            // aylikKazancLabel
            // 
            aylikKazancLabel.AutoSize = true;
            aylikKazancLabel.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aylikKazancLabel.Location = new Point(48, 38);
            aylikKazancLabel.Name = "aylikKazancLabel";
            aylikKazancLabel.Size = new Size(51, 31);
            aylikKazancLabel.TabIndex = 1;
            aylikKazancLabel.Text = "0 $";
            // 
            // toplamKazancBaslikLabel
            // 
            toplamKazancBaslikLabel.AutoSize = true;
            toplamKazancBaslikLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toplamKazancBaslikLabel.Location = new Point(4, 4);
            toplamKazancBaslikLabel.Name = "toplamKazancBaslikLabel";
            toplamKazancBaslikLabel.Size = new Size(128, 20);
            toplamKazancBaslikLabel.TabIndex = 0;
            toplamKazancBaslikLabel.Text = "Toplam Kazanç";
            // 
            // grafikPanel
            // 
            grafikPanel.Location = new Point(16, 124);
            grafikPanel.Name = "grafikPanel";
            grafikPanel.Size = new Size(699, 267);
            grafikPanel.TabIndex = 4;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(grafikPanel);
            Controls.Add(toplamKazancPanel);
            Controls.Add(toplamGiderPanel);
            Controls.Add(toplamGelirPanel);
            Controls.Add(toplamBakiyePanel);
            Name = "AnaSayfa";
            Size = new Size(751, 432);
            toplamBakiyePanel.ResumeLayout(false);
            toplamBakiyePanel.PerformLayout();
            toplamGelirPanel.ResumeLayout(false);
            toplamGelirPanel.PerformLayout();
            toplamGiderPanel.ResumeLayout(false);
            toplamGiderPanel.PerformLayout();
            toplamKazancPanel.ResumeLayout(false);
            toplamKazancPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel toplamBakiyePanel;
        private Label bakiyeBaslikLabel;
        private Label bakiyeLabel;
        private Panel toplamGelirPanel;
        private Label toplamGelirLabel;
        private Label toplamGelirBaslikLabel;
        private Panel toplamGiderPanel;
        private Label toplamGiderLabel;
        private Label toplamGiderBaslikLabel;
        private Panel toplamKazancPanel;
        private Label aylikKazancLabel;
        private Label toplamKazancBaslikLabel;
        private Panel grafikPanel;
    }
}
