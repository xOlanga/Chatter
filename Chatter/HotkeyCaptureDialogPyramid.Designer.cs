namespace Chatter
{
    partial class HotkeyCaptureDialogPyramid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeyCaptureDialogPyramid));
            capturedHotkeyLabelPyramid = new Label();
            SuspendLayout();
            // 
            // capturedHotkeyLabelPyramid
            // 
            capturedHotkeyLabelPyramid.AutoSize = true;
            capturedHotkeyLabelPyramid.Location = new Point(22, 19);
            capturedHotkeyLabelPyramid.Margin = new Padding(6, 0, 6, 0);
            capturedHotkeyLabelPyramid.Name = "capturedHotkeyLabelPyramid";
            capturedHotkeyLabelPyramid.Size = new Size(172, 32);
            capturedHotkeyLabelPyramid.TabIndex = 0;
            capturedHotkeyLabelPyramid.Text = "Press any key...";
            capturedHotkeyLabelPyramid.Click += capturedHotkeyLabelPyramid_Click;
            // 
            // HotkeyCaptureDialogPyramid
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 126);
            Controls.Add(capturedHotkeyLabelPyramid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "HotkeyCaptureDialogPyramid";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label capturedHotkeyLabelPyramid;
    }
}