namespace minel_selvi
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goruntuyontemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griyontemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamadegerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt709ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acıklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalacmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.goruntuyontemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(215, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dosyaToolStripMenuItem.Text = "dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.kapatToolStripMenuItem.Text = "kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // goruntuyontemleriToolStripMenuItem
            // 
            this.goruntuyontemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griyontemleriToolStripMenuItem});
            this.goruntuyontemleriToolStripMenuItem.Name = "goruntuyontemleriToolStripMenuItem";
            this.goruntuyontemleriToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.goruntuyontemleriToolStripMenuItem.Text = "goruntuyontemleri";
            // 
            // griyontemleriToolStripMenuItem
            // 
            this.griyontemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ortalamadegerToolStripMenuItem,
            this.bt709ToolStripMenuItem,
            this.lumaToolStripMenuItem,
            this.acıklıkToolStripMenuItem,
            this.kanalacmaToolStripMenuItem});
            this.griyontemleriToolStripMenuItem.Name = "griyontemleriToolStripMenuItem";
            this.griyontemleriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.griyontemleriToolStripMenuItem.Text = "griyontemleri";
            this.griyontemleriToolStripMenuItem.Click += new System.EventHandler(this.griyontemleriToolStripMenuItem_Click);
            // 
            // ortalamadegerToolStripMenuItem
            // 
            this.ortalamadegerToolStripMenuItem.Name = "ortalamadegerToolStripMenuItem";
            this.ortalamadegerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ortalamadegerToolStripMenuItem.Text = "ortalamadeger";
            this.ortalamadegerToolStripMenuItem.Click += new System.EventHandler(this.ortalamadegerToolStripMenuItem_Click);
            // 
            // bt709ToolStripMenuItem
            // 
            this.bt709ToolStripMenuItem.Name = "bt709ToolStripMenuItem";
            this.bt709ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bt709ToolStripMenuItem.Text = "bt709";
            this.bt709ToolStripMenuItem.Click += new System.EventHandler(this.bt709ToolStripMenuItem_Click);
            // 
            // lumaToolStripMenuItem
            // 
            this.lumaToolStripMenuItem.Name = "lumaToolStripMenuItem";
            this.lumaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lumaToolStripMenuItem.Text = "luma";
            this.lumaToolStripMenuItem.Click += new System.EventHandler(this.lumaToolStripMenuItem_Click);
            // 
            // acıklıkToolStripMenuItem
            // 
            this.acıklıkToolStripMenuItem.Name = "acıklıkToolStripMenuItem";
            this.acıklıkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acıklıkToolStripMenuItem.Text = "acıklık";
            this.acıklıkToolStripMenuItem.Click += new System.EventHandler(this.acıklıkToolStripMenuItem_Click);
            // 
            // kanalacmaToolStripMenuItem
            // 
            this.kanalacmaToolStripMenuItem.Name = "kanalacmaToolStripMenuItem";
            this.kanalacmaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kanalacmaToolStripMenuItem.Text = "kanalacma";
            this.kanalacmaToolStripMenuItem.Click += new System.EventHandler(this.kanalacmaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 216);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goruntuyontemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griyontemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamadegerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bt709ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acıklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalacmaToolStripMenuItem;
    }
}

