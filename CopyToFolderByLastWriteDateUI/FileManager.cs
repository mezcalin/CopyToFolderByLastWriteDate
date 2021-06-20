using System;
using System.IO;

namespace CopyToFolderByLastWriteDateUI
{
    class FileManager
    {
        public string LogString { get; private set; }

        public FileManager(string logString)
        {
            LogString = logString;
        }

        public void MoveFiles(string sourceDir)
        {
            if (sourceDir == null || sourceDir == "")
                throw new ArgumentNullException("sourceDir", "Null or EmptyString");

            if (!Directory.Exists(sourceDir))
                throw new ArgumentException("Directory does not exist");

            try
            {
                WriteToLog($"> working directory: {sourceDir}");

                string[] filesInDir = Directory.GetFiles(sourceDir);
                int destFileCount = 0;
                int skippedFiles = 0;
                WriteToLog($"> {filesInDir.Length} files found.");

                if (filesInDir.Length == 0)
                    return;

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
        private void WriteToLog(string logString)
        {
            LogString += logString;
        }
    }
}
