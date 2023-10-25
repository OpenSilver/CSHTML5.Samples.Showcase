﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
#if SLMIGRATION
using System.Windows;
using System.Windows.Controls;
#else
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#endif

namespace OpenSilver.Samples.Showcase
{
    public partial class PasswordBox_Demo : UserControl
    {
        public PasswordBox_Demo()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayPasswordIfNotEmpty();
        }

        private void DisplayPasswordIfNotEmpty()
        {
            if (PasswordBox.Password.Length != 0)
                MessageBox.Show("The password typed is \n\"" + PasswordBox.Password + "\"");
            else
                MessageBox.Show("Please enter a password");
        }
    }
}
