﻿Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input

Namespace OpenSilver.Samples.Showcase
    Public Partial Class Material_Design
        Inherits UserControl
        Public Sub New()
            Me.InitializeComponent()

            Dim items As ObservableCollection(Of String) = New ObservableCollection(Of String)() From {
                "Item 1",
                "Item 2",
                "Item 3"
            }
            DataContext = items

            Me.DataGrid.ItemsSource = DataGridDataInstance.GetDataSet()
        End Sub

        Private Sub DisplayContextMenu_Click(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            Dim cc = CType(sender, ContentControl)
            cc.ContextMenu.HorizontalOffset = e.GetPosition(Nothing).X
            cc.ContextMenu.VerticalOffset = e.GetPosition(Nothing).Y
            cc.ContextMenu.IsOpen = True
        End Sub

        Private Sub ContextMenu_Closed(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim contextMenu = CType(sender, ContextMenu)
            contextMenu.HorizontalOffset = 0
            contextMenu.VerticalOffset = 0
        End Sub

        Private Sub ButtonShowChildWindow_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim childWindow = New OpenSilver.Samples.Showcase.SampleMaterialChildWindow()
            childWindow.Show()
        End Sub

        Private Sub MenuEditDraft_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim menuItem = CType(sender, MenuItem)
            Dim message = String.Format("You clicked to edit the draft on the item ""{0}"".", CType(menuItem.DataContext, DataGridDataInstance).Name)
            MessageBox.Show(message)
        End Sub

        Private Sub MenuRemoveDraft_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim menuItem = CType(sender, MenuItem)
            Dim message = String.Format("You clicked to remove the draft on the item ""{0}"".", CType(menuItem.DataContext, DataGridDataInstance).Name)
            MessageBox.Show(message)
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim b = CType(sender, Button)
            Dim content = b.Content
            Dim tag = b.Tag
        End Sub
    End Class


    Public Class DataGridDataInstance
        Private Sub New(ByVal name As String, ByVal location As String, ByVal subscription As String)
            Me.Name = name
            Me.Location = location
            Me.Subscription = subscription
        End Sub

        Public Property Name As String

        Public Property Location As String

        Public Property Subscription As String

        Public Shared Function GetDataSet() As ObservableCollection(Of DataGridDataInstance)
            Return New ObservableCollection(Of DataGridDataInstance)() From {
    New DataGridDataInstance("Default-ApplicationInsights-EastUS", "East US", "Subscription-1"),
    New DataGridDataInstance("Default-SQL-CentralUS", "Central US", "Subscription-1"),
    New DataGridDataInstance("Default-SQL-NorthCentralUS", "North Central US", "Subscription-1"),
    New DataGridDataInstance("Default-SQL-SouthCentralUS", "South Central US", "Subscription-1"),
    New DataGridDataInstance("Default-Storage-NorthCentralUS", "North Central US", "Subscription-1"),
    New DataGridDataInstance("Default-Storage-WestUS", "West US", "Subscription-1"),
    New DataGridDataInstance("Default-Web-EastUS", "East US", "Subscription-1"),
    New DataGridDataInstance("Default-Web-NorthCentralUS", "North Central US", "Subscription-1")
}
        End Function
    End Class
End Namespace
