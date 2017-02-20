Public Class LinqDemo
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            PopulateDDL()
        End If


    End Sub


#Region "Postbacks"

    Private Sub btnRunQuery_Click(sender As Object, e As EventArgs) Handles btnRunQuery.Click
        Dim queryID As Integer = ddlQuerySelect.SelectedValue
        Select Case queryID
            Case 1
                rgResults.DataSource = BootCampLibrary.GetBooksList()
                rgResults.DataBind()

            Case 2
                rgResults.DataSource = BootCampLibrary.GetBooksByAuthor(ddlParamList.SelectedValue)
                rgResults.DataBind()

            Case 3
                rgResults.DataSource = BootCampLibrary.GetCustomersByBook(ddlParamList.SelectedValue)
                rgResults.DataBind()

            Case 4
                rgResults.DataSource = BootCampLibrary.CustomerSales(ddlParamList.SelectedValue)
                rgResults.DataBind()

            Case 5
                rgResults.DataSource = BootCampLibrary.CustomerBookHistory(ddlParamList.SelectedValue)
                rgResults.DataBind()

            Case 6
                rgResults.DataSource = BootCampLibrary.BooksByAuthor()
                rgResults.DataBind()

            Case 7
                BootCampLibrary.AddCategory(txtParam1.Text)
                rgResults.DataSource = BootCampLibrary.GetCategoriesList
                rgResults.DataBind()

            Case 8
                BootCampLibrary.AddBook(txtParam1.Text, txtParam2.Text, txtParam3.Text)
                rgResults.DataSource = BootCampLibrary.GetBooksList()
                rgResults.DataBind()

            Case 9
                BootCampLibrary.AddBookCategory(ddlParamList.SelectedValue, ddlParamList2.SelectedValue)
                rgResults.DataSource = BootCampLibrary.GetBookCategoriesList(ddlParamList.SelectedValue)
                rgResults.DataBind()

            Case 10
                BootCampLibrary.DeleteBook(ddlParamList.SelectedValue)
                rgResults.DataSource = BootCampLibrary.GetBooksList()
                rgResults.DataBind()

            Case 11

                rgResults.DataSource = BootCampLibrary.ListBooksByAuthor(ddlParamList.SelectedValue)
                rgResults.DataBind()

        End Select
    End Sub

    Private Sub ddlQuerySelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlQuerySelect.SelectedIndexChanged
        Dim queryid As Integer = ddlQuerySelect.SelectedValue
        ClearControls()
        Select Case queryid

            Case 2
                lblParam1.Text = "Select Author:"
                lblParam1.Visible = True
                ddlParamList.DataSource = BootCampLibrary.GetAuthorsList
                ddlParamList.DataTextField = "Fullname"
                ddlParamList.DataValueField = "AuthorID"
                ddlParamList.DataBind()
                ddlParamList.Visible = True

            Case 3
                lblParam1.Text = "Select Book:"
                lblParam1.Visible = True
                ddlParamList.DataSource = BootCampLibrary.GetBooksList
                ddlParamList.DataTextField = "Title"
                ddlParamList.DataValueField = "BookID"
                ddlParamList.DataBind()
                ddlParamList.Visible = True

            Case 4
                lblParam1.Text = "Select Customer:"
                lblParam1.Visible = True
                ddlParamList.DataSource = BootCampLibrary.GetCustomersList
                ddlParamList.DataTextField = "Fullname"
                ddlParamList.DataValueField = "CustomerID"
                ddlParamList.DataBind()
                ddlParamList.Visible = True

            Case 5
                lblParam1.Text = "Select Customer:"
                lblParam1.Visible = True
                ddlParamList.DataSource = BootCampLibrary.GetCustomersList
                ddlParamList.DataTextField = "Fullname"
                ddlParamList.DataValueField = "CustomerID"
                ddlParamList.DataBind()
                ddlParamList.Visible = True

            Case 7
                lblParam1.Text = "Enter Category Name:"
                lblParam1.Visible = True
                txtParam1.Visible = True

            Case 8
                lblParam1.Text = "Enter Title:"
                lblParam1.Visible = True
                txtParam1.Visible = True
                lblParam2.Text = "Enter Price"
                lblParam2.Visible = True
                txtParam2.Visible = True
                lblParam3.Text = "Enter ISBN:"
                lblParam3.Visible = True
                txtParam3.Visible = True

            Case 9
                lblParam1.Text = "Select Book:"
                lblParam1.Visible = True
                ddlParamList.DataSource = BootCampLibrary.GetBooksList
                ddlParamList.DataTextField = "Title"
                ddlParamList.DataValueField = "BookID"
                ddlParamList.DataBind()
                ddlParamList.Visible = True
                lblParam2.Text = "Select Category:"
                lblParam2.Visible = True
                ddlParamList2.DataSource = BootCampLibrary.GetCategoriesList
                ddlParamList2.DataTextField = "CategoryName"
                ddlParamList2.DataValueField = "CategoryID"
                ddlParamList2.DataBind()
                ddlParamList2.Visible = True

            Case 10
                lblParam1.Text = "Select Book:"
                lblParam1.Visible = True
                ddlParamList.DataSource = BootCampLibrary.GetBooksList
                ddlParamList.DataTextField = "Title"
                ddlParamList.DataValueField = "BookID"
                ddlParamList.DataBind()
                ddlParamList.Visible = True

            Case 11
                lblParam1.Text = "Select Author:"
                lblParam1.Visible = True
                ddlParamList.DataSource = BootCampLibrary.GetAuthorsList
                ddlParamList.DataTextField = "Fullname"
                ddlParamList.DataValueField = "AuthorID"
                ddlParamList.DataBind()
                ddlParamList.Visible = True

        End Select



    End Sub

#End Region


#Region "Controls Subs"

    Private Sub ClearControls()
        lblParam1.Text = ""
        lblParam1.Visible = False
        lblParam2.Text = ""
        lblParam2.Visible = False
        ddlParamList.Items.Clear()
        ddlParamList.Visible = False
        ddlParamList2.Items.Clear()
        ddlParamList2.Visible = False
        txtParam1.Text = ""
        txtParam1.Visible = False
        txtParam2.Text = ""
        txtParam2.Visible = False
        lblParam3.Text = ""
        lblParam3.Visible = False
        txtParam3.Text = ""
        txtParam3.Visible = False
    End Sub

    Public Sub PopulateDDL()

        ddlQuerySelect.Items.Add(New ListItem("All Books", 1))
        ddlQuerySelect.Items.Add(New ListItem("Books by Selected Author", 2))
        ddlQuerySelect.Items.Add(New ListItem("Customers Who Purchased Selected Book", 3))
        ddlQuerySelect.Items.Add(New ListItem("Customer Orders Including Total Price (Broken)", 4))
        ddlQuerySelect.Items.Add(New ListItem("Customer and Number of Books Ordered", 5))
        ddlQuerySelect.Items.Add(New ListItem("Books by Author's Last Name (Broken)", 6))
        ddlQuerySelect.Items.Add(New ListItem("Add a new Category", 7))
        ddlQuerySelect.Items.Add(New ListItem("Add a new Book", 8))
        ddlQuerySelect.Items.Add(New ListItem("Add category to Book", 9))
        ddlQuerySelect.Items.Add(New ListItem("Delete a Book", 10))
        ddlQuerySelect.Items.Add(New ListItem("List Books by Author (Stored Proc)", 11))

    End Sub

#End Region
End Class


