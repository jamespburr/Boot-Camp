'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Order
    Public Property OrderID As Integer
    Public Property Customer As Nullable(Of Integer)
    Public Property OrderStatus As Nullable(Of Integer)
    Public Property OrderDate As Nullable(Of Date)
    Public Property CreatedBy As Nullable(Of Integer)
    Public Property DateCreated As Date
    Public Property ModifiedBy As Nullable(Of Integer)
    Public Property DateModified As Nullable(Of Date)
    Public Property Archived As Boolean

    Public Overridable Property Customer1 As Customer
    Public Overridable Property OrderLines As ICollection(Of OrderLine) = New HashSet(Of OrderLine)
    Public Overridable Property OrderStatu As OrderStatu

End Class