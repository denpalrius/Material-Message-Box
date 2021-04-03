using System;
using System.Windows;
using System.Windows.Media;

namespace BespokeFusion
{
    public sealed class MaterialMessageBox
    {
        private const string MessageBoxTitle = "Message";

        /// <summary>
        /// Displays a message box with OK button
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="isRTL">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        public static void Show(string message, bool isRTL = false)
        {
            using (MessageBoxWindow msg = new MessageBoxWindow())
            {
                msg.Title = MessageBoxTitle;
                msg.TxtTitle.Text = MessageBoxTitle;
                msg.TxtMessage.Text = message;
                msg.TitleBackgroundPanel.Background = new SolidColorBrush(Color.FromRgb(3, 169, 244));
                msg.BorderBrush = new SolidColorBrush(Color.FromRgb(3, 169, 244));
                msg.BtnCancel.Visibility = Visibility.Collapsed;
                if (isRTL)
                {
                    msg.FlowDirection = FlowDirection.RightToLeft;
                }
                msg.BtnOk.Focus();
                msg.ShowDialog();
            }
        }

        /// <summary>
        ///  Displays a message box with OK button
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="title">The title of the message box</param>
        /// <param name="isRTL">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        public static void Show(string message, string title, bool isRTL = false)
        {
            using (MessageBoxWindow msg = new MessageBoxWindow())
            {
                msg.Title = title;
                msg.TxtTitle.Text = title;
                msg.TxtMessage.Text = message;
                msg.TitleBackgroundPanel.Background = new SolidColorBrush(Color.FromRgb(3, 169, 244));
                msg.BorderBrush = new SolidColorBrush(Color.FromRgb(3, 169, 244));
                msg.BtnCancel.Visibility = Visibility.Collapsed;
                if (isRTL)
                {
                    msg.FlowDirection = FlowDirection.RightToLeft;
                }
                msg.BtnOk.Focus();
                msg.ShowDialog();
            }
        }

