using System;
using System.Text;

namespace ParallelDownloader
{
    public class DownloadObjectCreator
    {
        public string Url { get; set; }
        public IProgress<int> ProgressBar { get; set; }

        public string GetDestinationPath()
        {
            var random = new Random();
            var randName = random.Next(100).ToString();
            var sb = new StringBuilder();
            sb.Append(@"downloadedFile");
            sb.Append(randName);
            sb.Append(".html");
            var destinationPath = sb.ToString();
            return destinationPath;
        }
    }
}
