namespace Chatter
{
    partial class HotkeyCaptureDialogSpam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeyCaptureDialogSpam));
            capturedHotkeyLabelSpam = new Label();
            SuspendLayout();
            // 
            // capturedHotkeyLabelSpam
            // 
            capturedHotkeyLabelSpam.AutoSize = true;
            capturedHotkeyLabelSpam.Location = new Point(22, 19);
            capturedHotkeyLabelSpam.Margin = new Padding(6, 0, 6, 0);
            capturedHotkeyLabelSpam.Name = "capturedHotkeyLabelSpam";
            capturedHotkeyLabelSpam.Size = new Size(172, 32);
            capturedHotkeyLabelSpam.TabIndex = 0;
            capturedHotkeyLabelSpam.Text = "Press any key...";
            // 
            // HotkeyCaptureDialogSpam
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(431, 126);
            Controls.Add(capturedHotkeyLabelSpam);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "HotkeyCaptureDialogSpam";
            TopMost = true;
            Load += HotkeyCaptureDialogSpam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label capturedHotkeyLabelSpam;
    }
}