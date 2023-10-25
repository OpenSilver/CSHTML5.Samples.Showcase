﻿Imports System.Windows.Browser
Imports CSHTML5.Internal
#If SLMIGRATION Then
Imports System.Windows
Imports System.Windows.Controls
#Else
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Controls
#End If

Namespace Global.OpenSilver.Samples.Showcase
    Public Class ControlToDisplayCodeHostedOnGitHub
        Inherits ContentControl
        Private _filePathOnGitHub As String
        Private _displayedHtmlString As String

        Public Sub New()
            AddHandler Loaded, AddressOf OnLoaded

            VerticalContentAlignment = VerticalAlignment.Stretch
            HorizontalContentAlignment = HorizontalAlignment.Stretch
        End Sub

        Public Sub New(absolutePath As String)
            Me.New()
            FilePathOnGitHub = absolutePath
        End Sub

        Private Function GetHtmlString(ByVal filePath As String) As String
            Dim embedJs = INTERNAL_UriHelper.ConvertToHtml5Path("ms-appx:/Other/embed.js")
            Return String.Format("<script src=""{0}?target={1}&style=github&showBorder=on&showLineNumbers=on&showCopy=on""></script>", embedJs, HttpUtility.UrlEncode(filePath))
        End Function

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Not String.IsNullOrEmpty(_filePathOnGitHub) Then
                Dim htmlString = GetHtmlString(_filePathOnGitHub)
                DisplayHtmlString(htmlString)
            End If
        End Sub

        Private Sub DisplayHtmlString(ByVal htmlString As String)
#If SLMIGRATION Then
            Dim webView = New WebBrowser()
#Else
            Dim webView = New WebView()
#End If
            webView.NavigateToString(htmlString)
            Content = webView
            _displayedHtmlString = htmlString
        End Sub

        Public Property FilePathOnGitHub As String
            Get
                Return _filePathOnGitHub
            End Get
            Set(ByVal value As String)
                _filePathOnGitHub = value

                If IsLoaded Then
                    Dim htmlString = GetHtmlString(FilePathOnGitHub)
                    If Not Equals(htmlString, _displayedHtmlString) Then
                        DisplayHtmlString(htmlString)
                    End If
                End If
            End Set
        End Property

    End Class
End Namespace
