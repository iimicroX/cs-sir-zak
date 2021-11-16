Module Module1

    Sub Main()


        Dim count As Integer
        Dim str1 As String
        Dim currents As String

        count = 0
        currents = ""
        str1 = ""

        Console.Write("Enter a string ")
        str1 = Console.ReadLine
        LCase(str1)
        If Len(str1) > 2 Then
            If Right(str1, 3) = "ing" Then
                currents = str1 + "ly"
                Console.Write(currents)
                Console.ReadKey()
            Else
                currents = str1 + "ing"
                Console.Write(currents)
                Console.ReadKey()
            End If
        Else
            Console.Write(str1)
            Console.ReadKey()
        End If


    End Sub

End Module
