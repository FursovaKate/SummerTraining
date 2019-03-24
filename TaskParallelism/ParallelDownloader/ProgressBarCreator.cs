using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ParallelDownloader
{
    public class ProgressBarCreator
    {
        private const int width = 500;
        private const int height = 30;
        private const int minimum = 0;
        private const int maximum = 100;
        private Thickness margin = new Thickness(15);
        public int RowCount { get; set; }

        private string CreateName()
        {
            var progressBarNameBuilder = new StringBuilder();
            progressBarNameBuilder.Append("ProgressBar");
            progressBarNameBuilder.Append(RowCount);
            return progressBarNameBuilder.ToString();
        }

        public ProgressBar CreateProgressBar()
        {
            var progressBar = new ProgressBar();
            progressBar.Width = width;
            progressBar.Height = height;
            progressBar.Minimum = minimum;
            progressBar.Maximum = maximum;
            progressBar.Margin = margin;
            progressBar.Name = CreateName();
            return progressBar;
        }
    }
}
