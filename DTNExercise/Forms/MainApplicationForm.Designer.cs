namespace DTNExercise
{
    partial class MainApplicationForm
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
            this.reportListBox = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.instructionsTextbox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportListBox
            // 
            this.reportListBox.FormattingEnabled = true;
            this.reportListBox.ItemHeight = 15;
            this.reportListBox.Location = new System.Drawing.Point(222, 12);
            this.reportListBox.Name = "reportListBox";
            this.reportListBox.Size = new System.Drawing.Size(272, 394);
            this.reportListBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Generate";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 55);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 15);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(12, 73);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(169, 87);
            this.statusTextBox.TabIndex = 3;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 391);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(156, 15);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Author: Monteagudo Jeffrey";
            // 
            // instructionsTextbox
            // 
            this.instructionsTextbox.Location = new System.Drawing.Point(12, 235);
            this.instructionsTextbox.Multiline = true;
            this.instructionsTextbox.Name = "instructionsTextbox";
            this.instructionsTextbox.ReadOnly = true;
            this.instructionsTextbox.Size = new System.Drawing.Size(169, 140);
            this.instructionsTextbox.TabIndex = 5;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(12, 217);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(69, 15);
            this.instructionLabel.TabIndex = 6;
            this.instructionLabel.Text = "Instructions";
            // 
            // MainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 426);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.instructionsTextbox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.reportListBox);
            this.Name = "MainApplicationForm";
            this.Text = "Weather Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox reportListBox;
        private Button startButton;
        private Label statusLabel;
        private TextBox statusTextBox;
        private Label authorLabel;
        private TextBox instructionsTextbox;
        private Label instructionLabel;
    }
}