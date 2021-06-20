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

        public void MoveFiles(string sourceDir)
        {
            if (sourceDir == null || sourceDir == "")
                throw new ArgumentNullException("sourceDir", "Null or EmptyString");

            if (Directory.Exists(sourceDir))
                throw new ArgumentException("Directory does not exist");

            try
            {
                WriteToLog($"> working directory: {sourceDir}");

                string[] filesInDir = Directory.GetFiles(sourceDir);
                int destFileCount = 0;
                int skippedFiles = 0;
                WriteToLog($"> {filesInDir.Length} files found.");

                foreach (var sourceFile in filesInDir)
                {
                    string destDir = Path.Combine(sourceDir, Directory.GetLastWriteTime(sourceFile).ToString("yyyy_MM_dd"));
                    if (!Directory.Exists(destDir))
                    {
                        WriteToLog($"> create new sub directory: {destDir}");
                        Directory.CreateDirectory(destDir);
                    }

                    string destFile = sourceFile.Replace(sourceDir, destDir);
                    WriteToLog($"> move {sourceFile.Substring(sourceDir.Length + 1)} -> {destFile.Substring(sourceDir.Length + 1)}");
                    try
                    {
                        File.Move(sourceFile, destFile);
                        destFileCount++;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        WriteToLog($"ERROR UnauthorizedAccessException: {ex.Message}");
                        skippedFiles++;
                    }
                    catch (PathTooLongException ex)
                    {
                        WriteToLog($"ERROR PathTooLongException: {ex.Message}");
                        skippedFiles++;
                    }
                    catch (IOException ex)
                    {
                        WriteToLog($"ERROR: Datei konnte nicht verschoben werden: {ex.Message}");
                        skippedFiles++;
                    }
                    catch (Exception ex)
                    {
                        WriteToLog($"ERROR unexpected exception ({ex.GetType()}): {ex.Message}");
                        skippedFiles++;
                    }
                }
                WriteToLog($"> {destFileCount} files copied.");
                WriteToLog($"> {skippedFiles} files skipped.");
            }
            catch (Exception ex)
            {
                WriteToLog($"ERROR unexpected exception ({ex.GetType()}): {ex.Message}");
            }
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
                MoveFiles(sourceDir);
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
            txt_log.AppendText(logString);
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

                DialogResult result = folderBrowserDlg.ShowDialog();

                return (result == DialogResult.OK) ? folderBrowserDlg.SelectedPath : initialDir;
            }
        }
    }
}