        /// <summary>
        /// Displays an error message box
        /// </summary>
        /// <param name="errorMessage">The error error message to display</param>
        /// <param name="isRTL">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        public static void ShowError(string errorMessage, bool isRTL = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.Title = "Error";
                    msg.TxtTitle.Text = "Error";
                    msg.TxtMessage.Text = errorMessage;
                    msg.TitleBackgroundPanel.Background = Brushes.Red;
                    msg.BorderBrush = Brushes.Red;
                    msg.BtnCancel.Visibility = Visibility.Collapsed;
                    if (isRTL)
                    {
                        msg.FlowDirection = FlowDirection.RightToLeft;
                    }
                    msg.BtnOk.Focus();
                    msg.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Displays an error message box
        /// </summary>
        /// <param name="errorMessage">The error error message to display</param>
        /// <param name="errorTitle">The title of the error message box</param>
        /// <param name="isRTL">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        public static void ShowError(string errorMessage, string errorTitle, bool isRTL = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.Title = errorTitle;
                    msg.TxtTitle.Text = errorTitle;
                    msg.TxtMessage.Text = errorMessage;
                    msg.TitleBackgroundPanel.Background = Brushes.Red;
                    msg.BorderBrush = Brushes.Red;
                    msg.BtnCancel.Visibility = Visibility.Collapsed;
                    if (isRTL)
                    {
                        msg.FlowDirection = FlowDirection.RightToLeft;
                    }
                    msg.BtnOk.Focus();
                    msg.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Displays a warning message box
        /// </summary>
        /// <param name="warningMessage">The warning message to display</param>
        /// <param name="isRTL">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        public static void ShowWarning(string warningMessage, bool isRTL = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.Title = "Warning";
                    msg.TxtTitle.Text = "Warning";
                    msg.TxtMessage.Text = warningMessage;
                    msg.TitleBackgroundPanel.Background = Brushes.Orange;
                    msg.BorderBrush = Brushes.Orange;
                    msg.BtnCancel.Visibility = Visibility.Collapsed;
                    if (isRTL)
                    {
                        msg.FlowDirection = FlowDirection.RightToLeft;
                    }
                    msg.BtnOk.Focus();
                    msg.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(warningMessage);
            }
        }

        /// <summary>
        /// Displays a warning message box
        /// </summary>
        /// <param name="warningMessage">The warning message to display</param>
        /// <param name="warningTitle">The title of the error message box</param>
        /// <param name="isRTL">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        public static void ShowWarning(string warningMessage, string warningTitle, bool isRTL = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.Title = warningTitle;
                    msg.TxtTitle.Text = warningTitle;
                    msg.TxtMessage.Text = warningMessage;
                    msg.TitleBackgroundPanel.Background = Brushes.Orange;
                    msg.BorderBrush = Brushes.Orange;
                    msg.BtnCancel.Visibility = Visibility.Collapsed;
                    if (isRTL)
                    {
                        msg.FlowDirection = FlowDirection.RightToLeft;
                    }
                    msg.BtnOk.Focus();
                    msg.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(warningMessage, warningTitle);
            }
        }

        /// <summary>
        /// Displays a message box with a cancel button
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="isRTL">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        /// <returns>Message box Result OK or CANCEL</returns>
        public static MessageBoxResult ShowWithCancel(string message, bool isRTL = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.Title = MessageBoxTitle;
                    msg.TxtTitle.Text = MessageBoxTitle;
                    msg.TxtMessage.Text = message;
                    msg.TitleBackgroundPanel.Background = new SolidColorBrush(Color.FromRgb(3, 169, 244));
                    msg.BorderBrush = new SolidColorBrush(Color.FromRgb(3, 169, 244));
                    if (isRTL)
                    {
                        msg.FlowDirection = FlowDirection.RightToLeft;
                    }
                    msg.BtnOk.Focus();
                    msg.ShowDialog();
                    return msg.Result == MessageBoxResult.OK ? MessageBoxResult.OK : MessageBoxResult.Cancel;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(message);
                return MessageBoxResult.Cancel;
            }
        }

        /// <summary>
        /// Displays a message box with a cancel button
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="title">The title of the message box</param>
        /// <param name="isRTL">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        /// <returns>Message box Result OK or CANCEL</returns>
        public static MessageBoxResult ShowWithCancel(string message, string title, bool isRTL = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.Title = title;
                    msg.TxtTitle.Text = title;
                    msg.TxtMessage.Text = message;
                    msg.TitleBackgroundPanel.Background = new SolidColorBrush(Color.FromRgb(3, 169, 244));
                    msg.BorderBrush = new SolidColorBrush(Color.FromRgb(3, 169, 244));
                    if (isRTL)
                    {
                        msg.FlowDirection = FlowDirection.RightToLeft;
                    }
                    msg.BtnOk.Focus();
                    msg.ShowDialog();
                    return msg.Result == MessageBoxResult.OK ? MessageBoxResult.OK : MessageBoxResult.Cancel;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(message);
                return MessageBoxResult.Cancel;
            }
        }

        /// <summary>
        /// Displays a message box with a cancel button
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="isError">If the message is an error</param>
        /// <param name="isRTL">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        /// <returns>Message box Result OK or CANCEL</returns>
        public static MessageBoxResult ShowWithCancel(string message, bool isError, bool isRTL = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.Title = MessageBoxTitle;
                    msg.TxtTitle.Text = MessageBoxTitle;
                    msg.TxtMessage.Text = message;
                    msg.TitleBackgroundPanel.Background = isError
                        ? Brushes.Red
                        : new SolidColorBrush(Color.FromRgb(3, 169, 244));
                    msg.BorderBrush = isError
                        ? Brushes.Red
                        : new SolidColorBrush(Color.FromRgb(3, 169, 244));
                    if (isRTL)
                    {
                        msg.FlowDirection = FlowDirection.RightToLeft;
                    }
                    msg.BtnOk.Focus();
                    msg.ShowDialog();
                    return msg.Result == MessageBoxResult.OK ? MessageBoxResult.OK : MessageBoxResult.Cancel;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(message);
                return MessageBoxResult.Cancel;
            }
        }

    }
}
