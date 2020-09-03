Option Strict On
Option Explicit On
Option Compare Text
Module BestCalculatorLC

    Sub Main()
        Dim str As String
        Dim spl(2) As Object
        Dim splitstr1 As Integer
        Dim splitstr2 As String
        Dim splitstr3 As Integer

        Do
            str = Console.ReadLine()

            spl = Split(str, " ")


            splitstr1 = CInt(spl(0))
            splitstr2 = CStr(spl(1))
            splitstr3 = CInt(spl(2))

            If splitstr2 = "+" Then
                Console.WriteLine(splitstr1 + splitstr3)
            ElseIf splitstr2 = "-" Then
                Console.WriteLine(splitstr1 - splitstr3)
            ElseIf splitstr2 = "*" Then
                Console.WriteLine(splitstr1 * splitstr3)
            ElseIf splitstr2 = "/" Then
                Console.WriteLine(splitstr1 / splitstr3)
            End If

            Console.ReadLine()
            Console.Clear()
        Loop

    End Sub

End Module
