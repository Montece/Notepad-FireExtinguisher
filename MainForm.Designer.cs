namespace FireExtinguisher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MenuStrip = new MenuStrip();
            OpenFileMenuItem = new ToolStripMenuItem();
            SaveFileMenuItem = new ToolStripMenuItem();
            SaveAllFileMenuItem = new ToolStripMenuItem();
            CloseFileMenuItem = new ToolStripMenuItem();
            Tabs = new TabControl();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { OpenFileMenuItem, SaveFileMenuItem, SaveAllFileMenuItem, CloseFileMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(851, 24);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "MenuStrip";
            // 
            // OpenFileMenuItem
            // 
            OpenFileMenuItem.Name = "OpenFileMenuItem";
            OpenFileMenuItem.Size = new Size(66, 20);
            OpenFileMenuItem.Text = "Открыть";
            OpenFileMenuItem.Click += OpenFileMenuItem_Click;
            // 
            // SaveFileMenuItem
            // 
            SaveFileMenuItem.Name = "SaveFileMenuItem";
            SaveFileMenuItem.Size = new Size(78, 20);
            SaveFileMenuItem.Text = "Сохранить";
            SaveFileMenuItem.Click += SaveFileMenuItem_Click;
            // 
            // SaveAllFileMenuItem
            // 
            SaveAllFileMenuItem.Name = "SaveAllFileMenuItem";
            SaveAllFileMenuItem.Size = new Size(99, 20);
            SaveAllFileMenuItem.Text = "Сохранить все";
            SaveAllFileMenuItem.Click += SaveAllFileMenuItem_Click;
            // 
            // CloseFileMenuItem
            // 
            CloseFileMenuItem.Name = "CloseFileMenuItem";
            CloseFileMenuItem.Size = new Size(97, 20);
            CloseFileMenuItem.Text = "Закрыть файл";
            CloseFileMenuItem.Click += CloseFileMenuItem_Click;
            // 
            // Tabs
            // 
            Tabs.AllowDrop = true;
            Tabs.Dock = DockStyle.Fill;
            Tabs.Location = new Point(0, 24);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(851, 480);
            Tabs.TabIndex = 1;
            Tabs.SelectedIndexChanged += Tabs_SelectedIndexChanged;
            Tabs.KeyDown += Tabs_KeyDown;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 504);
            Controls.Add(Tabs);
            Controls.Add(MenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fire Extinguisher";
            Load += MainForm_Load;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem OpenFileMenuItem;
        private ToolStripMenuItem SaveFileMenuItem;
        private TabControl Tabs;
        private ToolStripMenuItem SaveAllFileMenuItem;
        private ToolStripMenuItem CloseFileMenuItem;
    }
}