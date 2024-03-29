﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace shah0150
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutMe : Page
    {
        public AboutMe()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //EmailMessage emailMessage = new EmailMessage();
            //emailMessage.To.Add(new EmailRecipient("shah0150@algonquinlive.com"));
            //string messageBody = "Awesome Work Adesh! Your Grade for this assignment is 100%";
            //emailMessage.Body = messageBody;
            //await EmailManager.ShowComposeNewEmailAsync(emailMessage);


            Uri email = new Uri("mailto:shah0150@algonquinlive.com");
            await Windows.System.Launcher.LaunchUriAsync(email);
        }

        #region Navigated to and from back button
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

            currentView.BackRequested += backButton_Tapped;


            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;

            currentView.BackRequested -= backButton_Tapped;

            base.OnNavigatingFrom(e);
        }

        private void backButton_Tapped(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
                e.Handled = true;
            }
            else
            {
                Debug.WriteLine("Can't go back");
            }
        }
        #endregion
    }
}
