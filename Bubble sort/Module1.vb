Module Module1

    Sub main()
        Dim MyArray(0 To 4) As Integer
        Dim swapped As Boolean
        Dim temp As Integer
        Dim maxsize As Integer
        maxsize = 5

        For count = 0 To 4
            Console.Write(" Enter the MyArray of a student: ")
            MyArray(count) = Console.ReadLine()
        Next

        Do
            swapped = False
            For count = 1 To maxsize - 1

                If MyArray(count + 1) < MyArray(count) Then
                    temp = MyArray(count)
                    MyArray(count) = MyArray(count + 1)
                    MyArray(count + 1) = temp
                    swapped = True
                End If
            Next
            maxsize = maxsize - 1
        Loop Until swapped = False


        For count = 1 To 5
            Console.WriteLine(count & ": " & MyArray(count))
        Next
        Console.ReadKey()
    End Sub

End Module
