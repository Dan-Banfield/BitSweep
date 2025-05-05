namespace BitSweep.Forms
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            temporaryFilesCheckBox = new CheckBox();
            checkBoxToolTip = new ToolTip(components);
            userTemporaryFilesCheckBox = new CheckBox();
            windowsPrefetchFilesCheckBox = new CheckBox();
            downloadedProgramFilesCheckBox = new CheckBox();
            windowsUpdateCache = new CheckBox();
            deliveryOptimisationFilesCheckBox = new CheckBox();
            systemLogFilesCheckBox = new CheckBox();
            minidumpsMemoryDumpsCheckBox = new CheckBox();
            sweepButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(147, 26);
            label1.TabIndex = 0;
            label1.Text = "📦 Useless Files";
            // 
            // temporaryFilesCheckBox
            // 
            temporaryFilesCheckBox.AutoSize = true;
            temporaryFilesCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            temporaryFilesCheckBox.Location = new Point(53, 72);
            temporaryFilesCheckBox.Name = "temporaryFilesCheckBox";
            temporaryFilesCheckBox.Size = new Size(138, 25);
            temporaryFilesCheckBox.TabIndex = 1;
            temporaryFilesCheckBox.Tag = "C:\\Windows\\Temp";
            temporaryFilesCheckBox.Text = "Temporary Files";
            checkBoxToolTip.SetToolTip(temporaryFilesCheckBox, "General temporary files created by Windows and apps.");
            temporaryFilesCheckBox.UseVisualStyleBackColor = true;
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
            // userTemporaryFilesCheckBox
            // 
            userTemporaryFilesCheckBox.AutoSize = true;
            userTemporaryFilesCheckBox.Enabled = false;
            userTemporaryFilesCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTemporaryFilesCheckBox.Location = new Point(53, 103);
            userTemporaryFilesCheckBox.Name = "userTemporaryFilesCheckBox";
            userTemporaryFilesCheckBox.Size = new Size(174, 25);
            userTemporaryFilesCheckBox.TabIndex = 2;
            userTemporaryFilesCheckBox.Text = "User Temporary Files";
            checkBoxToolTip.SetToolTip(userTemporaryFilesCheckBox, "Temporary files specific to the logged-in user.");
            userTemporaryFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // windowsPrefetchFilesCheckBox
            // 
            windowsPrefetchFilesCheckBox.AutoSize = true;
            windowsPrefetchFilesCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            windowsPrefetchFilesCheckBox.Location = new Point(53, 134);
            windowsPrefetchFilesCheckBox.Name = "windowsPrefetchFilesCheckBox";
            windowsPrefetchFilesCheckBox.Size = new Size(190, 25);
            windowsPrefetchFilesCheckBox.TabIndex = 3;
            windowsPrefetchFilesCheckBox.Tag = "C:\\Windows\\Prefetch";
            windowsPrefetchFilesCheckBox.Text = "Windows Prefetch Files";
            checkBoxToolTip.SetToolTip(windowsPrefetchFilesCheckBox, "Files that speed up app launching by caching data; can be cleared occasionally.");
            windowsPrefetchFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // downloadedProgramFilesCheckBox
            // 
            downloadedProgramFilesCheckBox.AutoSize = true;
            downloadedProgramFilesCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            downloadedProgramFilesCheckBox.Location = new Point(53, 165);
            downloadedProgramFilesCheckBox.Name = "downloadedProgramFilesCheckBox";
            downloadedProgramFilesCheckBox.Size = new Size(217, 25);
            downloadedProgramFilesCheckBox.TabIndex = 4;
            downloadedProgramFilesCheckBox.Tag = "C:\\Windows\\Downloaded Program Files";
            downloadedProgramFilesCheckBox.Text = "Downloaded Program Files\t";
            checkBoxToolTip.SetToolTip(downloadedProgramFilesCheckBox, "ActiveX controls and Java applets downloaded from the Internet.");
            downloadedProgramFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // windowsUpdateCache
            // 
            windowsUpdateCache.AutoSize = true;
            windowsUpdateCache.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            windowsUpdateCache.Location = new Point(286, 72);
            windowsUpdateCache.Name = "windowsUpdateCache";
            windowsUpdateCache.Size = new Size(194, 25);
            windowsUpdateCache.TabIndex = 5;
            windowsUpdateCache.Tag = "C:\\Windows\\SoftwareDistribution\\Download";
            windowsUpdateCache.Text = "Windows Update Cache";
            checkBoxToolTip.SetToolTip(windowsUpdateCache, "Leftovers from Windows Updates.");
            windowsUpdateCache.UseVisualStyleBackColor = true;
            // 
            // deliveryOptimisationFilesCheckBox
            // 
            deliveryOptimisationFilesCheckBox.AutoSize = true;
            deliveryOptimisationFilesCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryOptimisationFilesCheckBox.Location = new Point(286, 103);
            deliveryOptimisationFilesCheckBox.Name = "deliveryOptimisationFilesCheckBox";
            deliveryOptimisationFilesCheckBox.Size = new Size(215, 25);
            deliveryOptimisationFilesCheckBox.TabIndex = 6;
            deliveryOptimisationFilesCheckBox.Tag = "C:\\Windows\\SoftwareDistribution\\DeliveryOptimization";
            deliveryOptimisationFilesCheckBox.Text = "Delivery Optimisation Files";
            checkBoxToolTip.SetToolTip(deliveryOptimisationFilesCheckBox, "Files used for update distribution.");
            deliveryOptimisationFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // systemLogFilesCheckBox
            // 
            systemLogFilesCheckBox.AutoSize = true;
            systemLogFilesCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemLogFilesCheckBox.Location = new Point(286, 134);
            systemLogFilesCheckBox.Name = "systemLogFilesCheckBox";
            systemLogFilesCheckBox.Size = new Size(145, 25);
            systemLogFilesCheckBox.TabIndex = 7;
            systemLogFilesCheckBox.Tag = "C:\\Windows\\Logs";
            systemLogFilesCheckBox.Text = "System Log Files";
            checkBoxToolTip.SetToolTip(systemLogFilesCheckBox, "Windows event and diagnostic logs.");
            systemLogFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // minidumpsMemoryDumpsCheckBox
            // 
            minidumpsMemoryDumpsCheckBox.AutoSize = true;
            minidumpsMemoryDumpsCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minidumpsMemoryDumpsCheckBox.Location = new Point(286, 165);
            minidumpsMemoryDumpsCheckBox.Name = "minidumpsMemoryDumpsCheckBox";
            minidumpsMemoryDumpsCheckBox.Size = new Size(228, 25);
            minidumpsMemoryDumpsCheckBox.TabIndex = 8;
            minidumpsMemoryDumpsCheckBox.Tag = "C:\\Windows\\Minidump";
            minidumpsMemoryDumpsCheckBox.Text = "Minidumps, Memory Dumps";
            checkBoxToolTip.SetToolTip(minidumpsMemoryDumpsCheckBox, "Created during BSODs or crashes.");
            minidumpsMemoryDumpsCheckBox.UseVisualStyleBackColor = true;
            // 
            // sweepButton
            // 
            sweepButton.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sweepButton.Location = new Point(65, 214);
            sweepButton.Name = "sweepButton";
            sweepButton.Size = new Size(616, 51);
            sweepButton.TabIndex = 9;
            sweepButton.Text = "Sweep! \U0001f9f9";
            sweepButton.UseVisualStyleBackColor = true;
            sweepButton.Click += sweepButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 300);
            Controls.Add(sweepButton);
            Controls.Add(minidumpsMemoryDumpsCheckBox);
            Controls.Add(systemLogFilesCheckBox);
            Controls.Add(deliveryOptimisationFilesCheckBox);
            Controls.Add(windowsUpdateCache);
            Controls.Add(downloadedProgramFilesCheckBox);
            Controls.Add(windowsPrefetchFilesCheckBox);
            Controls.Add(userTemporaryFilesCheckBox);
            Controls.Add(temporaryFilesCheckBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BitSweep";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox temporaryFilesCheckBox;
        private ToolTip checkBoxToolTip;
        private CheckBox userTemporaryFilesCheckBox;
        private CheckBox windowsPrefetchFilesCheckBox;
        private CheckBox downloadedProgramFilesCheckBox;
        private CheckBox windowsUpdateCache;
        private CheckBox deliveryOptimisationFilesCheckBox;
        private CheckBox systemLogFilesCheckBox;
        private CheckBox minidumpsMemoryDumpsCheckBox;
        private Button sweepButton;
    }
}