namespace ObrSlika
{
    partial class Slika
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
            this.meni1 = new System.Windows.Forms.MenuStrip();
            this.Slika_Glavno = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriSlika = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаНаСликаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobelАлгоритамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LaplasАлгоритамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одјавиСеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prg1 = new System.Windows.Forms.ProgressBar();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.meni1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // meni1
            // 
            this.meni1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Slika_Glavno,
            this.обработкаНаСликаToolStripMenuItem,
            this.одјавиСеToolStripMenuItem});
            this.meni1.Location = new System.Drawing.Point(0, 0);
            this.meni1.Name = "meni1";
            this.meni1.Size = new System.Drawing.Size(814, 24);
            this.meni1.TabIndex = 0;
            this.meni1.Text = "menuStrip1";
            // 
            // Slika_Glavno
            // 
            this.Slika_Glavno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriSlika});
            this.Slika_Glavno.Name = "Slika_Glavno";
            this.Slika_Glavno.Size = new System.Drawing.Size(53, 20);
            this.Slika_Glavno.Text = "Слика";
            // 
            // otvoriSlika
            // 
            this.otvoriSlika.Name = "otvoriSlika";
            this.otvoriSlika.Size = new System.Drawing.Size(152, 22);
            this.otvoriSlika.Text = "Отвори Слика";
            this.otvoriSlika.Click += new System.EventHandler(this.otvoriSlika_Click);
            // 
            // обработкаНаСликаToolStripMenuItem
            // 
            this.обработкаНаСликаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SobelАлгоритамToolStripMenuItem,
            this.LaplasАлгоритамToolStripMenuItem});
            this.обработкаНаСликаToolStripMenuItem.Name = "обработкаНаСликаToolStripMenuItem";
            this.обработкаНаСликаToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.обработкаНаСликаToolStripMenuItem.Text = "Обработка на слика";
            // 
            // SobelАлгоритамToolStripMenuItem
            // 
            this.SobelАлгоритамToolStripMenuItem.Name = "SobelАлгоритамToolStripMenuItem";
            this.SobelАлгоритамToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.SobelАлгоритамToolStripMenuItem.Text = "Собел Алгоритам";
            this.SobelАлгоритамToolStripMenuItem.Click += new System.EventHandler(this.SobelАлгоритамToolStripMenuItem_Click);
            // 
            // LaplasАлгоритамToolStripMenuItem
            // 
            this.LaplasАлгоритамToolStripMenuItem.Name = "LaplasАлгоритамToolStripMenuItem";
            this.LaplasАлгоритамToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.LaplasАлгоритамToolStripMenuItem.Text = "Лаплас Алгоритам";
            this.LaplasАлгоритамToolStripMenuItem.Click += new System.EventHandler(this.LaplasАлгоритамToolStripMenuItem_Click);
            // 
            // одјавиСеToolStripMenuItem
            // 
            this.одјавиСеToolStripMenuItem.Name = "одјавиСеToolStripMenuItem";
            this.одјавиСеToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.одјавиСеToolStripMenuItem.Text = "Одјави се";
            this.одјавиСеToolStripMenuItem.Click += new System.EventHandler(this.одјавиСеToolStripMenuItem_Click);
            // 
            // prg1
            // 
            this.prg1.Dock = System.Windows.Forms.DockStyle.Top;
            this.prg1.Location = new System.Drawing.Point(0, 24);
            this.prg1.Name = "prg1";
            this.prg1.Size = new System.Drawing.Size(814, 28);
            this.prg1.TabIndex = 2;
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBox.Location = new System.Drawing.Point(0, 58);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(817, 445);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox.TabIndex = 3;
            this.pBox.TabStop = false;
            this.pBox.WaitOnLoad = true;
            // 
            // Slika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 503);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.prg1);
            this.Controls.Add(this.meni1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.meni1;
            this.Name = "Slika";
            this.Text = "Обработка на Слика";
            this.Load += new System.EventHandler(this.Slika_Load);
            this.meni1.ResumeLayout(false);
            this.meni1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip meni1;
        private System.Windows.Forms.ToolStripMenuItem Slika_Glavno;
        private System.Windows.Forms.ToolStripMenuItem otvoriSlika;
        private System.Windows.Forms.ToolStripMenuItem обработкаНаСликаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobelАлгоритамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LaplasАлгоритамToolStripMenuItem;
        private System.Windows.Forms.ProgressBar prg1;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.ToolStripMenuItem одјавиСеToolStripMenuItem;
    }
}

