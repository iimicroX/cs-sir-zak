Module Module1

    Sub Main()

        Dim str1 As String
        Dim all As String
        Dim currentc As Char
        Dim Count As Integer
        Dim flag As Boolean

        str1 = ""
        all = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        currentc = ""
        Count = 0
        flag = True

        Console.Write("Enter String: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)

        For Count = 1 To Len(all)
            currentc = Mid(all, Count, 1)
            If InStr(str1, currentc) = 0 Then
                flag = False
                Exit For
            End If
        Next

        If flag = True Then
            Console.WriteLine("String entered has all alphabets")
            Console.ReadLine()

        Else
            Console.WriteLine("entered string doesnt have all alphabets")
            Console.ReadKey()
        End If

    End Sub

End Module
