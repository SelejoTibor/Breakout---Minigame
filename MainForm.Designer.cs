namespace BreakoutF1
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
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            pauseGameToolStripMenuItem = new ToolStripMenuItem();
            continueGameToolStripMenuItem = new ToolStripMenuItem();
            endGameToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.Size = new Size(601, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, pauseGameToolStripMenuItem, continueGameToolStripMenuItem, endGameToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(50, 19);
            gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(180, 22);
            newGameToolStripMenuItem.Text = "New";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // pauseGameToolStripMenuItem
            // 
            pauseGameToolStripMenuItem.Name = "pauseGameToolStripMenuItem";
            pauseGameToolStripMenuItem.Size = new Size(180, 22);
            pauseGameToolStripMenuItem.Text = "Pause";
            pauseGameToolStripMenuItem.Click += pauseGameToolStripMenuItem_Click;
            // 
            // continueGameToolStripMenuItem
            // 
            continueGameToolStripMenuItem.Name = "continueGameToolStripMenuItem";
            continueGameToolStripMenuItem.Size = new Size(180, 22);
            continueGameToolStripMenuItem.Text = "Continue";
            continueGameToolStripMenuItem.Click += continueGameToolStripMenuItem_Click;
            // 
            // endGameToolStripMenuItem
            // 
            endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            endGameToolStripMenuItem.Size = new Size(180, 22);
            endGameToolStripMenuItem.Text = "EndGame";
            endGameToolStripMenuItem.Click += endGameToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 404);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continueGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
    }
	

}
