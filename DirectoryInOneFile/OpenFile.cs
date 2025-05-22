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
    public partial class OpenFile : Form
    {
        public static string fileName = "";

        public OpenFile()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox2.Text = openFileDialog1.FileName;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            fileName = textBox2.Text;

            Close();
        }
    }
}
