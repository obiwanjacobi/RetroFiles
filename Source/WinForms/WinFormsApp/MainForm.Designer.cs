namespace WinFormsApp
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
            mainMenu = new MenuStrip();
            desktopToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Font = new Font("Macintosh", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainMenu.ImageScalingSize = new Size(40, 40);
            mainMenu.Items.AddRange(new ToolStripItem[] { desktopToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(8, 2, 0, 2);
            mainMenu.Size = new Size(2002, 51);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // desktopToolStripMenuItem
            // 
            desktopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, newToolStripMenuItem });
            desktopToolStripMenuItem.Name = "desktopToolStripMenuItem";
            desktopToolStripMenuItem.Size = new Size(195, 47);
            desktopToolStripMenuItem.Text = "Desktop";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(448, 54);
            aboutToolStripMenuItem.Text = "About...";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(448, 54);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(22F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2002, 1403);
            Controls.Add(mainMenu);
            Font = new Font("Macintosh", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = mainMenu;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Desktop";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem desktopToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
    }
}
