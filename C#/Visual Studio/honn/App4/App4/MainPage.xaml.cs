using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace App4
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private Uri newUri;
        private async void GoButton_Click(object sender, RoutedEventArgs e)
        {
            if (Uri.TryCreate(TextBox1.Text, UriKind.Absolute, out newUri
                )&& newUri.Scheme.StartsWith("http"))
            {
                WebView1.Navigate(newUri);
            }
            else
            {
                string Msg = "入力されたURIが認識出来ません。";
                await new Windows.UI.Popups.MessageDialog(Msg).ShowAsync();
            }
            TextBox1.Text = "";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            WebView1.GoBack();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            WebView1.Refresh();
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            WebView1.GoForward();
        }
    }
}
