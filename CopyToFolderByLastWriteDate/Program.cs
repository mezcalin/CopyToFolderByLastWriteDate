using System;
using System.IO;

namespace CopyToFolderByCreationDate
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Set a variable to the My Documents path.
                string sourceDir = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory();

                Console.WriteLine($"> working directory: {sourceDir}");

                string[] filesInDir = Directory.GetFiles(sourceDir);
                int sourceFileCount = filesInDir.Length;
                int destFileCount = 0;
                int skippedFiles = 0;
                Console.WriteLine($"> {sourceFileCount} files found.");
                foreach (var sourceFile in filesInDir)
                {
                    string destDir = Path.Join(sourceDir, Directory.GetLastWriteTime(sourceFile).ToString("yyyy_MM_dd"));
                    if (!Directory.Exists(destDir))
                    {
                        Console.WriteLine($"> create new sub directory: {destDir}");
                        Directory.CreateDirectory(destDir);
                    }

                    var destFile = sourceFile.Replace(sourceDir, destDir);
                    Console.WriteLine($"> move {sourceFile.Substring(sourceDir.Length + 1)} -> {destFile.Substring(sourceDir.Length + 1)}");
                    try
                    {
                        File.Move(sourceFile, destFile);
                        destFileCount++;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine($"ERROR UnauthorizedAccessException: {ex.Message}");
                        skippedFiles++;
                    }
                    catch (PathTooLongException ex)
                    {
                        Console.WriteLine($"ERROR PathTooLongException: {ex.Message}");
                        skippedFiles++;
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"ERROR: Datei konnte nicht verschoben werden: {ex.Message}");
                        skippedFiles++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"ERROR unexpected exception ({ex.GetType()}): {ex.Message}");
                        skippedFiles++;
                    }
                }
                Console.WriteLine($"> {destFileCount} files copied.");
                Console.WriteLine($"> {skippedFiles} files skipped.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR unexpected exception ({ex.GetType()}): {ex.Message}");
            }
        }
    }
}
