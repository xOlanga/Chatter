namespace Chatter
{
    partial class HotkeyCaptureDialogCopypasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeyCaptureDialogCopypasta));
            capturedHotkeyLabelCopypasta = new Label();
            SuspendLayout();
            // 
            // capturedHotkeyLabelCopypasta
            // 
            capturedHotkeyLabelCopypasta.AutoSize = true;
            capturedHotkeyLabelCopypasta.Location = new Point(22, 19);
            capturedHotkeyLabelCopypasta.Margin = new Padding(6, 0, 6, 0);
            capturedHotkeyLabelCopypasta.Name = "capturedHotkeyLabelCopypasta";
            capturedHotkeyLabelCopypasta.Size = new Size(172, 32);
            capturedHotkeyLabelCopypasta.TabIndex = 0;
            capturedHotkeyLabelCopypasta.Text = "Press any key...";
            // 
            // HotkeyCaptureDialogCopypasta
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 126);
            Controls.Add(capturedHotkeyLabelCopypasta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "HotkeyCaptureDialogCopypasta";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label capturedHotkeyLabelCopypasta;
    }
}