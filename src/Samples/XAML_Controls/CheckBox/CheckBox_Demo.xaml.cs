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
    public partial class CheckBox_Demo : UserControl
    {
        public CheckBox_Demo()
        {
            this.InitializeComponent();
        }

        void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You checked me.");
        }

        void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You unchecked me.");
        }
    }
}
