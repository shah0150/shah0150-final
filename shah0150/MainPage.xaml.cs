using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Notifications;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace shah0150
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;

        }

        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Menu Item 1 is clicked");
            Frame.Navigate(typeof(AboutMe));
        }

        private void MenuButton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdvanceFeature));
        }

        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MediaElement));
        }

        // Toast Message Template 

        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // Frame.Navigate(typeof(AdvanceFeature));

        //    XmlDocument doc = new XmlDocument();
        //    StorageFile file = await StorageFile.GetFileFromApplicationUriAsync
        //        (new Uri("ms-aapx:///ToastTemplate/ToastMessage.xml", UriKind.Absolute));
        //    IRandomAccessStream readStream = await file.OpenAsync(FileAccessMode.Read);
        //    XDocument xmldoc = XDocument.Load(readStream.AsStreamForRead());
        //    var toastTemplate = xmldoc.ToString();
        //    var toast = new ToastNotification(doc);
        //    var notification = ToastNotificationManager.CreateToastNotifier();
        //    notification.Show(toast);
        //}
    }
}
