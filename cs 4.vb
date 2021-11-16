Module Module1

    Sub Main()
        'declare 
        Dim currentc As Char
        Dim currentc2 As Char
        Dim nextChar As Char
        Dim high As Integer
        Dim Count As Integer
        Dim count1 As Integer
        Dim count2 As Integer
        Dim str1 As String

        'initiallize
        currentc = ""
        str1 = ""
        currentc2 = ""
        high = 0
        Count = 0
        count1 = 0
        count2 = 0
        nextChar = ""

        'input 
        Console.Write("Enter string  ")
        str1 = Console.ReadLine

        'process
        For count1 = 1 To Len(str1)
            nextChar = Mid(str1, count1, 1)
            Count = 0
            ' 2 rounds 
            For count2 = 1 To Len(str1)
                currentc2 = Mid(str1, count2, 1)
                If currentc2 = nextChar Then
                    Count = Count + 1
                End If
                'compare 
            Next count2
            If Count > high Then
                high = Count
                currentc = nextChar
            ElseIf Count = high Then
                currentc = currentc & "," & nextChar
            End If
        Next count1
        Console.WriteLine(currentc & " is highest and appeared  " & high)
        Console.ReadKey()


    End Sub

End Module
