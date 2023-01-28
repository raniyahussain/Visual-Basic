Module Module1
    Structure CustomerRecord
        Dim CustomerID As Integer
        Dim Data As String
    End Structure
    Dim Customer(0 To 5) As CustomerRecord

    Sub CreateHashTable()
        For count = 0 To 5
            Customer(count).CustomerID = 0
        Next
    End Sub

    Sub InsertRecord(ByVal NewCustomer As CustomerRecord)
        Dim TableFull As Boolean
        Dim index, pointer As Integer
        TableFull = False
        index = Hash(NewCustomer.CustomerID)
        pointer = index

        While Customer(pointer).CustomerID <> 0
            pointer = pointer + 1

            If pointer > 5 Then
                pointer = 0
            End If

            If index = pointer Then
                TableFull = True
            End If
        End While

        If TableFull = False Then
            Customer(pointer).CustomerID = NewCustomer.CustomerID
        Else
            Console.WriteLine("The table is full")
        End If
    End Sub

    Function SearchHashTable(ByVal searchID As Integer) As Integer
        Dim index As Integer
        index = Hash(searchID)

        While Customer(index).CustomerID <> searchID And Customer(index).CustomerID > 0
            index = index + 1

            If index > 5 Then
                index = 0
            End If
        End While

        If Customer(index).CustomerID <> searchID Then
            Return -1
        Else
            Return index
        End If
    End Function

    Function Hash(ByVal KeyVal As Integer, ByVal MaxPos As Integer) As Integer
        Dim indexPos As Integer
        indexPos = KeyVal Mod (MaxPos + 1)
        Return indexPos
    End Function

    Sub Main()
        Call CreateHashTable()
        Dim opt As Integer
        Dim customervalue As CustomerRecord
        Dim searchvalue As Integer
        Console.WriteLine("To insert a record, enter 1.")
        Console.WriteLine("To search a record, enter 2.")

        opt = Console.ReadLine
        If opt = 1 Then
            Console.WriteLine("Enter the data you want to enter:")
            customervalue = Console.ReadLine
            Call InsertRecord(customervalue)
        Else
            Console.WriteLine("Enter the ID you want to search:")
            searchvalue = Console.ReadLine
            Call SearchHashTable(searchvalue)
        End If


    End Sub

End Module
