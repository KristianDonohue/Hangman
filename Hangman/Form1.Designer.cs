
namespace Hangman
{
    partial class Form1
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
            this.formPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.gamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelGameView = new System.Windows.Forms.TableLayoutPanel();
            this.labelWordToGuess = new System.Windows.Forms.Label();
            this.labelGuesses = new System.Windows.Forms.Label();
            this.labelGuess = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripResetGame = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.panelGameView.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.ColumnCount = 1;
            this.formPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formPanel.Controls.Add(this.textBoxGuess, 0, 3);
            this.formPanel.Controls.Add(this.gamePanel, 0, 1);
            this.formPanel.Controls.Add(this.labelGuess, 0, 2);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 24);
            this.formPanel.Margin = new System.Windows.Forms.Padding(0);
            this.formPanel.Name = "formPanel";
            this.formPanel.RowCount = 4;
            this.formPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.formPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formPanel.Size = new System.Drawing.Size(800, 370);
            this.formPanel.TabIndex = 0;
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(3, 343);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.PlaceholderText = "type letter here";
            this.textBoxGuess.Size = new System.Drawing.Size(88, 23);
            this.textBoxGuess.TabIndex = 1;
            this.textBoxGuess.TextChanged += new System.EventHandler(this.textBoxGuess_TextChanged);
            // 
            // gamePanel
            // 
            this.gamePanel.ColumnCount = 2;
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gamePanel.Controls.Add(this.panelGameView, 0, 0);
            this.gamePanel.Controls.Add(this.labelGuesses, 1, 0);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 20);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.RowCount = 1;
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gamePanel.Size = new System.Drawing.Size(800, 300);
            this.gamePanel.TabIndex = 1;
            // 
            // panelGameView
            // 
            this.panelGameView.ColumnCount = 1;
            this.panelGameView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelGameView.Controls.Add(this.labelWordToGuess, 0, 1);
            this.panelGameView.Controls.Add(this.pictureBox1, 0, 0);
            this.panelGameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameView.Location = new System.Drawing.Point(0, 0);
            this.panelGameView.Margin = new System.Windows.Forms.Padding(0);
            this.panelGameView.Name = "panelGameView";
            this.panelGameView.RowCount = 2;
            this.panelGameView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelGameView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panelGameView.Size = new System.Drawing.Size(700, 300);
            this.panelGameView.TabIndex = 0;
            // 
            // labelWordToGuess
            // 
            this.labelWordToGuess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWordToGuess.AutoSize = true;
            this.labelWordToGuess.Location = new System.Drawing.Point(3, 240);
            this.labelWordToGuess.Name = "labelWordToGuess";
            this.labelWordToGuess.Size = new System.Drawing.Size(694, 60);
            this.labelWordToGuess.TabIndex = 0;
            // 
            // labelGuesses
            // 
            this.labelGuesses.AutoSize = true;
            this.labelGuesses.Location = new System.Drawing.Point(703, 0);
            this.labelGuesses.Name = "labelGuesses";
            this.labelGuesses.Size = new System.Drawing.Size(0, 15);
            this.labelGuesses.TabIndex = 1;
            // 
            // labelGuess
            // 
            this.labelGuess.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelGuess.AutoSize = true;
            this.labelGuess.Location = new System.Drawing.Point(3, 322);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(80, 15);
            this.labelGuess.TabIndex = 2;
            this.labelGuess.Text = "Guess a letter!";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripResetGame,
            this.saveRecordToolStripMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenu.Text = "Menu";
            // 
            // toolStripResetGame
            // 
            this.toolStripResetGame.Name = "toolStripResetGame";
            this.toolStripResetGame.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toolStripResetGame.Size = new System.Drawing.Size(151, 22);
            this.toolStripResetGame.Text = "New Game";
            this.toolStripResetGame.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // saveRecordToolStripMenuItem
            // 
            this.saveRecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRecordToolStripMenuItem,
            this.saveRecordToolStripMenuItem1,
            this.resetRecordToolStripMenuItem});
            this.saveRecordToolStripMenuItem.Name = "saveRecordToolStripMenuItem";
            this.saveRecordToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveRecordToolStripMenuItem.Text = "Record";
            // 
            // viewRecordToolStripMenuItem
            // 
            this.viewRecordToolStripMenuItem.Name = "viewRecordToolStripMenuItem";
            this.viewRecordToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.viewRecordToolStripMenuItem.Text = "View Record";
            this.viewRecordToolStripMenuItem.Click += new System.EventHandler(this.viewRecordToolStripMenuItem_Click);
            // 
            // saveRecordToolStripMenuItem1
            // 
            this.saveRecordToolStripMenuItem1.Checked = true;
            this.saveRecordToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveRecordToolStripMenuItem1.Name = "saveRecordToolStripMenuItem1";
            this.saveRecordToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.saveRecordToolStripMenuItem1.Text = "Save Record";
            this.saveRecordToolStripMenuItem1.Click += new System.EventHandler(this.saveRecordToolStripMenuItem1_Click);
            // 
            // resetRecordToolStripMenuItem
            // 
            this.resetRecordToolStripMenuItem.Name = "resetRecordToolStripMenuItem";
            this.resetRecordToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.resetRecordToolStripMenuItem.Text = "Reset Record";
            this.resetRecordToolStripMenuItem.Click += new System.EventHandler(this.resetRecordToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 234);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.panelGameView.ResumeLayout(false);
            this.panelGameView.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formPanel;
        private System.Windows.Forms.TableLayoutPanel gamePanel;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripResetGame;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.TableLayoutPanel panelGameView;
        private System.Windows.Forms.Label labelWordToGuess;
        private System.Windows.Forms.Label labelGuesses;
        private System.Windows.Forms.ToolStripMenuItem saveRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRecordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetRecordToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

