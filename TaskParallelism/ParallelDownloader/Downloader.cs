using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace ParallelDownloader
{
    public static class Downloader
    {
        public static async Task DownloadFile(DownloadObjectCreator downloadObjectCreator, ProgressBar progressBar, CancellationTokenSource token)
        {
            try
            {
                using (var client = new HttpClient())
                using (var response = await client.GetAsync(downloadObjectCreator.Url, token.Token))
                using (var content = response.Content)
                using (var outputStream = new FileStream(downloadObjectCreator.GetDestinationPath(), FileMode.OpenOrCreate, FileAccess.Write))
                {
                    var buffer = new byte[1024];
                    var stream = await content.ReadAsStreamAsync();
                    do
                    {
                        if (token.IsCancellationRequested)
                        {
                            break;
                        }
                        var read = await stream.ReadAsync(buffer, 0, buffer.Length);
                        await Task.Delay(200);
                        progressBar.Value += Math.Abs((double)read / stream.Length * 100);
                        downloadObjectCreator.ProgressBar.Report((int)progressBar.Value);
                        await outputStream.WriteAsync(buffer, 0, read);
                    } while (stream.Length > 0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
