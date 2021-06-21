using System;
using System.Windows.Forms;
using System.IO;

namespace CopyToFolderByLastWriteDateUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string sourceDir = edt_sourceDir.Text;

            if (sourceDir == "")
            {
                WriteToLog($"> there is no working directory");
                return;
            }
            try
            {
                FileManager fileManager = new FileManager();
                fileManager.MoveFiles(sourceDir);
                foreach(string logString in fileManager.LogString)
                    WriteToLog(logString);
            }
            catch (ArgumentException ex)
            {
                WriteToLog($"ERROR: {ex.Message}");
            }
            catch (Exception ex)
            {
                WriteToLog($"ERROR unexpected exception ({ex.GetType()}): {ex.Message}");
            }
        }

        private void WriteToLog(string logString)
        {
            _ = lbx_log.Items.Add(logString);
        }

        private void btn_selectSourceDir_Click(object sender, EventArgs e)
        {
            edt_sourceDir.Text = selectSourceDir(edt_sourceDir.Text);
        }

        private string selectSourceDir(string initialDir = "")
        {
            if (!Directory.Exists(initialDir))
                initialDir = "";

            using (FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog())
            {
                folderBrowserDlg.SelectedPath = initialDir;
                folderBrowserDlg.ShowNewFolderButton = false;

                DialogResult result = folderBrowserDlg.ShowDialog();

                return (result == DialogResult.OK) ? folderBrowserDlg.SelectedPath : initialDir;
            }
        }
    }
}
