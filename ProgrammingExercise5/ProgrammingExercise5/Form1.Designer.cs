
namespace ProgrammingExercise5
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
            this.YearInputLabel = new System.Windows.Forms.Label();
            this.MonthInputLabel = new System.Windows.Forms.Label();
            this.DayInputLabel = new System.Windows.Forms.Label();
            this.ColorInputLabel = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YearInputLabel
            // 
            this.YearInputLabel.AutoSize = true;
            this.YearInputLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.YearInputLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YearInputLabel.ForeColor = System.Drawing.Color.Black;
            this.YearInputLabel.Location = new System.Drawing.Point(80, 42);
            this.YearInputLabel.Name = "YearInputLabel";
            this.YearInputLabel.Size = new System.Drawing.Size(198, 25);
            this.YearInputLabel.TabIndex = 0;
            this.YearInputLabel.Text = "Enter your birth year";
            // 
            // MonthInputLabel
            // 
            this.MonthInputLabel.AutoSize = true;
            this.MonthInputLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.MonthInputLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MonthInputLabel.ForeColor = System.Drawing.Color.Black;
            this.MonthInputLabel.Location = new System.Drawing.Point(59, 87);
            this.MonthInputLabel.Name = "MonthInputLabel";
            this.MonthInputLabel.Size = new System.Drawing.Size(219, 25);
            this.MonthInputLabel.TabIndex = 1;
            this.MonthInputLabel.Text = "Enter your birth month";
            // 
            // DayInputLabel
            // 
            this.DayInputLabel.AutoSize = true;
            this.DayInputLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DayInputLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayInputLabel.ForeColor = System.Drawing.Color.Black;
            this.DayInputLabel.Location = new System.Drawing.Point(86, 132);
            this.DayInputLabel.Name = "DayInputLabel";
            this.DayInputLabel.Size = new System.Drawing.Size(192, 25);
            this.DayInputLabel.TabIndex = 2;
            this.DayInputLabel.Text = "Enter your birth day";
            // 
            // ColorInputLabel
            // 
            this.ColorInputLabel.AutoSize = true;
            this.ColorInputLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ColorInputLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorInputLabel.ForeColor = System.Drawing.Color.Black;
            this.ColorInputLabel.Location = new System.Drawing.Point(47, 176);
            this.ColorInputLabel.Name = "ColorInputLabel";
            this.ColorInputLabel.Size = new System.Drawing.Size(231, 25);
            this.ColorInputLabel.TabIndex = 3;
            this.ColorInputLabel.Text = "Enter your favorite color";
            // 
            // YearComboBox
            // 
            this.YearComboBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.YearComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(302, 38);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(121, 29);
            this.YearComboBox.TabIndex = 4;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.MonthComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(302, 83);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(121, 29);
            this.MonthComboBox.TabIndex = 5;
            this.MonthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBox_SelectedIndexChanged);
            // 
            // DayComboBox
            // 
            this.DayComboBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DayComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Location = new System.Drawing.Point(302, 128);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(121, 29);
            this.DayComboBox.TabIndex = 6;
            this.DayComboBox.SelectedIndexChanged += new System.EventHandler(this.DayComboBox_SelectedIndexChanged);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ColorComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(302, 172);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 29);
            this.ColorComboBox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Violet;
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(114, 228);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(244, 46);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Lucky Number..";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Crimson;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(370, 298);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(79, 33);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgrammingExercise5.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(476, 350);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.DayComboBox);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.ColorInputLabel);
            this.Controls.Add(this.DayInputLabel);
            this.Controls.Add(this.MonthInputLabel);
            this.Controls.Add(this.YearInputLabel);
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YearInputLabel;
        private System.Windows.Forms.Label MonthInputLabel;
        private System.Windows.Forms.Label DayInputLabel;
        private System.Windows.Forms.Label ColorInputLabel;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

