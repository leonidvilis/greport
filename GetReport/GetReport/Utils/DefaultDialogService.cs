using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetReport.Utils
{
    public sealed class DefaultDialogService : IDialogService
    {
        public string FilePath { get; set; }
        public string FolderPath { get; set; }

        public bool OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        public bool OpenFileDialog(string InitialDirectory,string Title, string Filter, bool RestoreDirectory, bool CheckFileExist)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = CheckFileExist;
            openFileDialog.Title = Title;
            openFileDialog.InitialDirectory = InitialDirectory;
            openFileDialog.Filter = Filter;
            openFileDialog.RestoreDirectory = RestoreDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        public bool OpenPath()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = folderBrowserDialog.SelectedPath;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog.FileName;
                return true;
            }
            return false;
        }

        public bool SaveFileDialog(string InitialDirectory, string Filter, string Title, bool RestoreDirectory, bool CheckFileExist, bool OverwritePrompt
            )
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = InitialDirectory;
            saveFileDialog.Filter = Filter;
            saveFileDialog.Title = Title;
            saveFileDialog.RestoreDirectory = RestoreDirectory;
            saveFileDialog.CheckFileExists = CheckFileExist;
            saveFileDialog.OverwritePrompt = OverwritePrompt;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog.FileName;
                return true;
            }
            return false;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
