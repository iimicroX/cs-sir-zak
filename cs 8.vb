Module Module1

    Sub Main()

        Dim str1 As String
        Dim chara As Char
        Dim counter As Integer
        Dim currentc As Char
        Dim str2 As String

        str1 = ""
        chara = ""
        str2 = ""
        currentc = ""
        counter = 0

        Console.Write("please enter word: ")
        str1 = Console.ReadLine

        chara = Left(str1, 1)

        For counter = 2 To Len(str1)

            currentc = Mid(str1, counter, 1)

            If currentc = chara Then
                currentc = "*"

            End If
            str2 = str2 & currentc


        Next

        Console.Write(chara & str2)
        Console.ReadLine()




    End Sub

End Module
