﻿Imports System
Imports System.Collections.Generic
Imports System.Windows.Input
#If SLMIGRATION
Imports System.Windows
Imports System.Windows.Controls
#Else
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#End If

Namespace Global.OpenSilver.Samples.Showcase
    Partial Public Class InteractivityTriggers_Demo
        Inherits UserControl
        Public Sub New()
            Me.InitializeComponent()

            DataContext = New TestViewModel()
        End Sub

        Public Class TestViewModel

            Private _TestCommand As System.Windows.Input.ICommand
            Public Sub New()
                TestCommand = New TestICommandClass()
            End Sub

            Public Property TestCommand As ICommand
                Get
                    Return _TestCommand
                End Get
                Private Set(ByVal value As ICommand)
                    _TestCommand = value
                End Set
            End Property
        End Class

        Public Class TestICommandClass
            Implements ICommand
            Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

            Public Function CanExecute(ByVal parameter As Object) As Boolean Implements ICommand.CanExecute
                Return True
            End Function

            Public Sub Execute(ByVal parameter As Object) Implements ICommand.Execute
                MessageBox.Show("The command was successfully executed.")
            End Sub
        End Class
    End Class
End Namespace
