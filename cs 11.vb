Module Module1

    Sub Main()
        Dim str1 As String
        Dim fn As String
        Dim ln As String
        Dim pb As Integer
        Dim posNot As Integer

        str1 = ""
        fn = ""
        ln = ""
        pb = 0
        posNot = 0


        Console.Write("enter string ")
        str1 = Console.ReadLine()
        pb = InStr(str1, "bad")
        posNot = InStr(str1, "not")

        If posNot < pb Then
            fn = Left(str1, posNot - 1)
            ln = Right(str1, Len(str1) - (pb + 2))
        End If

        Console.WriteLine(fn & "good" & ln)
        Console.ReadKey()



    End Sub

End Module
