using BespokeFusion;
using System;
using System.Windows;
using System.Windows.Media;

namespace MaterialMessageBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowSimpleMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            MaterialMessageBox.Show($"This is a simple message\n\nIs'nt it cool\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", "Message Box Title");
        }
        private void ShowErrorMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            MaterialMessageBox.ShowError(@"This is an error message");
        }
        private void ShowMessageBoxWithCancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            var result = MaterialMessageBox.ShowWithCancel($"This is a simple message with a cancel button. You can listen to the return value", "Message Box Title");
            TxtResult.Text = $"Message Box Result is: {result}";
        }
        private void ShowCustomMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            //With this option
            //You should add a reference to the mahApps.Metro available at http://mahapps.com/
            //You can create this as a static class and reuse it all over your app

            var msg = new CustomMaterialMessageBox
            {
                TxtMessage = { Text = "Do you like white wine?", Foreground = Brushes.White },
                TxtTitle = { Text = "This is too cool", Foreground = Brushes.White },
                BtnOk = { Content = "Yes" },
                BtnCancel = { Content = "Noooo" },
                MainContentControl = { Background = Brushes.MediumVioletRed },
                TitleBackgroundPanel = { Background = Brushes.BlueViolet },
                BorderBrush = Brushes.BlueViolet
            };

            msg.Show();
            var results = msg.Result;
            TxtResult.Text = $"Message Box Result is: {results}";
        }

        private void ShowSimpleRTLMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            MaterialMessageBox.Show($"This is a simple message{Environment.NewLine}هذه رسالة بسيطة{Environment.NewLine}{Environment.NewLine}Is'nt it cool\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", "Message Box Title", true);
        }
    }
}
