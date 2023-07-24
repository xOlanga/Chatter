using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatter
{
    public partial class HotkeyCaptureDialogCopypasta : Form
    {
        public Keys CapturedHotkey { get; private set; }
        private bool keyPressed = false;

        public HotkeyCaptureDialogCopypasta()
        {
            InitializeComponent();
            KeyPreview = true; // Set KeyPreview to true to capture key events
            KeyDown += HotkeyCaptureDialogCopypasta_KeyDown;
            FormClosing += HotkeyCaptureDialogCopypasta_FormClosing;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                // Close the dialog when the Escape key is pressed
                Close();
                return true; // Set to true to prevent further processing of the Escape key
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void HotkeyCaptureDialogCopypasta_KeyDown(object? sender, KeyEventArgs e)
        {
            CapturedHotkey = e.KeyCode;
            capturedHotkeyLabelCopypasta.Text = " Selected Key: " + e.KeyCode.ToString() + "\n Press ESC to save";

            keyPressed = true;
        }

        private void HotkeyCaptureDialogCopypasta_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (keyPressed)
                {
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void capturedHotkeyLabelCopypasta_Click(object sender, EventArgs e)
        {

        }
    }
}
