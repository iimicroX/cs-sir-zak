Module Module1


    Sub Main()
        Dim str1 As String
        Dim alpha As Integer
        Dim alphabets As String
        Dim numbers As String
        Dim digits As Integer
        Dim other As Integer
        Dim counter As Integer
        Dim current As Char

        str1 = ""
        alpha = 0
        counter = 0
        digits = 0
        alphabets = ("a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z")
        numbers = ("1,2,3,4,5,6,7,8,9")
        current = ("")



        Console.Write(" please enter sentence")
        str1 = Console.ReadLine


        For counter = 1 To Len(str1)

            current = Mid(str1, counter, 1)


            If InStr(alphabets, current) > 0 Then
                alpha = alpha + 1
            ElseIf InStr(numbers, current) > 0 Then
                digits = digits + 1

            Else : other = other + 1

            End If
        Next counter

        Console.WriteLine("Number of alphabets: " & alpha)
        Console.ReadKey()
        Console.WriteLine("Number of other: " & other)
        Console.ReadKey()
        Console.WriteLine("Number of digits: " & digits)
        Console.ReadKey()


    End Sub

End Module
