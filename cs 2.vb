Module Module1

    Sub Main()
        'declaration
        Dim Str1 As String
        Dim str2 As String
        Dim currentc As Char
        Dim chara As Char
        Dim charb As Char
        Dim Counter As Integer

        'initiallize 
        Str1 = ""
        str2 = ""
        chara = ""
        charb = ""
        currentc = ""
        Counter = 0

        'process 
        Console.Write("write string ")
        Str1 = Console.ReadLine

        Console.Write("enter character to replace ")
        chara = Console.ReadLine

        Console.Write("enter character to replace with ")
        charb = Console.ReadLine

        For Counter = 1 To Len(Str1)

            currentc = Mid(Str1, Counter, 1)

            If currentc = chara Then
                currentc = charb

            End If

            str2 = str2 & currentc
        Next

        Console.WriteLine(str2)
        Console.ReadKey()

    End Sub

End Module
