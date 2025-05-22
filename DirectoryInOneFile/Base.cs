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
using System.Diagnostics;
using System.IO;

namespace DirectoryInOneFile
{
    public partial class Base : Form
    {
        public static string BasePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\TestFile.xml";
        public static XmlDocument document = new XmlDocument();

        public static string[] Path = new string[] { };
        public static List<int> SelectedList = new List<int> { -1};

        public Base()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(BasePath)) {
                createBaseFile();
            }
            document.Load(BasePath);

            dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

            dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            timer1.Start();

            load_dataGridView();
        }

        private void load_dataGridView() {
            XmlNodeList directories = document.SelectNodes(getDirPath(Path) + "/directory");
            XmlNodeList files = document.SelectNodes(getDirPath(Path) + "/file");

            dataGridView1.Rows.Clear();

            for (int i = 0; i < directories.Count; i++) {
                dataGridView1.Rows.Add(Properties.Resources.folderImage, directories[i].Attributes["name"].Value, "", directories[i].Attributes["type"].Value, "1");
            }

            for (int i = 0; i < files.Count; i++) {
                dataGridView1.Rows.Add(Properties.Resources.fileImage, files[i].Attributes["name"].Value, getFileAttributes(getFilePath(getDirPath(Path), files[i].Attributes["name"].Value), "modifdate"), getFileType(files[i].Attributes["name"].Value) + "File", "0");
            }

            dataGridView1.ClearSelection();

            if (SelectedList[SelectedList.Count - 1] > -1) {
                dataGridView1.Rows[SelectedList[SelectedList.Count - 1]].Selected = true;
            }
        }

        private void createBaseFile() {
            XmlElement rootFolder = document.CreateElement("root");
            document.AppendChild(rootFolder);

            document.Save(BasePath);
        }

        private string getFileAttributes(string path, string attribute) {
            string att = "";

            if (attribute == "name")
            {
                att = document.SelectSingleNode(path).Attributes[attribute].Value.ToLower();
            }
            else {
                att = document.SelectSingleNode(path + "/" + attribute).InnerText;
            }

            return att;
        }

        private string getFileType(string name) {
            string type = "";
            string[] array = name.Split('.');

            if (array.Length > 1) {
                type = array[1].ToUpper() + " ";
            }

            return type;
        }

        private XmlNode getXmlNode(string path) {
            return document.SelectSingleNode(path);
        }

        private string getFilePath(string path, string name) {
            return path + "/file[@name='" + name + "']";
        }

        private string getDirPath(string[] directoryNames) {
            string path = "/root";

            for (int i = 0; i < directoryNames.Length; i++) {
                path += "/directory[@name='" + directoryNames[i] + "']";
            }

            return path;
        }

        private void appendXmlElement(string path, XmlElement element) {
            document.SelectSingleNode(path).AppendChild(element);
        }

        public XmlElement getNewFile(XmlDocument document, string name, string date, string type, string text) {
            XmlElement file = document.CreateElement("file");
            file.SetAttribute("name", name);

            XmlElement typeAttribute = document.CreateElement("type");
            typeAttribute.InnerText = type;
            file.AppendChild(typeAttribute);

            XmlElement modificationAttribute = document.CreateElement("modifdate"); //modification date
            modificationAttribute.InnerText = date;
            file.AppendChild(modificationAttribute);

            XmlElement textAttribute = document.CreateElement("text");
            textAttribute.InnerText = text;
            file.AppendChild(textAttribute);

            return file;
        }

        public XmlElement getNewDirectory(XmlDocument document, string name) {
            XmlElement directory = document.CreateElement("directory");
            directory.SetAttribute("name", name);
            directory.SetAttribute("type", "Folder");

            return directory;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedIndex = dataGridView1.SelectedRows[0].Index;

            XmlNode node = getXmlNode(getFilePath(getDirPath(Path), dataGridView1.Rows[SelectedIndex].Cells[1].Value.ToString()));

            if (getDataValue(4) == "0")
            {
                FileEditor fileEditor = new FileEditor();
                FileEditor.FileText = getFileAttributes(getFilePath(getDirPath(Path), getDataValue(1)), "text");
                fileEditor.ShowDialog();

                document.SelectSingleNode(getFilePath(getDirPath(Path), getDataValue(1)) + "/text").InnerText = FileEditor.FileText;

                document.Save(BasePath);
            }
            else if (getDataValue(4) == "1") {
                string[] tempPath = new string[Path.Length + 1];

                for (int i = 0; i < Path.Length; i++) {
                    tempPath[i] = Path[i];
                }
                tempPath[Path.Length] = dataGridView1.Rows[SelectedIndex].Cells[1].Value.ToString();

                Path = tempPath;

                SelectedList[SelectedList.Count - 1] = SelectedIndex;
                SelectedList.Add(-1);

                load_dataGridView();
            }
        }

        private void createDirectory(string path, string name) {
            appendXmlElement(path, getNewDirectory(document, name));
        }

        private void createFile(string path, string name, string date, string type) {
            appendXmlElement(path, getNewFile(document, name, date, type, ""));
        }

        private void newFileButton_Click(object sender, EventArgs e)
        {
            NewXmlElement newElement = new NewXmlElement();
            NewXmlElement.form = this;
            NewXmlElement.title = "New File";

            newElement.ShowDialog();

            if (!string.IsNullOrEmpty(NewXmlElement.XmlElementText) && !ifInvalidChar(NewXmlElement.XmlElementText)) {
                string[] tempArray = NewXmlElement.XmlElementText.Split('.');
                string type = tempArray.Length > 1 ? tempArray[1] : "";

                createFile(getDirPath(Path), NewXmlElement.XmlElementText, DateTime.Now.ToString("dd.MM.yyyy HH:mm"), type);
                document.Save(BasePath);

                load_dataGridView();
            }
        }

        private void newFolderButton_Click(object sender, EventArgs e)
        {
            NewXmlElement newElement = new NewXmlElement();
            NewXmlElement.form = this;
            NewXmlElement.title = "New Folder";

            newElement.ShowDialog();

            if (!string.IsNullOrEmpty(NewXmlElement.XmlElementText) && !ifInvalidChar(NewXmlElement.XmlElementText))
            {
                createDirectory(getDirPath(Path), NewXmlElement.XmlElementText);
                document.Save(BasePath);

                load_dataGridView();
            }
        }

        public bool ifInvalidChar(string text) {
            bool ifInvalid = false;

            char[] invalidChar = new char[] {'<', '>', '"', '\'', '&'};

            for (int i = 0; i < invalidChar.Length; i++) {
                if (text.Contains(invalidChar[i])) {
                    ifInvalid = true;

                    goto after_loop;
                }
            }
            after_loop:

            return ifInvalid;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (Path.Length > 0) {
                string[] tempPath = new string[Path.Length - 1];

                for (int i = 0; i < Path.Length - 1; i++){
                    tempPath[i] = Path[i];
                }

                Path = tempPath;

                SelectedList.RemoveAt(SelectedList.Count - 1);

                load_dataGridView();
            }
        }

        private string getDataValue(int col) {
            return dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[col].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?\t\t\t\t\t", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (getDataValue(4) == "1"){
                    document.SelectSingleNode(getDirPath(Path)).RemoveChild(document.SelectSingleNode(getDirPath(Path) + "/directory[@name='" + getDataValue(1) + "']"));

                    document.Save(BasePath);
                    load_dataGridView();
                }else if (getDataValue(4) == "0"){
                    document.SelectSingleNode(getDirPath(Path)).RemoveChild(document.SelectSingleNode(getFilePath(getDirPath(Path), getDataValue(1))));

                    document.Save(BasePath);
                    load_dataGridView();
                }
            }
        }

        private void convertFileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Convert convert = new Convert();
            Convert.form = this;
            convert.ShowDialog();

            if (Convert.ifSuccessful) {
                loadNewFile(Convert.fileName);
            }
        }

        private void openLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFile openFile = new OpenFile();
            openFile.ShowDialog();

            loadNewFile(OpenFile.fileName);
        }

        private void loadNewFile(string path) {
            document.Save(BasePath);

            document = new XmlDocument();
            BasePath = path;
            document.Load(BasePath);

            load_dataGridView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //back button
            if (Path.Length > 0) {
                backButton.Enabled = true;
            }
            else {
                backButton.Enabled = false;
            }

            //delete button
            if (dataGridView1.SelectedRows.Count > 0){
                deleteButton.Enabled = true;
            }
            else {
                deleteButton.Enabled = false;
            }
        }
    }
}
