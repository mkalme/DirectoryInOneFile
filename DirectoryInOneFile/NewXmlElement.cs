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
    public partial class NewXmlElement : Form
    {
        public static Base form;
        public static string title = "";
        public static string XmlElementText = "";

        public NewXmlElement()
        {
            InitializeComponent();
        }

        private void NewXmlElement_Load(object sender, EventArgs e)
        {
            Text = title;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !checkIfAlreadyExists(textBox1.Text)){
                doneButton.Enabled = true;
            }
            else {
                doneButton.Enabled = false;
            }
        }

        private bool checkIfAlreadyExists(string name) {
            bool ifExists = false;

            for (int i = 0; i < form.dataGridView1.RowCount; i++) {
                if (name.Equals(form.dataGridView1.Rows[i].Cells[0].Value.ToString())) {
                    ifExists = true;

                    goto after_loop;
                }
            }
            after_loop:

            return ifExists;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            XmlElementText = textBox1.Text;

            if (!string.IsNullOrEmpty(NewXmlElement.XmlElementText) && !form.ifInvalidChar(NewXmlElement.XmlElementText))
            {
                Close();
            }
        }
    }
}
