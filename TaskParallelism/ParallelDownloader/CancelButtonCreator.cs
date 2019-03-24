using System;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;


namespace ParallelDownloader
{
    public class CancelButtonCreator
    {
        private const int width = 152;
        private const int height = 33;
        private const string content = "Cancel";
        private Thickness margin = new Thickness(15);
        private RoutedEventHandler eventHandler;
        public CancellationTokenSource CancellationTokenSource = new CancellationTokenSource();
        public int RowCount { get; set; }

        public CancelButtonCreator()
        {
            eventHandler = Cancel_Click;
        }

        private string CreateName()
        {
            var buttonNameBuilder = new StringBuilder();
            buttonNameBuilder.Append("Button");
            buttonNameBuilder.Append(RowCount);
            return buttonNameBuilder.ToString();
        }

        public Button CreateButton()
        {
            var button = new Button();
            button.Width = width;
            button.Height = height;
            button.Content = content;
            button.Click += eventHandler;
            button.Margin = margin;
            button.Name = CreateName();
            return button;
        }

        public void Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                CancellationTokenSource.Cancel(true);
                CancellationTokenSource = new CancellationTokenSource();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
