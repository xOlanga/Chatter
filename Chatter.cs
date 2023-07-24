using System.Diagnostics;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using Chatter;
using Newtonsoft.Json;
using System.IO;

namespace Chatter
{
    public partial class Chatter : Form
    {

        // Hotkey-related constants and functions from the Windows API
        private const string CopypastaFilePath = "copypastas.json";
        private List<Copypasta> copypastas = new List<Copypasta>();
        private const int WM_HOTKEY = 0x0312;
        private const uint MOD_HOTKEY = 0x4000; // MOD_NOREPEAT


        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        private static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("user32.dll")]
        private static extern bool CloseClipboard();

        [DllImport("user32.dll")]
        private static extern bool EmptyClipboard();

        [DllImport("user32.dll")]
        private static extern bool IsClipboardFormatAvailable(uint format);

        [DllImport("user32.dll")]
        private static extern IntPtr GetClipboardData(uint format);

        [DllImport("user32.dll")]
        private static extern IntPtr SetClipboardData(uint uFormat, IntPtr hMem);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GlobalAlloc(uint uFlags, UIntPtr dwBytes);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GlobalLock(IntPtr hMem);

        [DllImport("kernel32.dll")]
        private static extern bool GlobalUnlock(IntPtr hMem);

        [DllImport("kernel32.dll")]
        private static extern UIntPtr GlobalSize(IntPtr hMem);

        private const int CF_UNICODETEXT = 13;
        private const int GMEM_MOVEABLE = 0x0002;
        private const int GMEM_ZEROINIT = 0x0040;

        private const int MYACTION_HOTKEY_ID = 1;
        private const int PYRAMID_HOTKEY_ID = 2;
        private const int COPYPASTA_HOTKEY_ID = 3;


        public Chatter()
        {

            InitializeComponent();
            ResetHotkeyButtonPyramid.Click += ResetHotkeyButtonPyramid_Click;
            // Set default values Spammer
            DelaySpamTextBox.Text = "100";
            RepetitionsSpamTextbox.Text = "5";
            CurrentHotkeySpamLabel.Text = "Insert";
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, MOD_HOTKEY, Keys.Insert);
            // Set default values Pyramids
            PyramidWidthNumeric.Value = 3;
            DelayPyramidTextbox.Text = "100";
            CurrentHotkeyPyramidLabel.Text = "Delete";
            RegisterHotKey(this.Handle, PYRAMID_HOTKEY_ID, MOD_HOTKEY, Keys.Delete);
            // Set default values Copypasta
            CurrentHotkeyCopypastaLabel.Text = "End";
            RegisterHotKey(this.Handle, COPYPASTA_HOTKEY_ID, MOD_HOTKEY, Keys.End);




            LoadCopypastas();
            UpdateCopypastaComboBox();

        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    int hotkeyId = m.WParam.ToInt32();

                    if (m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
                    {
                        PerformSpamAction();
                    }
                    else if (hotkeyId == PYRAMID_HOTKEY_ID)
                    {
                        PerformPyramidAction();
                    }
                    else if (hotkeyId == COPYPASTA_HOTKEY_ID)
                    {
                        PerformCopypastaAction();
                    }
                    break;
            }

