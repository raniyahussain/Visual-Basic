Module Module1
    Dim letter() As Char = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k"}

    Sub Main()
        Dim find As Char = Console.ReadLine
        Console.WriteLine(find & " found at location " & binarysearch(find))
        Console.ReadKey()
    End Sub

    Function binarysearch(ByVal value As Char) As Integer
        Dim middle, LB, UB As Integer
        Dim Found As Boolean = False
        LB = 0
        UB = 8
        While UB >= LB And Found = False
            middle = (LB + UB) \ 2
            If letter(middle) = value Then
                Found = True
                Return middle
            ElseIf value < letter(middle) Then
                UB = middle - 1
            Else
                LB = middle + 1
            End If
        End While
        Return -1
    End Function

End Module
