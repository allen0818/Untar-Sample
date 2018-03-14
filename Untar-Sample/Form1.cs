using ICSharpCode.SharpZipLib.Tar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Untar_Sample
{
    public partial class Form1 : Form
    {
        private String _filePath = "";
        private String _outputFolder = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_ChooseFile_Click(object sender, EventArgs e)
        {
            string fileFilter = null;
            fileFilter = "TAR 檔(*.tar) |*.tar|" +
                "所有檔案(*.*) |*.*";
            OFDialog1.Filter = fileFilter;

            if (OFDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK)
            {
                _filePath = OFDialog1.FileName;
                TextBox_FilePath.Text = _filePath;

                FileInfo fileInfo = new FileInfo(_filePath);
                if (fileInfo != null && fileInfo.Exists)
                {
                    _outputFolder = fileInfo.DirectoryName;
                    TextBox_DestDir.Text = _outputFolder;
                }
            }
        }

        private void Button_SelectOutputDir_Click(object sender, EventArgs e)
        {
            if (FBDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK)
            {
                _outputFolder = FBDialog1.SelectedPath;
                TextBox_DestDir.Text = _outputFolder;
            }
        }

        private void Button_Extract_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_filePath))
            {
                MessageBox.Show("Please Select Source File First!", "Hint", MessageBoxButtons.OK);
                return;
            }

            if (String.IsNullOrEmpty(_outputFolder))
            {
                MessageBox.Show("Please Assign Output Folder First!", "Hint", MessageBoxButtons.OK);
                return;
            }

            ExtractTar(_filePath, _outputFolder);
        }

        public void ExtractTar(String tarFileName, String destFolder)
        {
            try
            {
                Stream inStream = File.OpenRead(tarFileName);

                TarArchive tarArchive = TarArchive.CreateInputTarArchive(inStream);
                tarArchive.ExtractContents(destFolder);
                tarArchive.Close();

                inStream.Close();
                MessageBox.Show("Extract Success!", "Information", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                String errMsg = String.Format("Extract Failed: {0} {1}", Environment.NewLine, ex.Message);
                MessageBox.Show(errMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
