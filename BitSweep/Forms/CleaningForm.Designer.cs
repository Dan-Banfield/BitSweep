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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleaningForm));
            progressBar = new ProgressBar();
            deletingLabel = new Label();
            progressPercentageLabel = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 38);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(441, 23);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 0;
            // 
            // deletingLabel
            // 
            deletingLabel.AutoSize = true;
            deletingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletingLabel.Location = new Point(12, 12);
            deletingLabel.Name = "deletingLabel";
            deletingLabel.Size = new Size(84, 21);
            deletingLabel.TabIndex = 1;
            deletingLabel.Text = "Deleting: ...";
            // 
            // progressPercentageLabel
            // 
            progressPercentageLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            progressPercentageLabel.Location = new Point(392, 18);
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
            ClientSize = new Size(465, 70);
            Controls.Add(progressPercentageLabel);
            Controls.Add(deletingLabel);
            Controls.Add(progressBar);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label deletingLabel;
        private Label progressPercentageLabel;
    }
}