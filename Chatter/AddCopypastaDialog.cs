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
    public partial class AddCopypasta : Form
    {
        public string CopypastaTitle { get; private set; }
        public string CopypastaText { get; private set; }

        public AddCopypasta()
        {
            InitializeComponent();
        }

        private void SaveCopypastaButton_Click(object sender, EventArgs e)
        {
            // Check if both the title and text are provided
            if (string.IsNullOrWhiteSpace(AddCopypastaNameTextbox.Text) || string.IsNullOrWhiteSpace(AddCopypastaTextRichTextbox.Text))
            {
                MessageBox.Show("Please provide both the title and text for the copypasta.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the copypasta title and text
            CopypastaTitle = AddCopypastaNameTextbox.Text;
            CopypastaText = AddCopypastaTextRichTextbox.Text;

            // Set the dialog result to OK
            DialogResult = DialogResult.OK;

            // Close the form
            Close();

        }

        private void CancelCopypastaButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
