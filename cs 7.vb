Module Module1

    Sub Main()

        Dim str1 As String
        Dim str2 As String
        Dim fc As String
        Dim lc As String

        str1 = ""
        str2 = ""
        fc = ""
        lc = ""

        Console.Write("please enter string ")
        str1 = Console.ReadLine

        If Len(str1) < 2 Then
            Console.WriteLine(str1)
            Console.ReadLine()
        Else
            fc = Right(str1, 2)
            lc = Left(str1, 2)

            Console.WriteLine(lc & fc)
            Console.ReadLine()


        End If



    End Sub

End Module
