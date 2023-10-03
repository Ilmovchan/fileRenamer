using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileRenamer
{
    public partial class FileRenamer : Form
    {
        public FileRenamer()
        {
            InitializeComponent();
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {

            string originalDirectory = @"C:\Users\One\Documents\GitHub\fileRenamer\fileRenamer\fileRenamer\ScanFolder";
            string destinationDirectory = @"C:\Users\One\Documents\GitHub\fileRenamer\fileRenamer\fileRenamer\ScanFolder";

            if (OriginalFolderPath.Text != null) originalDirectory = OriginalFolderPath.Text;
            if (DestinationFolderPath.Text != null) destinationDirectory = DestinationFolderPath.Text;

            string originalName = OriginalNameField.Text;
            string newName = NewNameField.Text;

            string[] originalFileNames = Directory.GetFiles(originalDirectory);

            InfoField.Clear();

            InfoField.Text = originalDirectory + Directory.;
            InfoField.Text += originalDirectory;

            /*            foreach (string originalFilePath in originalFileNames)
                        {
                            if (originalFilePath.Contains(originalName))
                            {
                                string newFilePath = originalFilePath.Replace(originalName, newName);

                                File.Copy(originalFilePath, newFilePath);

                                File.Delete(originalFilePath);


                                InfoField.Text += Path.GetFileName(originalFilePath) + Environment.NewLine;
                            }
                        }*/
        }

        private void OriginalFolderDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDialog = new FolderBrowserDialog();

            DialogResult result = FolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedPath = FolderDialog.SelectedPath;
                OriginalFolderPath.Text = selectedPath;
            }
        }

        private void OutputFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDialog = new FolderBrowserDialog();

            DialogResult result = FolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                DestinationFolderPath.Text = FolderDialog.SelectedPath;
            }
        }
    }
}
