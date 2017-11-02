using System;
using System.Windows.Forms;
using WindowsFormsApp1.program.tools;
using LayoutProject.program;
namespace LayoutProject
{
    partial class PathForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Initiator initiator;
    
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.goBtn = new System.Windows.Forms.Button();
            this.xmlPathTB = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.remotePathTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xmlPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.XmlBrowseBtn = new System.Windows.Forms.Button();
            this.RemotePicBrowseBtn = new System.Windows.Forms.Button();
            this.remotePicDialog = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tinyPngCB = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.apiKeyTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pythonPathTB = new System.Windows.Forms.TextBox();
            this.tinyPngCompressionCB = new System.Windows.Forms.CheckBox();
            this.pythonPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.validationCB = new System.Windows.Forms.ComboBox();
            this.tinyPngCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(203, 277);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 35);
            this.goBtn.TabIndex = 0;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.Go_Click);
            // 
            // xmlPathTB
            // 
            this.xmlPathTB.AllowDrop = true;
            this.xmlPathTB.Location = new System.Drawing.Point(106, 16);
            this.xmlPathTB.Name = "xmlPathTB";
            this.xmlPathTB.Size = new System.Drawing.Size(274, 20);
            this.xmlPathTB.TabIndex = 1;
            this.xmlPathTB.TextChanged += new System.EventHandler(this.XmlPathTB_TextChanged);
            this.xmlPathTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.XmlPathDropHandler);
            this.xmlPathTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 19);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(54, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "XML Path";
            // 
            // remotePathTB
            // 
            this.remotePathTB.AllowDrop = true;
            this.remotePathTB.Location = new System.Drawing.Point(106, 46);
            this.remotePathTB.Name = "remotePathTB";
            this.remotePathTB.Size = new System.Drawing.Size(274, 20);
            this.remotePathTB.TabIndex = 3;
            this.remotePathTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.RemotePathDropHandler);
            this.remotePathTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remote Pic Path";
            // 
            // xmlPathDialog
            // 
            this.xmlPathDialog.FileName = "xmlPathDialog";
            this.xmlPathDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // XmlBrowseBtn
            // 
            this.XmlBrowseBtn.Location = new System.Drawing.Point(393, 16);
            this.XmlBrowseBtn.Name = "XmlBrowseBtn";
            this.XmlBrowseBtn.Size = new System.Drawing.Size(75, 20);
            this.XmlBrowseBtn.TabIndex = 5;
            this.XmlBrowseBtn.Text = "Browse...";
            this.XmlBrowseBtn.UseVisualStyleBackColor = true;
            this.XmlBrowseBtn.Click += new System.EventHandler(this.Browse_Xml_Path_clicked);
            // 
            // RemotePicBrowseBtn
            // 
            this.RemotePicBrowseBtn.Location = new System.Drawing.Point(393, 45);
            this.RemotePicBrowseBtn.Name = "RemotePicBrowseBtn";
            this.RemotePicBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.RemotePicBrowseBtn.TabIndex = 6;
            this.RemotePicBrowseBtn.Text = "Browse...";
            this.RemotePicBrowseBtn.UseVisualStyleBackColor = true;
            this.RemotePicBrowseBtn.Click += new System.EventHandler(this.Browse_Remote_Pic_Path_clicked);
            // 
            // remotePicDialog
            // 
            this.remotePicDialog.FileName = "openFileDialog1";
            this.remotePicDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.remotePicDialog_FileOk);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(445, 299);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LOG";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked_1);
            // 
            // tinyPngCB
            // 
            this.tinyPngCB.Controls.Add(this.button1);
            this.tinyPngCB.Controls.Add(this.label3);
            this.tinyPngCB.Controls.Add(this.apiKeyTB);
            this.tinyPngCB.Controls.Add(this.label2);
            this.tinyPngCB.Controls.Add(this.pythonPathTB);
            this.tinyPngCB.Enabled = false;
            this.tinyPngCB.Location = new System.Drawing.Point(15, 171);
            this.tinyPngCB.Name = "tinyPngCB";
            this.tinyPngCB.Size = new System.Drawing.Size(459, 100);
            this.tinyPngCB.TabIndex = 18;
            this.tinyPngCB.TabStop = false;
            this.tinyPngCB.Text = "Pic Compressor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "API Key";
            // 
            // apiKeyTB
            // 
            this.apiKeyTB.AllowDrop = true;
            this.apiKeyTB.Location = new System.Drawing.Point(123, 63);
            this.apiKeyTB.Name = "apiKeyTB";
            this.apiKeyTB.Size = new System.Drawing.Size(242, 20);
            this.apiKeyTB.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Python Path";
            // 
            // pythonPathTB
            // 
            this.pythonPathTB.AllowDrop = true;
            this.pythonPathTB.Location = new System.Drawing.Point(123, 26);
            this.pythonPathTB.Name = "pythonPathTB";
            this.pythonPathTB.Size = new System.Drawing.Size(242, 20);
            this.pythonPathTB.TabIndex = 20;
            this.pythonPathTB.TextChanged += new System.EventHandler(this.pythonPathTB_TextChanged);
            this.pythonPathTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.PythonPathDropHandler);
            this.pythonPathTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // tinyPngCompressionCB
            // 
            this.tinyPngCompressionCB.AutoSize = true;
            this.tinyPngCompressionCB.Location = new System.Drawing.Point(17, 148);
            this.tinyPngCompressionCB.Name = "tinyPngCompressionCB";
            this.tinyPngCompressionCB.Size = new System.Drawing.Size(147, 17);
            this.tinyPngCompressionCB.TabIndex = 19;
            this.tinyPngCompressionCB.Text = "Add tiny png compression";
            this.tinyPngCompressionCB.UseVisualStyleBackColor = true;
            this.tinyPngCompressionCB.CheckedChanged += new System.EventHandler(this.tinyPngCompressionCB_CheckedChanged);
            // 
            // pythonPathDialog
            // 
            this.pythonPathDialog.FileName = "pythonPathDialog";
            this.pythonPathDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pythonPathDialog_FileOk);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "*Optional";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "With Validation Button";
            // 
            // validationCB
            // 
            this.validationCB.FormattingEnabled = true;
            this.validationCB.Location = new System.Drawing.Point(135, 104);
            this.validationCB.Name = "validationCB";
            this.validationCB.Size = new System.Drawing.Size(242, 21);
            this.validationCB.TabIndex = 20;
            // 
            // PathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 324);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.validationCB);
            this.Controls.Add(this.tinyPngCompressionCB);
            this.Controls.Add(this.tinyPngCB);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.RemotePicBrowseBtn);
            this.Controls.Add(this.XmlBrowseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remotePathTB);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.xmlPathTB);
            this.Controls.Add(this.goBtn);
            this.Name = "PathForm";
            this.Text = "AC Layout Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tinyPngCB.ResumeLayout(false);
            this.tinyPngCB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RemotePathDropHandler(object sender, DragEventArgs e)
        {
            remotePathTB.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
        }

        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void XmlPathDropHandler(object sender, DragEventArgs e)
        {
            xmlPathTB.Text = ((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0];

            string[] fileData = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < fileData.Length; i++)
            {
                Console.WriteLine(fileData[i]);
            }
        }

        private void PythonPathDropHandler(object sender, DragEventArgs e)
        {
            pythonPathTB.Text = ((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0];

        }

        protected void setValidationCBItems()
        {
            foreach (string btnName in Enum.GetNames(typeof(VirtualKeyCode)))
                this.validationCB.Items.Add(btnName);
        }



        #endregion

        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.TextBox xmlPathTB;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox remotePathTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog xmlPathDialog;
        private System.Windows.Forms.Button XmlBrowseBtn;
        private System.Windows.Forms.Button RemotePicBrowseBtn;
        private System.Windows.Forms.OpenFileDialog remotePicDialog;
        private LinkLabel linkLabel1;
        private GroupBox tinyPngCB;
        private Label label3;
        private TextBox apiKeyTB;
        private Label label2;
        private TextBox pythonPathTB;
        internal CheckBox tinyPngCompressionCB;
        private Button button1;
        private OpenFileDialog pythonPathDialog;
        private Label label4;
        private Label label5;
        private ComboBox validationCB;
    }
}

