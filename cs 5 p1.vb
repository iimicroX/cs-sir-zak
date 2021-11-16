Module Module1

    Sub Main()

        'declare
        Dim str1 As String
        Dim currentc As String
        Dim Counter As Integer
        Dim nov As Integer
        Const vowels = "a,e,i,o,u"

        'initalize 
        str1 = ""
        currentc = ""
        nov = 0
        Counter = 0

        'input 
        Console.Write("Enter string")
        str1 = Console.ReadLine

        'process
        For Counter = 1 To Len(str1)
            currentc = Mid(str1, Counter, 1)
            If InStr(vowels, currentc) > 0 Then
                nov = nov + 1
            End If
        Next

        Console.WriteLine("COUNT OF VOWELS ARE " & nov)
        Console.ReadKey()
    End Sub

End Module
