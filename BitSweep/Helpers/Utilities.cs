namespace BitSweep.Helpers
{
    internal class Utilities
    {
        internal static DialogResult ShowInformation(string information)
            => MessageBox.Show(information, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        internal static DialogResult AskQuestion(string question)
            => MessageBox.Show(question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        internal static string FormatBytes(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }
    }
}