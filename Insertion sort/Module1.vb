Module Module1

    Sub Main()
        Dim MyArray(0 To 6) As String
        Dim temp As Integer
        Dim maxsize As Integer
        Dim insert As Integer
        maxsize = 7

        For count = 0 To 6
            MyArray(count) = Console.ReadLine()
        Next

        For count = 0 To maxsize - 1
            temp = MyArray(count)
            insert = count
            While insert > 0 And MyArray(insert - 1) >= temp
                MyArray(insert) = MyArray(insert - 1)
                insert = insert - 1
            End While
            MyArray(insert) = temp
        Next

        For count = 0 To 6
            Console.WriteLine(count & ": " & MyArray(count))
        Next
        Console.ReadKey()
    End Sub

End Module
