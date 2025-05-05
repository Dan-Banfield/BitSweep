namespace BitSweep.Forms
{
    partial class CleaningForm
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
            progressBar = new ProgressBar();
            label1 = new Label();
            progressPercentageLabel = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(12, 56);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(441, 23);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 1;
            label1.Text = "Do not close this window!";
            // 
            // progressPercentageLabel
            // 
            progressPercentageLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            progressPercentageLabel.Location = new Point(392, 40);
            progressPercentageLabel.Name = "progressPercentageLabel";
            progressPercentageLabel.Size = new Size(61, 13);
            progressPercentageLabel.TabIndex = 2;
            progressPercentageLabel.Text = "0%";
            progressPercentageLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CleaningForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 91);
            Controls.Add(progressPercentageLabel);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CleaningForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BitSweep — Cleaning";
            TopMost = true;
            Load += CleaningForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar progressBar;
        private Label label1;
        private Label progressPercentageLabel;
    }
}