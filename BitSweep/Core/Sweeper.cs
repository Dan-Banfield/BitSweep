namespace BitSweep.Core
{
    internal class Sweeper
    {
        internal delegate void FileSweepedEventHandler(object sender, EventArgs e);
        internal event FileSweepedEventHandler FileSweeped;

        internal delegate void FileSweepFinishedEventHandler(object sender, EventArgs e);
        internal event FileSweepFinishedEventHandler FileSweepFinished;

        internal int CalculateFileCount(List<string> directoryList)
        {
            int count = 0;

            foreach (string directory in directoryList)
            {
                if (Directory.Exists(directory))
                    count += Directory.GetFiles(directory, "*", SearchOption.AllDirectories).Length;
            }
            return count;
        }

        internal void SweepDirectories(List<string> directoryList)
        {
            Task.Run(() => 
            {
                foreach (string directory in directoryList)
                {
                    if (Directory.Exists(directory))
                    {
                        string[] files = Directory.GetFiles(directory, "*", SearchOption.AllDirectories);

                        foreach (string file in files)
                        {
                            try
                            {
                                File.Delete(file);
                                FileSweeped?.Invoke(this, EventArgs.Empty);
                            }
                            catch { }
                        }
                    }
                }
            });
            FileSweepFinished?.Invoke(this, EventArgs.Empty);
        }
    }
}