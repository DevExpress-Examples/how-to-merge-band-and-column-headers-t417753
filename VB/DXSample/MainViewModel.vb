Imports System.Collections.ObjectModel

Namespace DXSample
    Public Class MainViewModel
        Public Property Customers() As ObservableCollection(Of Customer)

        Public Sub New()
            Customers = New ObservableCollection(Of Customer)()
            Customers.Add(New Customer() With {.FullName = "Nancy Davolio", .JobTitle = "Sales Representative", .CompanyName = "Lonesome Pine Restaurant", .Phone = "(503) 555-9573", .Email = "nancy_davolio@outlook.com", .Country = "USA", .City = "Portland"})
            Customers.Add(New Customer() With {.FullName = "Henriette Pfalzheim", .JobTitle = "Vice President", .CompanyName = "Ottilies Käseladen", .Phone = "0221-0644327", .Email = "henriette_pfalzheim@outlook.com", .Country = "Germany", .City = "Köln"})
        End Sub
    End Class
    Public Class Customer
        Public Property City() As String
        Public Property CompanyName() As String
        Public Property Country() As String
        Public Property Email() As String
        Public Property FullName() As String
        Public Property JobTitle() As String
        Public Property Phone() As String

    End Class
End Namespace
