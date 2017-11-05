using LayoutProject.program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.program;
using WindowsFormsApp1.Properties;


namespace LayoutProject
{
    public partial class PathForm : Form, InitiatorCallBack
    {
        //checkers params
        private static bool removeWrongTvKeys;
        private static string xmlPathStr;
        internal static string remotePicPath;
        internal static bool startOver;
        private static string validationBtnName;
        private static string undoBtnName;
        internal static bool toCompress;

        public PathForm()
        {
            setInstances();
            InitializeComponent();
            setValidationCBItems();
            LoadPreviousParams();

        }

        private void LoadPreviousParams()
        {
            apiKeyTB.Text = Settings.Default.APIKey;
            pythonPathTB.Text = Settings.Default.PythonPath;
            xmlPathTB.Text = Settings.Default.xmlPath;
            remotePathTB.Text = Settings.Default.remotePath;
            validationBtnCB.Text = Settings.Default.validationBtn;
            tinyPngCompressionCB.Checked = Settings.Default.tinyPngBox;

        }


        private void setInstances()
        {
            initiator = new Initiator(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void compressPic()
        {
            PicCompressor picCompressor = new PicCompressor();
            picCompressor.compressPic(pythonPathTB.Text, apiKeyTB.Text, remotePicPath);
        }

        internal static string GetXmlPath()
        {
            return xmlPathStr;
        }

        internal static string getRemotePicPath()
        {
            return remotePicPath;
        }


        private void Browse_Xml_Path_clicked(object sender, EventArgs e)
        {
            xmlPathDialog.ShowDialog();
        }

        private void Browse_Remote_Pic_Path_clicked(object sender, EventArgs e)
        {
            remotePicDialog.ShowDialog();
        }

        private void remotePicDialog_FileOk(object sender, CancelEventArgs e)
        {
            remotePathTB.Text = TitleExporter(sender.ToString());
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            xmlPathTB.Text = TitleExporter(sender.ToString());
        }

        private string TitleExporter(string fileLongStr)
        {
            return fileLongStr.ToString().Substring(fileLongStr.ToString().IndexOf("FileName: ") + 10);

        }

        public static string GetValidationBtnName()
        {
            return validationBtnName;
        }

        public static bool GetRunOver()
        {
            return startOver;
        }

        private void LinkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Logger.GetTxt());
        }

        public static bool RemoveWrongTvKeys { get => removeWrongTvKeys; set => removeWrongTvKeys = value; }
        public static string UndoBtnName { get => undoBtnName; set => undoBtnName = value; }

        private void XmlPathTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void tinyPngCompressionCB_CheckedChanged(object sender, EventArgs e)
        {
            tinyPngCB.Enabled = tinyPngCompressionCB.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pythonPathDialog.ShowDialog();
        }

        private void pythonPathDialog_FileOk(object sender, CancelEventArgs e)
        {
            pythonPathTB.Text = TitleExporter(sender.ToString());
        }

        private void pythonPathTB_TextChanged(object sender, EventArgs e)
        {

        }

        public void onFileMade()
        {
            if (toCompress) compressPic();
            Console.WriteLine("done!");
            Application.Exit();
            Environment.Exit(1);
        }

        private void Go_Click(object sender, EventArgs e)
        {
            xmlPathStr = xmlPathTB.Text;
            SaveParams();
            toCompress = tinyPngCompressionCB.Checked;
            remotePicPath = remotePathTB.Text;
            if (validationBtnCB.SelectedItem != null)
                validationBtnName = validationBtnCB.SelectedItem.ToString();

            if (!xmlPathTB.Text.Equals(""))
                initiator.RunPath(xmlPathStr, remotePicPath);
            else if (xmlPathTB.Text.Equals("") && toCompress)
                compressPic();
        }

        private void SaveParams()
        {
            Settings.Default.Upgrade();
            Settings.Default.xmlPath = xmlPathTB.Text;
            Settings.Default.remotePath = remotePathTB.Text;
            Settings.Default.validationBtn = validationBtnCB.Text;
            Settings.Default.tinyPngBox = tinyPngCompressionCB.Checked;
            Settings.Default.Save();
        }
    }
}
