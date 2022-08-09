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
    public partial class ExecuteJavaScript_Demo : UserControl
    {
        public ExecuteJavaScript_Demo()
        {
            this.InitializeComponent();
        }

        void SendJavaScriptMessage(object sender, RoutedEventArgs e)
        {
            Interop.ExecuteJavaScript("alert($0);", TextBoxInput.Text);
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "ExecuteJavaScript_Demo.xaml",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/Interop_Samples/ExecuteJavaScript/ExecuteJavaScript_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "ExecuteJavaScript_Demo.xaml.cs",
                    FilePathOnGitHub = "github/OpenSilver/OpenSilver.Samples.Showcase/blob/master/src/Samples/Interop_Samples/ExecuteJavaScript/ExecuteJavaScript_Demo.xaml.cs"
                }
            });
        }

    }
}
