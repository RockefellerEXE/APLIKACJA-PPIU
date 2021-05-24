﻿using DataAccessLibrary;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Aplikacja.views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PanelUzytkownika : Page
    {
        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        public PanelUzytkownika()
        {
            this.InitializeComponent();
            test.Text = localSettings.Values["loggedUser"].ToString();
            Output.ItemsSource = DataAccess.GetData(test.Text);
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DodawanieWpisu));
        }

        private void btnUstawienia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnWyloguj_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}