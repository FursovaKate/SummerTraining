using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParallelDownloader;

namespace ParallelDownloader_test
{
    [TestClass]
    public class DownloaderTest
    {
        private const string url = "https://www.google.com/";
        private const string expected = @"expected.html";

        [TestMethod]
        public async Task DownloadFileTest()
        {
            var downloadObjectCreator = new DownloadObjectCreator();
            downloadObjectCreator.Url = url;
            downloadObjectCreator.ProgressBar = new Progress<int>();
            await Downloader.DownloadFile(downloadObjectCreator, new ProgressBar(), new CancellationTokenSource());
            var directory = new DirectoryInfo(Environment.CurrentDirectory);
            var files = directory.GetFiles("*.html");
            foreach (var file in files)
            {
                Assert.AreEqual(expected, file);
            }
        }
    }
}
