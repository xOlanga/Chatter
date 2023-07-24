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
    public partial class HotkeyCaptureDialogPyramid : Form
    {
        public Keys CapturedHotkey { get; private set; }
        private bool keyPressed = false;

        public HotkeyCaptureDialogPyramid()
        {
            InitializeComponent();
            KeyPreview = true; // Set KeyPreview to true to capture key events
            KeyDown += HotkeyCaptureDialogPyramid_KeyDown;
            FormClosing += HotkeyCaptureDialogPyramid_FormClosing;
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

        private void HotkeyCaptureDialogPyramid_KeyDown(object? sender, KeyEventArgs e)
        {
            CapturedHotkey = e.KeyCode;
            capturedHotkeyLabelPyramid.Text = " Selected Key: " + e.KeyCode.ToString() + "\n Press ESC to save";

            keyPressed = true;
        }

        private void HotkeyCaptureDialogPyramid_FormClosing(object? sender, FormClosingEventArgs e)
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

        private void capturedHotkeyLabelPyramid_Click(object sender, EventArgs e)
        {

        }
    }
}