using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace DirectoryInOneFile
{
    public partial class Convert : Form
    {
        private static XmlDocument document = new XmlDocument();
        public static Base form;
        public static string fileName = "";

        public static bool ifSuccessful = false;

        public Convert()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browseButton1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string folderToConvert = textBox1.Text;
            string newFilePath = textBox2.Text;

            //create initial document
            XmlElement rootFolder = document.CreateElement("root");
            document.AppendChild(rootFolder);

            convert(rootFolder, folderToConvert);

            document.Save(newFilePath);
            ifSuccessful = true;
            fileName = textBox2.Text;

            Close();
        }

        private void convert(XmlElement parentElement, string directory) {
            //append current directory
            XmlElement currentElement = form.getNewDirectory(document, Path.GetFileName(directory));
            parentElement.AppendChild(currentElement);

            //directories
            string[] subdirs = Directory.GetDirectories(directory);
            for (int i = 0; i < subdirs.Length; i++) {
                convert(currentElement, subdirs[i]);
            }

            //files
            FileInfo[] files = new DirectoryInfo(directory).GetFiles();
            for (int i = 0; i < files.Length; i++) {
                string[] tempArray = files[i].Name.Split('.');
                string type = tempArray.Length > 1 ? tempArray[1] : "";

                currentElement.AppendChild(form.getNewFile(document, files[i].Name, DateTime.Now.ToString("dd.MM.yyyy HH:mm"), type, File.ReadAllText(files[i].FullName)));                
            }
        }
    }
}
