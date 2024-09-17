namespace WinFormsApp
{
    partial class FinderForm
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
            titleBar1 = new WinFormsControls.TitleBar();
            button1 = new Button();
            SuspendLayout();
            // 
            // titleBar1
            // 
            titleBar1.Dock = DockStyle.Top;
            titleBar1.Font = new Font("Macintosh", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleBar1.IsActive = false;
            titleBar1.Location = new Point(3, 3);
            titleBar1.Name = "titleBar1";
            titleBar1.Size = new Size(1026, 64);
            titleBar1.TabIndex = 1;
            titleBar1.Text = "titleBar1";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 67);
            button1.Name = "button1";
            button1.Size = new Size(1026, 496);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FinderForm
            // 
            AutoScaleDimensions = new SizeF(22F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 569);
            Controls.Add(button1);
            Controls.Add(titleBar1);
            Font = new Font("Macintosh", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "FinderForm";
            Padding = new Padding(3, 3, 6, 6);
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Finder";
            ResumeLayout(false);
        }

        #endregion
        private WinFormsControls.TitleBar titleBar1;
        private Button button1;
    }
}