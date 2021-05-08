
namespace TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top1 = new System.Windows.Forms.Button();
            this.Top2 = new System.Windows.Forms.Button();
            this.Top3 = new System.Windows.Forms.Button();
            this.Middle1 = new System.Windows.Forms.Button();
            this.Middle2 = new System.Windows.Forms.Button();
            this.Middle3 = new System.Windows.Forms.Button();
            this.Bottom1 = new System.Windows.Forms.Button();
            this.Bottom2 = new System.Windows.Forms.Button();
            this.Bottom3 = new System.Windows.Forms.Button();
            this.XwinCountLabel = new System.Windows.Forms.Label();
            this.OwinCountLabel = new System.Windows.Forms.Label();
            this.XwinCounterTextBox = new System.Windows.Forms.TextBox();
            this.OwinCounterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawCounterTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenuItem,
            this.ExitMenuItem,
            this.ResetToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // NewGameMenuItem
            // 
            this.NewGameMenuItem.Name = "NewGameMenuItem";
            this.NewGameMenuItem.Size = new System.Drawing.Size(156, 22);
            this.NewGameMenuItem.Text = "&New Game";
            this.NewGameMenuItem.Click += new System.EventHandler(this.NewGameMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ExitMenuItem.Text = "&Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ResetToolStripMenuItem.Text = "&ResetCounters";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Top1
            // 
            this.Top1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Top1.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Top1.Location = new System.Drawing.Point(23, 36);
            this.Top1.Margin = new System.Windows.Forms.Padding(0);
            this.Top1.Name = "Top1";
            this.Top1.Size = new System.Drawing.Size(100, 100);
            this.Top1.TabIndex = 1;
            this.Top1.UseVisualStyleBackColor = false;
            this.Top1.Click += new System.EventHandler(this.button_click);
            this.Top1.MouseEnter += new System.EventHandler(this.button_enter);
            this.Top1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Top2
            // 
            this.Top2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Top2.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Top2.Location = new System.Drawing.Point(132, 36);
            this.Top2.Margin = new System.Windows.Forms.Padding(0);
            this.Top2.Name = "Top2";
            this.Top2.Size = new System.Drawing.Size(100, 100);
            this.Top2.TabIndex = 2;
            this.Top2.UseVisualStyleBackColor = false;
            this.Top2.Click += new System.EventHandler(this.button_click);
            this.Top2.MouseEnter += new System.EventHandler(this.button_enter);
            this.Top2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Top3
            // 
            this.Top3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Top3.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Top3.Location = new System.Drawing.Point(242, 36);
            this.Top3.Margin = new System.Windows.Forms.Padding(0);
            this.Top3.Name = "Top3";
            this.Top3.Size = new System.Drawing.Size(100, 100);
            this.Top3.TabIndex = 3;
            this.Top3.UseVisualStyleBackColor = false;
            this.Top3.Click += new System.EventHandler(this.button_click);
            this.Top3.MouseEnter += new System.EventHandler(this.button_enter);
            this.Top3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Middle1
            // 
            this.Middle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Middle1.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Middle1.Location = new System.Drawing.Point(23, 146);
            this.Middle1.Margin = new System.Windows.Forms.Padding(0);
            this.Middle1.Name = "Middle1";
            this.Middle1.Size = new System.Drawing.Size(100, 100);
            this.Middle1.TabIndex = 4;
            this.Middle1.UseVisualStyleBackColor = false;
            this.Middle1.Click += new System.EventHandler(this.button_click);
            this.Middle1.MouseEnter += new System.EventHandler(this.button_enter);
            this.Middle1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Middle2
            // 
            this.Middle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Middle2.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Middle2.Location = new System.Drawing.Point(132, 146);
            this.Middle2.Margin = new System.Windows.Forms.Padding(0);
            this.Middle2.Name = "Middle2";
            this.Middle2.Size = new System.Drawing.Size(100, 100);
            this.Middle2.TabIndex = 5;
            this.Middle2.UseVisualStyleBackColor = false;
            this.Middle2.Click += new System.EventHandler(this.button_click);
            this.Middle2.MouseEnter += new System.EventHandler(this.button_enter);
            this.Middle2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Middle3
            // 
            this.Middle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Middle3.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Middle3.Location = new System.Drawing.Point(242, 146);
            this.Middle3.Margin = new System.Windows.Forms.Padding(0);
            this.Middle3.Name = "Middle3";
            this.Middle3.Size = new System.Drawing.Size(100, 100);
            this.Middle3.TabIndex = 6;
            this.Middle3.UseVisualStyleBackColor = false;
            this.Middle3.Click += new System.EventHandler(this.button_click);
            this.Middle3.MouseEnter += new System.EventHandler(this.button_enter);
            this.Middle3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Bottom1
            // 
            this.Bottom1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Bottom1.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bottom1.Location = new System.Drawing.Point(23, 257);
            this.Bottom1.Margin = new System.Windows.Forms.Padding(0);
            this.Bottom1.Name = "Bottom1";
            this.Bottom1.Size = new System.Drawing.Size(100, 100);
            this.Bottom1.TabIndex = 7;
            this.Bottom1.UseVisualStyleBackColor = false;
            this.Bottom1.Click += new System.EventHandler(this.button_click);
            this.Bottom1.MouseEnter += new System.EventHandler(this.button_enter);
            this.Bottom1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Bottom2
            // 
            this.Bottom2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Bottom2.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bottom2.Location = new System.Drawing.Point(132, 257);
            this.Bottom2.Margin = new System.Windows.Forms.Padding(0);
            this.Bottom2.Name = "Bottom2";
            this.Bottom2.Size = new System.Drawing.Size(100, 100);
            this.Bottom2.TabIndex = 8;
            this.Bottom2.UseVisualStyleBackColor = false;
            this.Bottom2.Click += new System.EventHandler(this.button_click);
            this.Bottom2.MouseEnter += new System.EventHandler(this.button_enter);
            this.Bottom2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Bottom3
            // 
            this.Bottom3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Bottom3.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bottom3.Location = new System.Drawing.Point(242, 257);
            this.Bottom3.Margin = new System.Windows.Forms.Padding(0);
            this.Bottom3.Name = "Bottom3";
            this.Bottom3.Size = new System.Drawing.Size(100, 100);
            this.Bottom3.TabIndex = 9;
            this.Bottom3.UseVisualStyleBackColor = false;
            this.Bottom3.Click += new System.EventHandler(this.button_click);
            this.Bottom3.MouseEnter += new System.EventHandler(this.button_enter);
            this.Bottom3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // XwinCountLabel
            // 
            this.XwinCountLabel.AutoSize = true;
            this.XwinCountLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.XwinCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.XwinCountLabel.Location = new System.Drawing.Point(13, 381);
            this.XwinCountLabel.Name = "XwinCountLabel";
            this.XwinCountLabel.Size = new System.Drawing.Size(105, 21);
            this.XwinCountLabel.TabIndex = 10;
            this.XwinCountLabel.Text = "X Win Count";
            // 
            // OwinCountLabel
            // 
            this.OwinCountLabel.AutoSize = true;
            this.OwinCountLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.OwinCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.OwinCountLabel.Location = new System.Drawing.Point(250, 381);
            this.OwinCountLabel.Name = "OwinCountLabel";
            this.OwinCountLabel.Size = new System.Drawing.Size(107, 21);
            this.OwinCountLabel.TabIndex = 11;
            this.OwinCountLabel.Text = "O Win Count";
            // 
            // XwinCounterTextBox
            // 
            this.XwinCounterTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.XwinCounterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XwinCounterTextBox.Location = new System.Drawing.Point(13, 405);
            this.XwinCounterTextBox.Name = "XwinCounterTextBox";
            this.XwinCounterTextBox.Size = new System.Drawing.Size(100, 23);
            this.XwinCounterTextBox.TabIndex = 12;
            this.XwinCounterTextBox.Text = "0";
            this.XwinCounterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OwinCounterTextBox
            // 
            this.OwinCounterTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.OwinCounterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OwinCounterTextBox.Location = new System.Drawing.Point(250, 405);
            this.OwinCounterTextBox.Name = "OwinCounterTextBox";
            this.OwinCounterTextBox.Size = new System.Drawing.Size(100, 23);
            this.OwinCounterTextBox.TabIndex = 13;
            this.OwinCounterTextBox.Text = "0";
            this.OwinCounterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Draw Count";
            // 
            // DrawCounterTextBox
            // 
            this.DrawCounterTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.DrawCounterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DrawCounterTextBox.Location = new System.Drawing.Point(132, 405);
            this.DrawCounterTextBox.Name = "DrawCounterTextBox";
            this.DrawCounterTextBox.Size = new System.Drawing.Size(100, 23);
            this.DrawCounterTextBox.TabIndex = 15;
            this.DrawCounterTextBox.Text = "0";
            this.DrawCounterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.tictac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.DrawCounterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OwinCounterTextBox);
            this.Controls.Add(this.XwinCounterTextBox);
            this.Controls.Add(this.OwinCountLabel);
            this.Controls.Add(this.XwinCountLabel);
            this.Controls.Add(this.Bottom3);
            this.Controls.Add(this.Bottom2);
            this.Controls.Add(this.Bottom1);
            this.Controls.Add(this.Middle3);
            this.Controls.Add(this.Middle2);
            this.Controls.Add(this.Middle1);
            this.Controls.Add(this.Top3);
            this.Controls.Add(this.Top2);
            this.Controls.Add(this.Top1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Button Top1;
        private System.Windows.Forms.Button Top2;
        private System.Windows.Forms.Button Top3;
        private System.Windows.Forms.Button Middle1;
        private System.Windows.Forms.Button Middle2;
        private System.Windows.Forms.Button Middle3;
        private System.Windows.Forms.Button Bottom1;
        private System.Windows.Forms.Button Bottom2;
        private System.Windows.Forms.Button Bottom3;
        private System.Windows.Forms.Label XwinCountLabel;
        private System.Windows.Forms.Label OwinCountLabel;
        private System.Windows.Forms.TextBox XwinCounterTextBox;
        private System.Windows.Forms.TextBox OwinCounterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DrawCounterTextBox;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
    }
}

