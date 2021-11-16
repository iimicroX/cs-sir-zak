Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim lc As String
        Dim fc As String
        Dim ns As String
        Dim ns2 As String

        str1 = ""
        str2 = ""
        lc = ""
        fc = ""
        ns = ""
        ns2 = ""

        Console.Write("Enter string 1 for the calculations: ")
        str1 = Console.ReadLine
        Console.Write("Enter string 2 for the calculations: ")
        str2 = Console.ReadLine

        lc = Left(str1, 2)
        fc = Left(str2, 2)
        ns = Mid(str1, 3, Len(str1) - 2)
        ns2 = Mid(str2, 3, Len(str2) - 2)

        Console.Write((fc & ns) & " " & (lc & ns2))
        Console.ReadLine()





    End Sub

End Module
