using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileV6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fileExtensionComboBox.Items.Add("exe");
            fileExtensionComboBox.Items.Add("txt");
            fileExtensionComboBox.Items.Add("doc");
            fileExtensionComboBox.Items.Add("docx");
            fileExtensionComboBox.Items.Add("pdf");
            fileExtensionComboBox.Items.Add("zip");
            fileExtensionComboBox.Items.Add("rar");
            fileExtensionComboBox.Items.Add("jpg");
            fileExtensionComboBox.Items.Add("py");


        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathRichTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void opentPathButton_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

     

        private void fileExtensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedExtensionState = fileExtensionComboBox.SelectedItem.ToString();
        }

        private void clearListBoxButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            filePathRichTextBox.Text = "";
            filesFoundRichTextBox.Text = "";
            filesList.Clear();
        }

        private static List<string> filesList = new List<string>();
    }
}
