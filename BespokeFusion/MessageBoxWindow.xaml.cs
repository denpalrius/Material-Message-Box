using System;
using System.Windows;

namespace BespokeFusion
{
    /// <summary>
    /// Interaction logic for MessageBoxWindow.xaml
    /// </summary>
    public partial class MessageBoxWindow: IDisposable
    {
        public MessageBoxResult Result { get; set; }

        public MessageBoxWindow()
        {
            InitializeComponent();
            Result = MessageBoxResult.Cancel;
        }
        private void BtnOk_OnClick(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.OK;
            Close();
        }
        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Cancel;
            Close();
        }

        public void Dispose()
        {
            Close();
        }

        private void BtnCopyMessage_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
               Clipboard.SetText(TxtMessage.Text);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
    }
}
