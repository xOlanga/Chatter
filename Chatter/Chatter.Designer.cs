namespace Chatter
{
    partial class Chatter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chatter));
            MainTabControl = new TabControl();
            TabPageSpammer = new TabPage();
            SpammerHeaderLabel = new Label();
            NonVIPMoodeCheckboxSpammer = new CheckBox();
            ResetHotkeyButtonSpam = new Button();
            CurrentHotkeySpamLabelStatic = new Label();
            CurrentHotkeySpamLabel = new Label();
            SetHotkeyButton = new Button();
            HotkeySpamLabel = new Label();
            RepetitionsSpamTextbox = new TextBox();
            RepeatSpamLabel = new Label();
            DelaySpamTextBox = new TextBox();
            DelaySpamLabel = new Label();
            WhatToSpamLabel = new Label();
            SpamTextBox = new TextBox();
            TabPagePyramid = new TabPage();
            PyramidHeaderLabel = new Label();
            CurrentHotkeyPyramidLabel = new Label();
            CurrentHotkeyPyramidLabelStatic = new Label();
            ResetHotkeyButtonPyramid = new Button();
            SetHotkeyButtonPyramid = new Button();
            HotkeyPyramidLabel = new Label();
            NonVIPModeCheckboxPyramid = new CheckBox();
            DelayPyramidTextbox = new TextBox();
            PyramidDelayLabel = new Label();
            PyramidWidthLabel = new Label();
            PyramidWidthNumeric = new NumericUpDown();
            PyramidEmoteTextbox = new TextBox();
            PyramidEmoteTextboxLabel = new Label();
            TabPageCopypasta = new TabPage();
            CurrentHotkeyCopypastaLabel = new Label();
            CurrentHotkeyCopypastaLabelStatic = new Label();
            ResetHotkeyButtonCopypasta = new Button();
            SetHotkeyButtonCopypasta = new Button();
            HotkeyLabelCopypasta = new Label();
            DeleteSelectedCopypastaButton = new Button();
            AddNewCopypastaButton = new Button();
            CopypastaPreviewLabel = new Label();
            CopyPastaPreviewRichTextbox = new RichTextBox();
            SavedCopypastasLabel = new Label();
            CopypastaComboBox = new ComboBox();
            CopypastaHeaderLabel = new Label();
            MainTabControl.SuspendLayout();
            TabPageSpammer.SuspendLayout();
            TabPagePyramid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PyramidWidthNumeric).BeginInit();
            TabPageCopypasta.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(TabPageSpammer);
            MainTabControl.Controls.Add(TabPagePyramid);
            MainTabControl.Controls.Add(TabPageCopypasta);
            MainTabControl.Location = new Point(22, 26);
            MainTabControl.Margin = new Padding(6);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(501, 823);
            MainTabControl.TabIndex = 0;
            // 
            // TabPageSpammer
            // 
            TabPageSpammer.Controls.Add(SpammerHeaderLabel);
            TabPageSpammer.Controls.Add(NonVIPMoodeCheckboxSpammer);
            TabPageSpammer.Controls.Add(ResetHotkeyButtonSpam);
            TabPageSpammer.Controls.Add(CurrentHotkeySpamLabelStatic);
            TabPageSpammer.Controls.Add(CurrentHotkeySpamLabel);
            TabPageSpammer.Controls.Add(SetHotkeyButton);
            TabPageSpammer.Controls.Add(HotkeySpamLabel);
            TabPageSpammer.Controls.Add(RepetitionsSpamTextbox);
            TabPageSpammer.Controls.Add(RepeatSpamLabel);
            TabPageSpammer.Controls.Add(DelaySpamTextBox);
            TabPageSpammer.Controls.Add(DelaySpamLabel);
            TabPageSpammer.Controls.Add(WhatToSpamLabel);
            TabPageSpammer.Controls.Add(SpamTextBox);
            TabPageSpammer.Location = new Point(8, 46);
            TabPageSpammer.Margin = new Padding(6);
            TabPageSpammer.Name = "TabPageSpammer";
            TabPageSpammer.Padding = new Padding(6);
            TabPageSpammer.Size = new Size(485, 769);
            TabPageSpammer.TabIndex = 0;
            TabPageSpammer.Text = "Spammer";
            TabPageSpammer.UseVisualStyleBackColor = true;
            // 
            // SpammerHeaderLabel
            // 
            SpammerHeaderLabel.AutoSize = true;
            SpammerHeaderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            SpammerHeaderLabel.Location = new Point(15, 6);
            SpammerHeaderLabel.Margin = new Padding(6, 0, 6, 0);
            SpammerHeaderLabel.Name = "SpammerHeaderLabel";
            SpammerHeaderLabel.Size = new Size(163, 45);
            SpammerHeaderLabel.TabIndex = 12;
            SpammerHeaderLabel.Text = "Spammer";
            // 
            // NonVIPMoodeCheckboxSpammer
            // 
            NonVIPMoodeCheckboxSpammer.AutoSize = true;
            NonVIPMoodeCheckboxSpammer.Location = new Point(206, 260);
            NonVIPMoodeCheckboxSpammer.Margin = new Padding(6);
            NonVIPMoodeCheckboxSpammer.Name = "NonVIPMoodeCheckboxSpammer";
            NonVIPMoodeCheckboxSpammer.Size = new Size(222, 36);
            NonVIPMoodeCheckboxSpammer.TabIndex = 11;
            NonVIPMoodeCheckboxSpammer.Text = "I'm not VIP/Mod";
            NonVIPMoodeCheckboxSpammer.UseVisualStyleBackColor = true;
            NonVIPMoodeCheckboxSpammer.CheckedChanged += NonVIPMoodeCheckbox_CheckedChanged;
            // 
            // ResetHotkeyButtonSpam
            // 
            ResetHotkeyButtonSpam.Location = new Point(162, 516);
            ResetHotkeyButtonSpam.Margin = new Padding(6);
            ResetHotkeyButtonSpam.Name = "ResetHotkeyButtonSpam";
            ResetHotkeyButtonSpam.Size = new Size(162, 49);
            ResetHotkeyButtonSpam.TabIndex = 10;
            ResetHotkeyButtonSpam.Text = "Reset Hotkey";
            ResetHotkeyButtonSpam.UseVisualStyleBackColor = true;
            ResetHotkeyButtonSpam.Click += ResetHotkeyButtonSpam_Click;
            // 
            // CurrentHotkeySpamLabelStatic
            // 
            CurrentHotkeySpamLabelStatic.AutoSize = true;
            CurrentHotkeySpamLabelStatic.Location = new Point(15, 595);
            CurrentHotkeySpamLabelStatic.Margin = new Padding(6, 0, 6, 0);
            CurrentHotkeySpamLabelStatic.Name = "CurrentHotkeySpamLabelStatic";
            CurrentHotkeySpamLabelStatic.Size = new Size(182, 32);
            CurrentHotkeySpamLabelStatic.TabIndex = 9;
            CurrentHotkeySpamLabelStatic.Text = "Current Hotkey:";
            // 
            // CurrentHotkeySpamLabel
            // 
            CurrentHotkeySpamLabel.AutoSize = true;
            CurrentHotkeySpamLabel.Location = new Point(195, 595);
            CurrentHotkeySpamLabel.Margin = new Padding(6, 0, 6, 0);
            CurrentHotkeySpamLabel.Name = "CurrentHotkeySpamLabel";
            CurrentHotkeySpamLabel.Size = new Size(118, 32);
            CurrentHotkeySpamLabel.TabIndex = 8;
            CurrentHotkeySpamLabel.Text = "None set!";
            CurrentHotkeySpamLabel.Click += CurrentHotkeySpamLabel_Click;
            // 
            // SetHotkeyButton
            // 
            SetHotkeyButton.Location = new Point(11, 516);
            SetHotkeyButton.Margin = new Padding(6);
            SetHotkeyButton.Name = "SetHotkeyButton";
            SetHotkeyButton.Size = new Size(139, 49);
            SetHotkeyButton.TabIndex = 7;
            SetHotkeyButton.Text = "Set Hotkey";
            SetHotkeyButton.UseVisualStyleBackColor = true;
            SetHotkeyButton.Click += SetHotkeyButton_Click;
            // 
            // HotkeySpamLabel
            // 
            HotkeySpamLabel.AutoSize = true;
            HotkeySpamLabel.Location = new Point(11, 478);
            HotkeySpamLabel.Margin = new Padding(6, 0, 6, 0);
            HotkeySpamLabel.Name = "HotkeySpamLabel";
            HotkeySpamLabel.Size = new Size(90, 32);
            HotkeySpamLabel.TabIndex = 6;
            HotkeySpamLabel.Text = "Hotkey";
            // 
            // RepetitionsSpamTextbox
            // 
            RepetitionsSpamTextbox.Location = new Point(11, 390);
            RepetitionsSpamTextbox.Margin = new Padding(6);
            RepetitionsSpamTextbox.Name = "RepetitionsSpamTextbox";
            RepetitionsSpamTextbox.Size = new Size(403, 39);
            RepetitionsSpamTextbox.TabIndex = 5;
            // 
            // RepeatSpamLabel
            // 
            RepeatSpamLabel.AutoSize = true;
            RepeatSpamLabel.Location = new Point(11, 352);
            RepeatSpamLabel.Margin = new Padding(6, 0, 6, 0);
            RepeatSpamLabel.Name = "RepeatSpamLabel";
            RepeatSpamLabel.Size = new Size(133, 32);
            RepeatSpamLabel.TabIndex = 4;
            RepeatSpamLabel.Text = "Repetitions";
            // 
            // DelaySpamTextBox
            // 
            DelaySpamTextBox.Location = new Point(11, 252);
            DelaySpamTextBox.Margin = new Padding(6);
            DelaySpamTextBox.Name = "DelaySpamTextBox";
            DelaySpamTextBox.Size = new Size(169, 39);
            DelaySpamTextBox.TabIndex = 3;
            // 
            // DelaySpamLabel
            // 
            DelaySpamLabel.AutoSize = true;
            DelaySpamLabel.Location = new Point(11, 213);
            DelaySpamLabel.Margin = new Padding(6, 0, 6, 0);
            DelaySpamLabel.Name = "DelaySpamLabel";
            DelaySpamLabel.Size = new Size(139, 32);
            DelaySpamLabel.TabIndex = 2;
            DelaySpamLabel.Text = "Delay in ms";
            // 
            // WhatToSpamLabel
            // 
            WhatToSpamLabel.AutoSize = true;
            WhatToSpamLabel.Location = new Point(11, 85);
            WhatToSpamLabel.Margin = new Padding(6, 0, 6, 0);
            WhatToSpamLabel.Name = "WhatToSpamLabel";
            WhatToSpamLabel.Size = new Size(178, 32);
            WhatToSpamLabel.TabIndex = 1;
            WhatToSpamLabel.Text = "What to spam...";
            // 
            // SpamTextBox
            // 
            SpamTextBox.AllowDrop = true;
            SpamTextBox.ForeColor = SystemColors.MenuText;
            SpamTextBox.Location = new Point(11, 124);
            SpamTextBox.Margin = new Padding(6);
            SpamTextBox.Name = "SpamTextBox";
            SpamTextBox.Size = new Size(403, 39);
            SpamTextBox.TabIndex = 0;
            SpamTextBox.TextChanged += SpamTextBox_TextChanged;
            // 
            // TabPagePyramid
            // 
            TabPagePyramid.Controls.Add(PyramidHeaderLabel);
            TabPagePyramid.Controls.Add(CurrentHotkeyPyramidLabel);
            TabPagePyramid.Controls.Add(CurrentHotkeyPyramidLabelStatic);
            TabPagePyramid.Controls.Add(ResetHotkeyButtonPyramid);
            TabPagePyramid.Controls.Add(SetHotkeyButtonPyramid);
            TabPagePyramid.Controls.Add(HotkeyPyramidLabel);
            TabPagePyramid.Controls.Add(NonVIPModeCheckboxPyramid);
            TabPagePyramid.Controls.Add(DelayPyramidTextbox);
            TabPagePyramid.Controls.Add(PyramidDelayLabel);
            TabPagePyramid.Controls.Add(PyramidWidthLabel);
            TabPagePyramid.Controls.Add(PyramidWidthNumeric);
            TabPagePyramid.Controls.Add(PyramidEmoteTextbox);
            TabPagePyramid.Controls.Add(PyramidEmoteTextboxLabel);
            TabPagePyramid.Location = new Point(8, 46);
            TabPagePyramid.Margin = new Padding(6);
            TabPagePyramid.Name = "TabPagePyramid";
            TabPagePyramid.Padding = new Padding(6);
            TabPagePyramid.Size = new Size(485, 769);
            TabPagePyramid.TabIndex = 1;
            TabPagePyramid.Text = "Pyramid";
            TabPagePyramid.UseVisualStyleBackColor = true;
            // 
            // PyramidHeaderLabel
            // 
            PyramidHeaderLabel.AutoSize = true;
            PyramidHeaderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            PyramidHeaderLabel.Location = new Point(15, 6);
            PyramidHeaderLabel.Margin = new Padding(6, 0, 6, 0);
            PyramidHeaderLabel.Name = "PyramidHeaderLabel";
            PyramidHeaderLabel.Size = new Size(228, 45);
            PyramidHeaderLabel.TabIndex = 12;
            PyramidHeaderLabel.Text = "Auto Pyramid";
            // 
            // CurrentHotkeyPyramidLabel
            // 
            CurrentHotkeyPyramidLabel.AutoSize = true;
            CurrentHotkeyPyramidLabel.Location = new Point(195, 595);
            CurrentHotkeyPyramidLabel.Margin = new Padding(6, 0, 6, 0);
            CurrentHotkeyPyramidLabel.Name = "CurrentHotkeyPyramidLabel";
            CurrentHotkeyPyramidLabel.Size = new Size(118, 32);
            CurrentHotkeyPyramidLabel.TabIndex = 11;
            CurrentHotkeyPyramidLabel.Text = "None set!";
            // 
            // CurrentHotkeyPyramidLabelStatic
            // 
            CurrentHotkeyPyramidLabelStatic.AutoSize = true;
            CurrentHotkeyPyramidLabelStatic.Location = new Point(15, 595);
            CurrentHotkeyPyramidLabelStatic.Margin = new Padding(6, 0, 6, 0);
            CurrentHotkeyPyramidLabelStatic.Name = "CurrentHotkeyPyramidLabelStatic";
            CurrentHotkeyPyramidLabelStatic.Size = new Size(182, 32);
            CurrentHotkeyPyramidLabelStatic.TabIndex = 10;
            CurrentHotkeyPyramidLabelStatic.Text = "Current Hotkey:";
            // 
            // ResetHotkeyButtonPyramid
            // 
            ResetHotkeyButtonPyramid.Location = new Point(162, 516);
            ResetHotkeyButtonPyramid.Margin = new Padding(6);
            ResetHotkeyButtonPyramid.Name = "ResetHotkeyButtonPyramid";
            ResetHotkeyButtonPyramid.Size = new Size(162, 49);
            ResetHotkeyButtonPyramid.TabIndex = 9;
            ResetHotkeyButtonPyramid.Text = "Reset Hotkey";
            ResetHotkeyButtonPyramid.UseVisualStyleBackColor = true;
            // 
            // SetHotkeyButtonPyramid
            // 
            SetHotkeyButtonPyramid.Location = new Point(11, 516);
            SetHotkeyButtonPyramid.Margin = new Padding(6);
            SetHotkeyButtonPyramid.Name = "SetHotkeyButtonPyramid";
            SetHotkeyButtonPyramid.Size = new Size(139, 49);
            SetHotkeyButtonPyramid.TabIndex = 8;
            SetHotkeyButtonPyramid.Text = "Set Hotkey";
            SetHotkeyButtonPyramid.UseVisualStyleBackColor = true;
            SetHotkeyButtonPyramid.Click += SetHotkeyButtonPyramid_Click;
            // 
            // HotkeyPyramidLabel
            // 
            HotkeyPyramidLabel.AutoSize = true;
            HotkeyPyramidLabel.Location = new Point(11, 478);
            HotkeyPyramidLabel.Margin = new Padding(6, 0, 6, 0);
            HotkeyPyramidLabel.Name = "HotkeyPyramidLabel";
            HotkeyPyramidLabel.Size = new Size(90, 32);
            HotkeyPyramidLabel.TabIndex = 7;
            HotkeyPyramidLabel.Text = "Hotkey";
            // 
            // NonVIPModeCheckboxPyramid
            // 
            NonVIPModeCheckboxPyramid.AutoSize = true;
            NonVIPModeCheckboxPyramid.Location = new Point(206, 260);
            NonVIPModeCheckboxPyramid.Margin = new Padding(6);
            NonVIPModeCheckboxPyramid.Name = "NonVIPModeCheckboxPyramid";
            NonVIPModeCheckboxPyramid.Size = new Size(222, 36);
            NonVIPModeCheckboxPyramid.TabIndex = 6;
            NonVIPModeCheckboxPyramid.Text = "I'm not VIP/Mod";
            NonVIPModeCheckboxPyramid.UseVisualStyleBackColor = true;
            NonVIPModeCheckboxPyramid.CheckedChanged += NonVIPModeCheckboxPyramid_CheckedChanged;
            // 
            // DelayPyramidTextbox
            // 
            DelayPyramidTextbox.Location = new Point(11, 252);
            DelayPyramidTextbox.Margin = new Padding(6);
            DelayPyramidTextbox.Name = "DelayPyramidTextbox";
            DelayPyramidTextbox.Size = new Size(169, 39);
            DelayPyramidTextbox.TabIndex = 5;
            DelayPyramidTextbox.TextChanged += DelayPyramidTextbox_TextChanged;
            // 
            // PyramidDelayLabel
            // 
            PyramidDelayLabel.AutoSize = true;
            PyramidDelayLabel.Location = new Point(11, 213);
            PyramidDelayLabel.Margin = new Padding(6, 0, 6, 0);
            PyramidDelayLabel.Name = "PyramidDelayLabel";
            PyramidDelayLabel.Size = new Size(139, 32);
            PyramidDelayLabel.TabIndex = 4;
            PyramidDelayLabel.Text = "Delay in ms";
            // 
            // PyramidWidthLabel
            // 
            PyramidWidthLabel.AutoSize = true;
            PyramidWidthLabel.Location = new Point(11, 352);
            PyramidWidthLabel.Margin = new Padding(6, 0, 6, 0);
            PyramidWidthLabel.Name = "PyramidWidthLabel";
            PyramidWidthLabel.Size = new Size(166, 32);
            PyramidWidthLabel.TabIndex = 3;
            PyramidWidthLabel.Text = "Pyramid width";
            // 
            // PyramidWidthNumeric
            // 
            PyramidWidthNumeric.Location = new Point(15, 390);
            PyramidWidthNumeric.Margin = new Padding(6);
            PyramidWidthNumeric.Name = "PyramidWidthNumeric";
            PyramidWidthNumeric.Size = new Size(156, 39);
            PyramidWidthNumeric.TabIndex = 2;
            PyramidWidthNumeric.ValueChanged += PyramidWidthNumeric_ValueChanged;
            // 
            // PyramidEmoteTextbox
            // 
            PyramidEmoteTextbox.Location = new Point(11, 124);
            PyramidEmoteTextbox.Margin = new Padding(6);
            PyramidEmoteTextbox.Name = "PyramidEmoteTextbox";
            PyramidEmoteTextbox.Size = new Size(403, 39);
            PyramidEmoteTextbox.TabIndex = 1;
            PyramidEmoteTextbox.TextChanged += PyramidEmoteTextbox_TextChanged;
            // 
            // PyramidEmoteTextboxLabel
            // 
            PyramidEmoteTextboxLabel.AutoSize = true;
            PyramidEmoteTextboxLabel.Location = new Point(11, 85);
            PyramidEmoteTextboxLabel.Margin = new Padding(4, 0, 4, 0);
            PyramidEmoteTextboxLabel.Name = "PyramidEmoteTextboxLabel";
            PyramidEmoteTextboxLabel.Size = new Size(253, 32);
            PyramidEmoteTextboxLabel.TabIndex = 0;
            PyramidEmoteTextboxLabel.Text = "Make a pyramid with...";
            // 
            // TabPageCopypasta
            // 
            TabPageCopypasta.Controls.Add(CurrentHotkeyCopypastaLabel);
            TabPageCopypasta.Controls.Add(CurrentHotkeyCopypastaLabelStatic);
            TabPageCopypasta.Controls.Add(ResetHotkeyButtonCopypasta);
            TabPageCopypasta.Controls.Add(SetHotkeyButtonCopypasta);
            TabPageCopypasta.Controls.Add(HotkeyLabelCopypasta);
            TabPageCopypasta.Controls.Add(DeleteSelectedCopypastaButton);
            TabPageCopypasta.Controls.Add(AddNewCopypastaButton);
            TabPageCopypasta.Controls.Add(CopypastaPreviewLabel);
            TabPageCopypasta.Controls.Add(CopyPastaPreviewRichTextbox);
            TabPageCopypasta.Controls.Add(SavedCopypastasLabel);
            TabPageCopypasta.Controls.Add(CopypastaComboBox);
            TabPageCopypasta.Controls.Add(CopypastaHeaderLabel);
            TabPageCopypasta.Location = new Point(8, 46);
            TabPageCopypasta.Margin = new Padding(6);
            TabPageCopypasta.Name = "TabPageCopypasta";
            TabPageCopypasta.Padding = new Padding(6);
            TabPageCopypasta.Size = new Size(485, 769);
            TabPageCopypasta.TabIndex = 2;
            TabPageCopypasta.Text = "Copypasta";
            TabPageCopypasta.UseVisualStyleBackColor = true;
            // 
            // CurrentHotkeyCopypastaLabel
            // 
            CurrentHotkeyCopypastaLabel.AutoSize = true;
            CurrentHotkeyCopypastaLabel.Location = new Point(195, 595);
            CurrentHotkeyCopypastaLabel.Margin = new Padding(6, 0, 6, 0);
            CurrentHotkeyCopypastaLabel.Name = "CurrentHotkeyCopypastaLabel";
            CurrentHotkeyCopypastaLabel.Size = new Size(118, 32);
            CurrentHotkeyCopypastaLabel.TabIndex = 11;
            CurrentHotkeyCopypastaLabel.Text = "None set!";
            // 
            // CurrentHotkeyCopypastaLabelStatic
            // 
            CurrentHotkeyCopypastaLabelStatic.AutoSize = true;
            CurrentHotkeyCopypastaLabelStatic.Location = new Point(15, 595);
            CurrentHotkeyCopypastaLabelStatic.Margin = new Padding(6, 0, 6, 0);
            CurrentHotkeyCopypastaLabelStatic.Name = "CurrentHotkeyCopypastaLabelStatic";
            CurrentHotkeyCopypastaLabelStatic.Size = new Size(182, 32);
            CurrentHotkeyCopypastaLabelStatic.TabIndex = 10;
            CurrentHotkeyCopypastaLabelStatic.Text = "Current Hotkey:";
            // 
            // ResetHotkeyButtonCopypasta
            // 
            ResetHotkeyButtonCopypasta.Location = new Point(162, 516);
            ResetHotkeyButtonCopypasta.Margin = new Padding(6);
            ResetHotkeyButtonCopypasta.Name = "ResetHotkeyButtonCopypasta";
            ResetHotkeyButtonCopypasta.Size = new Size(162, 49);
            ResetHotkeyButtonCopypasta.TabIndex = 9;
            ResetHotkeyButtonCopypasta.Text = "Reset Hotkey";
            ResetHotkeyButtonCopypasta.UseVisualStyleBackColor = true;
            ResetHotkeyButtonCopypasta.Click += ResetHotkeyButtonCopypasta_Click;
            // 
            // SetHotkeyButtonCopypasta
            // 
            SetHotkeyButtonCopypasta.Location = new Point(11, 516);
            SetHotkeyButtonCopypasta.Margin = new Padding(6);
            SetHotkeyButtonCopypasta.Name = "SetHotkeyButtonCopypasta";
            SetHotkeyButtonCopypasta.Size = new Size(139, 49);
            SetHotkeyButtonCopypasta.TabIndex = 8;
            SetHotkeyButtonCopypasta.Text = "Set Hotkey";
            SetHotkeyButtonCopypasta.UseVisualStyleBackColor = true;
            SetHotkeyButtonCopypasta.Click += SetHotkeyButtonCopypasta_Click;
            // 
            // HotkeyLabelCopypasta
            // 
            HotkeyLabelCopypasta.AutoSize = true;
            HotkeyLabelCopypasta.Location = new Point(11, 480);
            HotkeyLabelCopypasta.Margin = new Padding(6, 0, 6, 0);
            HotkeyLabelCopypasta.Name = "HotkeyLabelCopypasta";
            HotkeyLabelCopypasta.Size = new Size(90, 32);
            HotkeyLabelCopypasta.TabIndex = 7;
            HotkeyLabelCopypasta.Text = "Hotkey";
            // 
            // DeleteSelectedCopypastaButton
            // 
            DeleteSelectedCopypastaButton.Location = new Point(6, 702);
            DeleteSelectedCopypastaButton.Margin = new Padding(6);
            DeleteSelectedCopypastaButton.Name = "DeleteSelectedCopypastaButton";
            DeleteSelectedCopypastaButton.Size = new Size(301, 49);
            DeleteSelectedCopypastaButton.TabIndex = 6;
            DeleteSelectedCopypastaButton.Text = "Delete selected copypasta";
            DeleteSelectedCopypastaButton.UseVisualStyleBackColor = true;
            DeleteSelectedCopypastaButton.Click += DeleteSelectedCopypastaButton_Click;
            // 
            // AddNewCopypastaButton
            // 
            AddNewCopypastaButton.Location = new Point(6, 640);
            AddNewCopypastaButton.Margin = new Padding(6);
            AddNewCopypastaButton.Name = "AddNewCopypastaButton";
            AddNewCopypastaButton.Size = new Size(240, 49);
            AddNewCopypastaButton.TabIndex = 5;
            AddNewCopypastaButton.Text = "Add new Copypasta";
            AddNewCopypastaButton.UseVisualStyleBackColor = true;
            AddNewCopypastaButton.Click += AddNewCopypastaButton_Click;
            // 
            // CopypastaPreviewLabel
            // 
            CopypastaPreviewLabel.AutoSize = true;
            CopypastaPreviewLabel.Location = new Point(11, 173);
            CopypastaPreviewLabel.Margin = new Padding(6, 0, 6, 0);
            CopypastaPreviewLabel.Name = "CopypastaPreviewLabel";
            CopypastaPreviewLabel.Size = new Size(96, 32);
            CopypastaPreviewLabel.TabIndex = 4;
            CopypastaPreviewLabel.Text = "Preview";
            // 
            // CopyPastaPreviewRichTextbox
            // 
            CopyPastaPreviewRichTextbox.Location = new Point(15, 211);
            CopyPastaPreviewRichTextbox.Margin = new Padding(6);
            CopyPastaPreviewRichTextbox.Name = "CopyPastaPreviewRichTextbox";
            CopyPastaPreviewRichTextbox.ReadOnly = true;
            CopyPastaPreviewRichTextbox.Size = new Size(457, 258);
            CopyPastaPreviewRichTextbox.TabIndex = 3;
            CopyPastaPreviewRichTextbox.Text = "";
            // 
            // SavedCopypastasLabel
            // 
            SavedCopypastasLabel.AutoSize = true;
            SavedCopypastasLabel.Location = new Point(11, 75);
            SavedCopypastasLabel.Margin = new Padding(6, 0, 6, 0);
            SavedCopypastasLabel.Name = "SavedCopypastasLabel";
            SavedCopypastasLabel.Size = new Size(196, 32);
            SavedCopypastasLabel.TabIndex = 2;
            SavedCopypastasLabel.Text = "Select Copypasta";
            // 
            // CopypastaComboBox
            // 
            CopypastaComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CopypastaComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            CopypastaComboBox.FormattingEnabled = true;
            CopypastaComboBox.Location = new Point(15, 113);
            CopypastaComboBox.Margin = new Padding(6);
            CopypastaComboBox.Name = "CopypastaComboBox";
            CopypastaComboBox.Size = new Size(457, 40);
            CopypastaComboBox.TabIndex = 1;
            CopypastaComboBox.SelectedIndexChanged += CopypastaComboBox_SelectedIndexChanged;
            // 
            // CopypastaHeaderLabel
            // 
            CopypastaHeaderLabel.AutoSize = true;
            CopypastaHeaderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            CopypastaHeaderLabel.Location = new Point(15, 6);
            CopypastaHeaderLabel.Margin = new Padding(6, 0, 6, 0);
            CopypastaHeaderLabel.Name = "CopypastaHeaderLabel";
            CopypastaHeaderLabel.Size = new Size(177, 45);
            CopypastaHeaderLabel.TabIndex = 0;
            CopypastaHeaderLabel.Text = "Copypasta";
            // 
            // Chatter
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 875);
            Controls.Add(MainTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MaximumSize = new Size(572, 946);
            MinimumSize = new Size(572, 946);
            Name = "Chatter";
            Text = "Chatter";
            MainTabControl.ResumeLayout(false);
            TabPageSpammer.ResumeLayout(false);
            TabPageSpammer.PerformLayout();
            TabPagePyramid.ResumeLayout(false);
            TabPagePyramid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PyramidWidthNumeric).EndInit();
            TabPageCopypasta.ResumeLayout(false);
            TabPageCopypasta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage TabPageSpammer;
        private TabPage TabPagePyramid;
        private TabPage TabPageCopypasta;
        private TextBox SpamTextBox;
        private TextBox DelaySpamTextBox;
        private Label DelaySpamLabel;
        private Label WhatToSpamLabel;
        private Label RepeatSpamLabel;
        private Label HotkeySpamLabel;
        private TextBox RepetitionsSpamTextbox;
        private Label CurrentHotkeySpamLabelStatic;
        private Label CurrentHotkeySpamLabel;
        private Button SetHotkeyButton;
        private Button ResetHotkeyButtonSpam;
        private Label PyramidEmoteTextboxLabel;
        private TextBox PyramidEmoteTextbox;
        private Label PyramidWidthLabel;
        private NumericUpDown PyramidWidthNumeric;
        private CheckBox NonVIPMoodeCheckboxSpammer;
        private Label PyramidDelayLabel;
        private TextBox DelayPyramidTextbox;
        private CheckBox NonVIPModeCheckboxPyramid;
        private Button ResetHotkeyButtonPyramid;
        private Button SetHotkeyButtonPyramid;
        private Label HotkeyPyramidLabel;
        private Label CurrentHotkeyPyramidLabelStatic;
        private Label CurrentHotkeyPyramidLabel;
        private Label SpammerHeaderLabel;
        private Label PyramidHeaderLabel;
        private ComboBox CopypastaComboBox;
        private Label CopypastaHeaderLabel;
        private Label CopypastaPreviewLabel;
        private RichTextBox CopyPastaPreviewRichTextbox;
        private Label SavedCopypastasLabel;
        private Button DeleteSelectedCopypastaButton;
        private Button AddNewCopypastaButton;
        private Button ResetHotkeyButtonCopypasta;
        private Button SetHotkeyButtonCopypasta;
        private Label HotkeyLabelCopypasta;
        private Label CurrentHotkeyCopypastaLabelStatic;
        private Label CurrentHotkeyCopypastaLabel;
    }
}