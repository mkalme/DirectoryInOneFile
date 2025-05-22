using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryInOneFile
{
    public partial class FileEditor : Form
    {
        public static string FileText = "";

        public FileEditor()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileText = richTextBox1.Text;

            Close();
        }

        private void FileEditor_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = FileText;
        }
    }
}
