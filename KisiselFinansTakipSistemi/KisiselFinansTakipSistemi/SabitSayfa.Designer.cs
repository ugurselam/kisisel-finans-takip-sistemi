namespace KisiselFinansTakipSistemi
{
    partial class SabitSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            solSabitMenuPanel = new Panel();
            ayarlarButton = new Button();
            grafiklerButton = new Button();
            cariIslemlerButton = new Button();
            anaSayfaButton = new Button();
            icerikPanel = new Panel();
            solSabitMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // solSabitMenuPanel
            // 
            solSabitMenuPanel.BackColor = Color.DarkSlateGray;
            solSabitMenuPanel.Controls.Add(ayarlarButton);
            solSabitMenuPanel.Controls.Add(grafiklerButton);
            solSabitMenuPanel.Controls.Add(cariIslemlerButton);
            solSabitMenuPanel.Controls.Add(anaSayfaButton);
            solSabitMenuPanel.Dock = DockStyle.Left;
            solSabitMenuPanel.Location = new Point(0, 0);
            solSabitMenuPanel.Name = "solSabitMenuPanel";
            solSabitMenuPanel.Size = new Size(163, 432);
            solSabitMenuPanel.TabIndex = 0;
            // 
            // ayarlarButton
            // 
            ayarlarButton.BackColor = Color.DarkSlateGray;
            ayarlarButton.FlatAppearance.BorderSize = 0;
            ayarlarButton.FlatStyle = FlatStyle.Flat;
            ayarlarButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ayarlarButton.ForeColor = Color.White;
            ayarlarButton.Location = new Point(14, 272);
            ayarlarButton.Name = "ayarlarButton";
            ayarlarButton.Size = new Size(132, 39);
            ayarlarButton.TabIndex = 3;
            ayarlarButton.Text = "Ayarlar";
            ayarlarButton.UseVisualStyleBackColor = false;
            ayarlarButton.Click += ayarlarButton_Click;
            // 
            // grafiklerButton
            // 
            grafiklerButton.BackColor = Color.DarkSlateGray;
            grafiklerButton.FlatAppearance.BorderSize = 0;
            grafiklerButton.FlatStyle = FlatStyle.Flat;
            grafiklerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grafiklerButton.ForeColor = Color.White;
            grafiklerButton.Location = new Point(14, 213);
            grafiklerButton.Name = "grafiklerButton";
            grafiklerButton.Size = new Size(132, 39);
            grafiklerButton.TabIndex = 2;
            grafiklerButton.Text = "Grafikler";
            grafiklerButton.UseVisualStyleBackColor = false;
            grafiklerButton.Click += grafiklerButton_Click;
            // 
            // cariIslemlerButton
            // 
            cariIslemlerButton.BackColor = Color.DarkSlateGray;
            cariIslemlerButton.FlatAppearance.BorderSize = 0;
            cariIslemlerButton.FlatStyle = FlatStyle.Flat;
            cariIslemlerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cariIslemlerButton.ForeColor = Color.White;
            cariIslemlerButton.Location = new Point(14, 154);
            cariIslemlerButton.Name = "cariIslemlerButton";
            cariIslemlerButton.Size = new Size(132, 39);
            cariIslemlerButton.TabIndex = 1;
            cariIslemlerButton.Text = "Cari İşlemler";
            cariIslemlerButton.UseVisualStyleBackColor = false;
            cariIslemlerButton.Click += cariIslemlerButton_Click;
            // 
            // anaSayfaButton
            // 
            anaSayfaButton.BackColor = Color.DarkSlateGray;
            anaSayfaButton.FlatAppearance.BorderSize = 0;
            anaSayfaButton.FlatStyle = FlatStyle.Flat;
            anaSayfaButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            anaSayfaButton.ForeColor = Color.White;
            anaSayfaButton.Location = new Point(14, 95);
            anaSayfaButton.Name = "anaSayfaButton";
            anaSayfaButton.Size = new Size(132, 40);
            anaSayfaButton.TabIndex = 0;
            anaSayfaButton.Text = "Ana Sayfa";
            anaSayfaButton.UseVisualStyleBackColor = false;
            anaSayfaButton.Click += anaSayfaButton_Click;
            // 
            // icerikPanel
            // 
            icerikPanel.Dock = DockStyle.Fill;
            icerikPanel.Location = new Point(163, 0);
            icerikPanel.Name = "icerikPanel";
            icerikPanel.Size = new Size(751, 432);
            icerikPanel.TabIndex = 1;
            // 
            // SabitSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(914, 432);
            Controls.Add(icerikPanel);
            Controls.Add(solSabitMenuPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SabitSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            FormClosing += SabitSayfa_FormClosing;
            Load += SabitSayfa_Load;
            Resize += SabitSayfa_Resize;
            solSabitMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel solSabitMenuPanel;
        private Button anaSayfaButton;
        private Button cariIslemlerButton;
        private Button ayarlarButton;
        private Button grafiklerButton;
        private Panel icerikPanel;
    }
}
