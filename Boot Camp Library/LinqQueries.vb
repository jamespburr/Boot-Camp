Public Module LinqQueries



    Public Function GetBooksList() As List(Of DataLibrary.Book)

        Using ctx As New DataLibrary.jburrowsEntities


            Dim l As List(Of DataLibrary.Book) = (From b As DataLibrary.Book In ctx.Books
                                                  Select b).ToList

            Return l
        End Using
    End Function



    Public Function GetAuthorsList()

        Using ctx As New DataLibrary.jburrowsEntities


            Dim l = (From a As DataLibrary.Author In ctx.Authors
                                                  Select New With {.AuthorID = a.AuthorID, .Fullname = a.FirstName & " " & a.LastName}).ToList

            Return l
        End Using
    End Function

    Public Function GetCustomersList()

        Using ctx As New DataLibrary.jburrowsEntities


            Dim l = (From c As DataLibrary.Customer In ctx.Customers
                                                  Select New With {.CustomerID = c.CustomerID, .Fullname = c.FirstName & " " & c.LastName}).ToList

            Return l
        End Using
    End Function



    Public Function GetBooksByAuthor(authorID As Integer) As List(Of DataLibrary.Book)

        Using ctx As New DataLibrary.jburrowsEntities


            Dim l As List(Of DataLibrary.Book) = (From b As DataLibrary.Book In ctx.Books Join a As DataLibrary.Author In ctx.Authors On b.Author Equals a.AuthorID Where a.AuthorID = authorID
                  Select b).ToList

            Return l
        End Using
    End Function


    Public Function GetCategoriesList() As List(Of DataLibrary.Category)

        Using ctx As New DataLibrary.jburrowsEntities


            Dim l As List(Of DataLibrary.Category) = (From c As DataLibrary.Category In ctx.Categories
                                                  Select c).ToList

            Return l
        End Using
    End Function


    Public Function GetBookCategoriesList(BookID As Integer) As List(Of DataLibrary.BookCategory)

        Using ctx As New DataLibrary.jburrowsEntities


            Dim l As List(Of DataLibrary.BookCategory) = (From bc As DataLibrary.BookCategory In ctx.BookCategories
                     Where bc.Book_ID = BookID
                     Select bc).ToList


            Return l
        End Using
    End Function

    Public Function GetCustomersByBook(bookID As Integer) As List(Of DataLibrary.Customer)

        Using ctx As New DataLibrary.jburrowsEntities


            Dim x As List(Of DataLibrary.Customer) = (From c As DataLibrary.Customer In ctx.Customers
                                                      Join o As DataLibrary.Order In ctx.Orders On c.CustomerID Equals o.Customer
                                                      Join ol As DataLibrary.OrderLine In ctx.OrderLines On o.OrderID Equals ol.Order
                                                      Join b As DataLibrary.Book In ctx.Books On b.BookID Equals ol.Book
                                                      Where b.BookID = bookID Select c).ToList

            Return x
        End Using
    End Function

    Public Function CustomerSales(customer As Integer)

        Using ctx As New DataLibrary.jburrowsEntities

            Dim customerlist = (From c As DataLibrary.Customer In ctx.Customers
                                Join o As DataLibrary.Order In ctx.Orders On c.CustomerID Equals o.Customer
                                Where c.CustomerID = customer
                                Group o By c.CustomerID, c.FirstName, c.LastName Into grp = Group
                                Select
                                    CustomerID,
                                    FirstName,
                                    LastName,
                                    Orders = (From o In grp
                                              Select
                                                o.OrderID,
                                                TotalPrice = o.OrderLines.Sum(Function(ol) ol.Price * ol.Quantity))).ToList()



            Return customerList

        End Using

    End Function

    Public Function CustomerBookHistory(customerID As Integer)

        Dim dt As Date = Date.Today
        dt = dt.AddMonths(-2)

        Using ctx As New DataLibrary.jburrowsEntities

            Dim bookList = (From c As DataLibrary.Customer In ctx.Customers
                            Join o As DataLibrary.Order In ctx.Orders On c.CustomerID Equals o.Customer
                            Join ol As DataLibrary.OrderLine In ctx.OrderLines On o.OrderID Equals ol.Order
                            Join b As DataLibrary.Book In ctx.Books On ol.Book Equals b.BookID
                            Where c.CustomerID = customerID And o.OrderDate > dt
                            Group b By c.FirstName, c.LastName Into grp = Group
                            Select New With {.Firstname = FirstName, .LastName = LastName, .NumberOfBooks = grp.Count}).ToList()

            Return bookList

        End Using

    End Function



    Public Function BooksByAuthor()

        Using ctx As New DataLibrary.jburrowsEntities

            Dim bookList = (From a As DataLibrary.Author In ctx.Authors
                            Join b As DataLibrary.Book In ctx.Books On a.AuthorID Equals b.Author
                            Group b By a.FirstName, a.LastName Into grp = Group
                            Select
                            FirstName,
                            LastName,
                            Books = (From b In grp
                                     Select b.Title)).ToList

            Return bookList
        End Using

    End Function


    Public Sub AddCategory(Name As String)
        Using ctx As New DataLibrary.jburrowsEntities

            Dim c As New DataLibrary.Category
            c.CategoryName = Name
            ctx.Categories.Add(c)
            ctx.SaveChanges()

        End Using


    End Sub

    Public Sub AddBook(title As String, price As Decimal, ISBN As String)

        Using ctx As New DataLibrary.jburrowsEntities

            Dim b As New DataLibrary.Book
            b.Title = title
            b.Cost = price
            b.ISBN = ISBN
            b.DateCreated = DateTime.Now
            ctx.Books.Add(b)
            ctx.SaveChanges()

        End Using

    End Sub


    Public Sub AddBookCategory(selectedBook As Integer, selectedCategory As Integer)

        Using ctx As New DataLibrary.jburrowsEntities

            Dim book As DataLibrary.Book = (From b As DataLibrary.Book In ctx.Books
                                            Select b
                                            Where b.BookID = selectedBook).FirstOrDefault


            Dim category = (From c As DataLibrary.Category In ctx.Categories
                            Select c
                            Where c.CategoryID = selectedCategory).FirstOrDefault



            book.Categories.Add(category)

            ctx.SaveChanges()

        End Using

    End Sub

    Public Sub DeleteBook(selectedBook As Integer)

        Using ctx As New DataLibrary.jburrowsEntities

            Dim OLlist As List(Of DataLibrary.OrderLine) = (From ol As DataLibrary.OrderLine In ctx.OrderLines
                                                           Select ol Where ol.Book = selectedBook).ToList

            For Each listitem As DataLibrary.OrderLine In OLlist

                ctx.OrderLines.Remove(listitem)

            Next

            Dim book As DataLibrary.Book = (From b As DataLibrary.Book In ctx.Books
                                                        Select b
                                                        Where b.BookID = selectedBook).FirstOrDefault

            book.Categories.Clear()

            ctx.Books.Remove(book)

            ctx.SaveChanges()

        End Using

    End Sub


    Public Function ListBooksByAuthor(authorID As Integer)

        Using ctx As New DataLibrary.jburrowsEntities

            Dim bookList = ctx.BooksByAuthor(authorID).ToList()

            Return bookList

        End Using



    End Function

    Public Function AddFile(fridnedlyname As String, filename As String, description As String)

        Using ctx As New DataLibrary.jburrowsEntities

            Dim f As New DataLibrary.File
            f.FriendlyName = fridnedlyname
            f.FileName = f.FileID & filename
            f.FileDescription = description
            f.DateCreated = DateTime.Now
            ctx.Files.Add(f)
            ctx.SaveChanges()
            Return f.FileName
        End Using

    End Function

    Public Function CustomerOrderList()

        Using ctx As New DataLibrary.jburrowsEntities

            Dim customerorders = (From o As DataLibrary.Order In ctx.Orders
                                Join c As DataLibrary.Customer In ctx.Customers On o.Customer Equals c.CustomerID
                                Join os As DataLibrary.OrderStatu In ctx.OrderStatus On o.OrderStatus Equals os.OrderStatusID
                                Join ol As DataLibrary.OrderLine In ctx.OrderLines On o.OrderID Equals ol.Order
                                Group By c.FirstName, c.LastName, c.PhoneNumber, os.OrderStatusName Into grp = Group
                                Select New With {.CustomerName = c.FirstName & " " & c.LastName, .PhoneNumber = c.PhoneNumber}).tolist





            Return customerlist

        End Using

    End Function

End Module
