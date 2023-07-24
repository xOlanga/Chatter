namespace Chatter
{
    partial class AddCopypasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCopypasta));
            AddCopypastaLabelHeader = new Label();
            CopypastaNameLabel = new Label();
            CopypastaTextLabel = new Label();
            AddCopypastaNameTextbox = new TextBox();
            AddCopypastaTextRichTextbox = new RichTextBox();
            SaveCopypastaButton = new Button();
            CancelCopypastaButton = new Button();
            SuspendLayout();
            // 
            // AddCopypastaLabelHeader
            // 
            AddCopypastaLabelHeader.AutoSize = true;
            AddCopypastaLabelHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddCopypastaLabelHeader.Location = new Point(22, 19);
            AddCopypastaLabelHeader.Margin = new Padding(6, 0, 6, 0);
            AddCopypastaLabelHeader.Name = "AddCopypastaLabelHeader";
            AddCopypastaLabelHeader.Size = new Size(199, 36);
            AddCopypastaLabelHeader.TabIndex = 0;
            AddCopypastaLabelHeader.Text = "Add Copypasta";
            // 
            // CopypastaNameLabel
            // 
            CopypastaNameLabel.AutoSize = true;
            CopypastaNameLabel.Location = new Point(22, 81);
            CopypastaNameLabel.Margin = new Padding(6, 0, 6, 0);
            CopypastaNameLabel.Name = "CopypastaNameLabel";
            CopypastaNameLabel.Size = new Size(78, 32);
            CopypastaNameLabel.TabIndex = 1;
            CopypastaNameLabel.Text = "Name";
            // 
            // CopypastaTextLabel
            // 
            CopypastaTextLabel.AutoSize = true;
            CopypastaTextLabel.Location = new Point(22, 198);
            CopypastaTextLabel.Margin = new Padding(6, 0, 6, 0);
            CopypastaTextLabel.Name = "CopypastaTextLabel";
            CopypastaTextLabel.Size = new Size(57, 32);
            CopypastaTextLabel.TabIndex = 2;
            CopypastaTextLabel.Text = "Text";
            // 
            // AddCopypastaNameTextbox
            // 
            AddCopypastaNameTextbox.Location = new Point(22, 119);
            AddCopypastaNameTextbox.Margin = new Padding(6);
            AddCopypastaNameTextbox.Name = "AddCopypastaNameTextbox";
            AddCopypastaNameTextbox.Size = new Size(427, 39);
            AddCopypastaNameTextbox.TabIndex = 3;
            // 
            // AddCopypastaTextRichTextbox
            // 
            AddCopypastaTextRichTextbox.Location = new Point(22, 237);
            AddCopypastaTextRichTextbox.Margin = new Padding(6);
            AddCopypastaTextRichTextbox.Name = "AddCopypastaTextRichTextbox";
            AddCopypastaTextRichTextbox.Size = new Size(427, 305);
            AddCopypastaTextRichTextbox.TabIndex = 4;
            AddCopypastaTextRichTextbox.Text = "";
            // 
            // SaveCopypastaButton
            // 
            SaveCopypastaButton.Location = new Point(22, 585);
            SaveCopypastaButton.Margin = new Padding(6);
            SaveCopypastaButton.Name = "SaveCopypastaButton";
            SaveCopypastaButton.Size = new Size(139, 49);
            SaveCopypastaButton.TabIndex = 5;
            SaveCopypastaButton.Text = "Save";
            SaveCopypastaButton.UseVisualStyleBackColor = true;
            SaveCopypastaButton.Click += SaveCopypastaButton_Click;
            // 
            // CancelCopypastaButton
            // 
            CancelCopypastaButton.Location = new Point(314, 585);
            CancelCopypastaButton.Margin = new Padding(6);
            CancelCopypastaButton.Name = "CancelCopypastaButton";
            CancelCopypastaButton.Size = new Size(139, 49);
            CancelCopypastaButton.TabIndex = 6;
            CancelCopypastaButton.Text = "Cancel";
            CancelCopypastaButton.UseVisualStyleBackColor = true;
            CancelCopypastaButton.Click += CancelCopypastaButton_Click;
            // 
            // AddCopypasta
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 691);
            Controls.Add(CancelCopypastaButton);
            Controls.Add(SaveCopypastaButton);
            Controls.Add(AddCopypastaTextRichTextbox);
            Controls.Add(AddCopypastaNameTextbox);
            Controls.Add(CopypastaTextLabel);
            Controls.Add(CopypastaNameLabel);
            Controls.Add(AddCopypastaLabelHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "AddCopypasta";
            Text = "New Copypasta";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddCopypastaLabelHeader;
        private Label CopypastaNameLabel;
        private Label CopypastaTextLabel;
        private TextBox AddCopypastaNameTextbox;
        private RichTextBox AddCopypastaTextRichTextbox;
        private Button SaveCopypastaButton;
        private Button CancelCopypastaButton;
    }
}