            base.WndProc(ref m);
        }

        private void SpamTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetHotkeyButton_Click(object sender, EventArgs e)
        {
            using (HotkeyCaptureDialogSpam hotkeyCaptureDialog = new HotkeyCaptureDialogSpam())
            {
                if (hotkeyCaptureDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the new hotkey from the dialog
                    Keys newHotkey = hotkeyCaptureDialog.CapturedHotkey;

                    // Unregister the previous hotkey
                    UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID);

                    // Register the new hotkey
                    RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, MOD_HOTKEY, newHotkey);

                    // Update the label to display the new hotkey
                    CurrentHotkeySpamLabel.Text = newHotkey.ToString();
                }
            }
        }

        private void CurrentHotkeySpamLabel_Click(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);



        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Unregister the hotkey when the form is closing
            UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID);
            UnregisterHotKey(this.Handle, PYRAMID_HOTKEY_ID);
            UnregisterHotKey(this.Handle, COPYPASTA_HOTKEY_ID);
            // Save the copypastas when the form is closing
            SaveCopypastas();



        }

        private void ResetHotkeyButtonSpam_Click(object sender, EventArgs e)
        {
            UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID);
            CurrentHotkeySpamLabel.Text = "None set!";
        }

        private void PerformSpamAction()
        {
            // Perform the hotkey action here
            string spamText = SpamTextBox.Text;
            int repetitions = int.Parse(RepetitionsSpamTextbox.Text);
            int delay = string.IsNullOrEmpty(DelaySpamTextBox.Text) ? 0 : int.Parse(DelaySpamTextBox.Text);

            // Check if the  text is empty
            if (string.IsNullOrEmpty(spamText))
            {
                MessageBox.Show("Little bro is trying spam air.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Store the text in the clipboard
            CopyTextToClipboard(spamText);

            for (int i = 0; i < repetitions; i++)
            {
                // Paste the text from the clipboard into Notepad
                PasteTextFromClipboard();

                // Press Enter
                SendKeys.Send("{Enter}");

                Thread.Sleep(delay);
            }

            EmptyClipboard();
        }

        private void CopyTextToClipboard(string text)
        {
            try
            {
                Clipboard.SetText(text);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur while setting the clipboard text
                MessageBox.Show($"Error copying text to clipboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasteTextFromClipboard()
        {
            string text = Clipboard.GetText();
            if (!string.IsNullOrEmpty(text))
            {


                // Send the text directly to the application using clipboard
                Clipboard.SetText(text);
                SendKeys.Send("^V"); // Simulate Ctrl+V to paste the text
            }
        }

        private void NonVIPMoodeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NonVIPMoodeCheckboxSpammer.Checked)
            {
                DelaySpamTextBox.Text = "1000";
                DelaySpamTextBox.Enabled = false;
            }
            else
            {
                DelaySpamTextBox.Text = "100";
                DelaySpamTextBox.Enabled = true;
            }
        }


        //-----------------Pyramid Tab-----------------------------
        private void SetHotkeyButtonPyramid_Click(object sender, EventArgs e)
        {
            using (HotkeyCaptureDialogPyramid hotkeyCaptureDialog = new HotkeyCaptureDialogPyramid())
            {
                if (hotkeyCaptureDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the new hotkey from the dialog
                    Keys newHotkey = hotkeyCaptureDialog.CapturedHotkey;

                    // Unregister the previous hotkey
                    UnregisterHotKey(this.Handle, PYRAMID_HOTKEY_ID);

                    // Register the new hotkey
                    RegisterHotKey(this.Handle, PYRAMID_HOTKEY_ID, MOD_HOTKEY, newHotkey);

                    // Update the label to display the new hotkey
                    CurrentHotkeyPyramidLabel.Text = newHotkey.ToString();
                }
            }
        }

        private void ResetHotkeyButtonPyramid_Click(object? sender, EventArgs e)
        {
            UnregisterHotKey(this.Handle, PYRAMID_HOTKEY_ID);
            CurrentHotkeyPyramidLabel.Text = "None set!";
        }

        private void PyramidEmoteTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DelayPyramidTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NonVIPModeCheckboxPyramid_CheckedChanged(object sender, EventArgs e)
        {
            if (NonVIPModeCheckboxPyramid.Checked)
            {
                DelayPyramidTextbox.Text = "1000";
                DelayPyramidTextbox.Enabled = false;
            }
            else
            {
                DelayPyramidTextbox.Text = "100";
                DelayPyramidTextbox.Enabled = true;
            }
        }

        private void PyramidWidthNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PerformPyramidAction()
        {
            // Perform the pyramid action
            string pyramidText = PyramidEmoteTextbox.Text;
            int pyramidWidth = (int)PyramidWidthNumeric.Value;
            int delayPyramid = string.IsNullOrEmpty(DelayPyramidTextbox.Text) ? 0 : int.Parse(DelayPyramidTextbox.Text);

            // Check if the pyramid emote text is empty
            if (string.IsNullOrEmpty(pyramidText))
            {
                MessageBox.Show("Little bro is trying to build a pyramid out of air.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate the pyramid lines
            List<string> pyramidLines = new List<string>();
            for (int i = 1; i <= pyramidWidth; i++)
            {
                string line = string.Join(" ", Enumerable.Repeat(pyramidText, i));
                pyramidLines.Add(line);
            }
            for (int i = pyramidWidth - 1; i >= 1; i--)
            {
                string line = string.Join(" ", Enumerable.Repeat(pyramidText, i));
                pyramidLines.Add(line);
            }

            // Copy and paste the pyramid lines
            foreach (string line in pyramidLines)
            {
                // Copy the line to clipboard
                CopyTextToClipboard(line);

                // Paste the line
                PasteTextFromClipboard();

                // Press Enter
                SendKeys.Send("{Enter}");

                Thread.Sleep(delayPyramid);
            }
        }

        //---------------------Pasta Tab--------------------------------
        private void SetHotkeyButtonCopypasta_Click(object sender, EventArgs e)
        {
            using (HotkeyCaptureDialogCopypasta hotkeyCaptureDialog = new HotkeyCaptureDialogCopypasta())
            {
                if (hotkeyCaptureDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the new hotkey from the dialog
                    Keys newHotkey = hotkeyCaptureDialog.CapturedHotkey;

                    // Unregister the previous hotkey
                    UnregisterHotKey(this.Handle, COPYPASTA_HOTKEY_ID);

                    // Register the new hotkey
                    RegisterHotKey(this.Handle, COPYPASTA_HOTKEY_ID, MOD_HOTKEY, newHotkey);

                    // Update the label to display the new hotkey
                    CurrentHotkeyCopypastaLabel.Text = newHotkey.ToString();
                }
            }
        }

        private void ResetHotkeyButtonCopypasta_Click(object sender, EventArgs e)
        {
            UnregisterHotKey(this.Handle, COPYPASTA_HOTKEY_ID);
            CurrentHotkeyCopypastaLabel.Text = "None set!";
        }

        private void AddNewCopypastaButton_Click(object? sender, EventArgs e)
        {
            using (AddCopypasta addCopypastaDialog = new AddCopypasta())
            {
                if (addCopypastaDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Copypasta object with the entered title and text
                    Copypasta newCopypasta = new Copypasta(addCopypastaDialog.CopypastaTitle, addCopypastaDialog.CopypastaText);

                    // Add the newCopypasta to the list of copypastas
                    copypastas.Add(newCopypasta);

                    // Update the CopypastaComboBox
                    UpdateCopypastaComboBox();

                    // Save the copypastas
                    SaveCopypastas();
                }
            }
        }

        private void UpdateCopypastaComboBox()
        {
            CopypastaComboBox.DataSource = null;
            CopypastaComboBox.DataSource = copypastas;
            CopypastaComboBox.DisplayMember = "Title";

        }

        private void CopypastaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CopypastaComboBox.SelectedItem is Copypasta selectedCopypasta)
            {
                CopyPastaPreviewRichTextbox.Text = selectedCopypasta.Text;
            }
            else
            {
                CopyPastaPreviewRichTextbox.Clear();
            }
        }

        private void DeleteSelectedCopypastaButton_Click(object sender, EventArgs e)
        {
            if (CopypastaComboBox.SelectedItem is Copypasta selectedCopypasta)
            {
                // Remove the selected copypasta from the list
                copypastas.Remove(selectedCopypasta);

                // Update the CopypastaComboBox
                UpdateCopypastaComboBox();

                // Clear the preview textbox
                CopyPastaPreviewRichTextbox.Clear();

                // Save the updated copypastas
                SaveCopypastas();
            }
        }

        private void SaveCopypastas()
        {
            // Create the CopypastaData object to store the copypastas
            CopypastaData copypastaData = new CopypastaData
            {
                Copypastas = copypastas.ToList()
            };

            // Serialize the copypastaData object to JSON
            string json = JsonConvert.SerializeObject(copypastaData, Newtonsoft.Json.Formatting.Indented);

            // Save the JSON to the copypasta file
            File.WriteAllText(CopypastaFilePath, json);
        }

        private void LoadCopypastas()
        {
            if (File.Exists(CopypastaFilePath))
            {
                // Read the JSON from the copypasta file
                string json = File.ReadAllText(CopypastaFilePath);

                // Deserialize the JSON to a CopypastaData object
                CopypastaData copypastaData = JsonConvert.DeserializeObject<CopypastaData>(json);

                if (copypastaData != null)
                {
                    // Update the copypastas list with the loaded copypastas
                    copypastas = copypastaData.Copypastas;
                }
            }
        }

        private void PerformCopypastaAction()
        {
            // Perform the hotkey action here
            string copypastaText = CopyPastaPreviewRichTextbox.Text;

            // Check if the  text is empty
            if (string.IsNullOrEmpty(copypastaText))
            {
                MessageBox.Show("Select a Copypasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Store the text in the clipboard
            CopyTextToClipboard(copypastaText);

            // Paste the text from the clipboard into Notepad
            PasteTextFromClipboard();

            // Press Enter
            SendKeys.Send("{Enter}");

            EmptyClipboard();
        }
    }
    public class Copypasta
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public Copypasta(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public override string ToString()
        {
            return Title;
        }
    }

    public class CopypastaData
    {
        public List<Copypasta> Copypastas { get; set; }
    }
}
