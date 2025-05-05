namespace BitSweep.Core
{
    internal class Sweeper
    {
        #region Events

        internal delegate void FileSweepedEventHandler(object sender, FileSweepedEventArgs e);
        internal event FileSweepedEventHandler FileSweeped;

        internal delegate void FileSweepFinishedEventHandler(object sender, EventArgs e);
        internal event FileSweepFinishedEventHandler FileSweepFinished;

        #endregion

        private List<string> directories;

        internal Sweeper(List<string> directories)
            => this.directories = directories;

        internal async Task<int> CalculateFileCountAsync()
        {
            int count = 0;
            await Task.Run(() => 
            {
                foreach (string directory in directories)
                {
                    if (Directory.Exists(directory))
                        count += Directory.GetFiles(directory, "*", SearchOption.AllDirectories).Length;
                }
            });
            return count;
        }

        internal async Task SweepDirectoriesAsync()
        {
            await Task.Run(() => 
            {
                foreach (string directory in directories)
                {
                    if (Directory.Exists(directory))
                    {
                        string[] files = Directory.GetFiles(directory, "*", SearchOption.AllDirectories);

                        foreach (string file in files)
                        {
                            try
                            {
                                long size = new FileInfo(file).Length;
                                File.Delete(file);
                                FileSweeped?.Invoke(this, new FileSweepedEventArgs(Path.GetFileName(file), size));
                            }
                            catch { /* TODO: handle exceptions. */ }
                        }
                    }
                }
            });
            FileSweepFinished?.Invoke(this, EventArgs.Empty);
        }
    }

    internal class FileSweepedEventArgs : EventArgs
    {
        internal string FileName { get; }
        internal long FileSize { get; }

        internal FileSweepedEventArgs(string fileName, long fileSize)
        {
            FileName = fileName;
            FileSize = fileSize;
        }
    }
}