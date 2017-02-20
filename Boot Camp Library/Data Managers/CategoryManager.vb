Public Class CategoryManager
    Public Shared Function GetCategory() As DataLibrary.Category()
        Using ctx As New DataLibrary.jburrowsEntities

            Dim obj = (From c In ctx.Categories Where
                       c.Archived = 0
                       Select c).ToArray
            Return obj
        End Using
    End Function

End Class
