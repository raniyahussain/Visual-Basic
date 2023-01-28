Module Module1
    Structure node
        Dim pointer As Integer
        Dim data As String
    End Structure
    Dim stack(0 To 9) As node
    Dim fp As Integer
    Dim top As Integer

    Sub Main()
        fp = 0
        top = -1
        Dim x As Integer

        For x = 0 To 9
            stack(x).pointer = x + 1
            stack(x).data = ""
        Next
        stack(9).pointer = -1
        push("raniya")
        push("hussain")
        push("syeda")
        pop()
        pop()
        push("heer")
        pop()
        push("rdfgyh")
        push("sdrtyuhbj")
        push("xdtfygubjm")
        push("cftgubj")
        push("xdrtfygubj")
        push("letsgooo")
        pop()
    End Sub

    Sub push(ByVal nm As String)

        If fp <> -1 Then
            stack(fp).data = nm
            top = stack(fp).pointer - 1
            fp = stack(fp).pointer
        Else
            Console.WriteLine("Stack is full")
        End If

        Console.ReadKey()
    End Sub

    Sub pop()

        If fp > 0 Then
            Console.WriteLine(stack(top).data)
            fp = top
            top = top - 1
        Else
            Console.WriteLine("Stack is empty.")
        End If
        Console.ReadKey()
    End Sub

End Module
