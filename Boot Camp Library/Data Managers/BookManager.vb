Public Class BookManager

    Public Shared Function GetBooks() As List(Of DataLibrary.Book)
        Using ctx As New DataLibrary.jburrowsEntities

            Dim obj As List(Of DataLibrary.Book) = (From b In ctx.Books
                       Select b).ToList
            Return obj
        End Using
    End Function

    Public Shared Function GetBookByID(bookid As Integer) As DataLibrary.Book

        Using ctx As New DataLibrary.jburrowsEntities

            Dim book As DataLibrary.Book = (From b In ctx.Books Where
                                            b.BookID = bookid
                                            Select b).FirstOrDefault


            Return book
        End Using
    End Function

End Class
