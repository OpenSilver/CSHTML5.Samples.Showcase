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
    public partial class ContextMenu_Demo : UserControl
    {
        public ContextMenu_Demo()
        {
            this.InitializeComponent();
        }

        private void MenuItem1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu Item 1");
        }

        private void MenuItem2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu Item 2");
        }

        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu Item 3");
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "ContextMenu_Demo.xaml",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ContextMenu/ContextMenu_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "ContextMenu_Demo.xaml.cs",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/ContextMenu/ContextMenu_Demo.xaml.cs"
                }
            });
        }

    }
}
