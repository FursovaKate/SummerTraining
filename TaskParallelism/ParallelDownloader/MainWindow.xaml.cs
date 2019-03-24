using System;
using System.Windows;


namespace ParallelDownloader
{
    public partial class MainWindow : Window
    {
        private int rowCount;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Download_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rowCount++;

                var cancelButtonCreator = new CancelButtonCreator();
                cancelButtonCreator.RowCount = rowCount;
                var newCancelButton = cancelButtonCreator.CreateButton();

                var progressBarCreator = new ProgressBarCreator();
                progressBarCreator.RowCount = rowCount;
                progressBarCreator.CreateProgressBar();
                var currentProgressBar = progressBarCreator.CreateProgressBar();

                Bars.Children.Add(currentProgressBar);
                Buttons.Children.Add(newCancelButton);

                var downloadObjectCreator = new DownloadObjectCreator();
                downloadObjectCreator.Url = Link.Text;
                downloadObjectCreator.ProgressBar = new Progress<int>();

                await Downloader.DownloadFile(downloadObjectCreator, currentProgressBar, cancelButtonCreator.CancellationTokenSource);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
