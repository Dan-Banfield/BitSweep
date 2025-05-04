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
            components = new System.ComponentModel.Container();
            checkBoxToolTip = new ToolTip(components);
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // checkBoxToolTip
            // 
            checkBoxToolTip.AutomaticDelay = 100;
            checkBoxToolTip.AutoPopDelay = 0;
            checkBoxToolTip.BackColor = Color.White;
            checkBoxToolTip.InitialDelay = 100;
            checkBoxToolTip.ReshowDelay = 20;
            checkBoxToolTip.ToolTipIcon = ToolTipIcon.Info;
            checkBoxToolTip.ToolTipTitle = "Information";
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(12, 13);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(696, 23);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 0;
            // 
            // CleaningForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 48);
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
        }

        #endregion
        private ToolTip checkBoxToolTip;
        private ProgressBar progressBar;
    }
}