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
    public partial class Interop_HtmlPresenter_Demo : UserControl
    {
        public Interop_HtmlPresenter_Demo()
        {
            this.InitializeComponent();
        }

        private void ButtonClickHere_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The value is: " + NumericTextBox1.Value.ToString());
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "Interop_HtmlPresenter_Demo.xaml",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/Interop_Samples/HtmlPresenter/Interop_HtmlPresenter_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "Interop_HtmlPresenter_Demo.xaml.cs",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/Interop_Samples/HtmlPresenter/Interop_HtmlPresenter_Demo.xaml.cs"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "NumericTextBox.cs",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/Interop_Samples/HtmlPresenter/NumericTextBox.cs"
                }
            });
        }

    }
}
