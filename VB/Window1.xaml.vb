' Developer Express Code Central Example:
' How to delete grid rows via the DeleteFocusedRow grid command
' 
' The following example demonstrates how to add a Delete item to the grid cell's
' context menu.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1791
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents

Namespace GridCommands_DeleteFocusedRow

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New AccountList().GetData()
        End Sub
    End Class

'#Region "Account classes"
    Public Class AccountList

        Public Function GetData() As List(Of Account)
            Return CreateAccounts()
        End Function

        Private Function CreateAccounts() As List(Of Account)
            Dim list As List(Of Account) = New List(Of Account)()
            list.Add(New Account() With {.UserName = "Nick White", .RegistrationDate = Date.Today})
            list.Add(New Account() With {.UserName = "Jack Rodman", .RegistrationDate = New DateTime(2009, 5, 10)})
            list.Add(New Account() With {.UserName = "Sandra Sherry", .RegistrationDate = New DateTime(2008, 12, 22)})
            list.Add(New Account() With {.UserName = "Sabrina Vilk", .RegistrationDate = Date.Today})
            list.Add(New Account() With {.UserName = "Mike Pearson", .RegistrationDate = New DateTime(2008, 10, 18)})
            Return list
        End Function
    End Class

    Public Class Account

        Public Property UserName As String

        Public Property RegistrationDate As Date
    End Class
'#End Region
End Namespace
