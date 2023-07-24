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
    public partial class HotkeyCaptureDialogSpam : Form
    {
        public Keys CapturedHotkey { get; private set; }
        private bool keyPressed = false;

        public HotkeyCaptureDialogSpam()
        {
            InitializeComponent();
            KeyPreview = true; // Set KeyPreview to true to capture key events
            KeyDown += HotkeyCaptureDialogSpam_KeyDown;
            FormClosing += HotkeyCaptureDialogSpam_FormClosing;

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

        private void HotkeyCaptureDialogSpam_KeyDown(object? sender, KeyEventArgs e)
        {
            CapturedHotkey = e.KeyCode;
            capturedHotkeyLabelSpam.Text = " Selected Key: " + e.KeyCode.ToString() + "\n Press ESC to save";

            keyPressed = true;
        }

        private void HotkeyCaptureDialogSpam_FormClosing(object? sender, FormClosingEventArgs e)
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


        private void HotkeyCaptureDialogSpam_Load(object sender, EventArgs e)
        {

        }
    }
}
