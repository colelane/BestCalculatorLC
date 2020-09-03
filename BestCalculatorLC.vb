Option Strict On
Option Explicit On
Option Compare Text
Module BestCalculatorLC

    Sub Main()
        Dim str As String
        Dim spl(5) As Object
        Dim splitstr1 As Integer
        Dim splitstr2 As String
        Dim splitstr3 As Integer
        Dim splitstr4 As String
        Dim splitstr5 As Integer
        Dim goodData As Boolean

        Do
            Do
                Try
                    str = Console.ReadLine()
                    spl = Split(str, " ")
                    splitstr1 = CInt(spl(0))
                    splitstr2 = CStr(spl(1))
                    splitstr3 = CInt(spl(2))
                    Try
                        splitstr4 = CStr(spl(3))
                        splitstr5 = CInt(spl(4))
                    Catch
                        splitstr4 = Nothing
                        splitstr5 = Nothing
                    End Try

                    goodData = True
                Catch

                    Console.WriteLine("Example format: # + #")
                    goodData = False
                End Try
            Loop Until goodData = True

            If splitstr2 = "+" And splitstr4 = "+" Then
                Console.WriteLine(splitstr1 + splitstr3 + splitstr5)
            ElseIf splitstr2 = "+" And splitstr4 = "-" Then
                Console.WriteLine(splitstr1 + splitstr3 - splitstr5)
            ElseIf splitstr2 = "+" And splitstr4 = "*" Then
                Console.WriteLine(splitstr1 + splitstr3 * splitstr5)
            ElseIf splitstr2 = "+" And splitstr4 = "/" Then
                Console.WriteLine(splitstr1 + splitstr3 + splitstr5)
            End If

            If splitstr2 = "-" And splitstr4 = "+" Then
                Console.WriteLine(splitstr1 - splitstr3 + splitstr5)
            ElseIf splitstr2 = "-" And splitstr4 = "-" Then
                Console.WriteLine(splitstr1 - splitstr3 - splitstr5)
            ElseIf splitstr2 = "-" And splitstr4 = "*" Then
                Console.WriteLine(splitstr1 - splitstr3 * splitstr5)
            ElseIf splitstr2 = "-" And splitstr4 = "/" Then
                Console.WriteLine(splitstr1 - splitstr3 + splitstr5)
            End If

            If splitstr2 = "*" And splitstr4 = "+" Then
                Console.WriteLine(splitstr1 * splitstr3 + splitstr5)
            ElseIf splitstr2 = "*" And splitstr4 = "-" Then
                Console.WriteLine(splitstr1 * splitstr3 - splitstr5)
            ElseIf splitstr2 = "*" And splitstr4 = "*" Then
                Console.WriteLine(splitstr1 * splitstr3 * splitstr5)
            ElseIf splitstr2 = "*" And splitstr4 = "/" Then
                Console.WriteLine(splitstr1 * splitstr3 + splitstr5)
            End If

            If splitstr2 = "/" And splitstr4 = "+" Then
                Console.WriteLine(splitstr1 / splitstr3 + splitstr5)
            ElseIf splitstr2 = "/" And splitstr4 = "-" Then
                Console.WriteLine(splitstr1 / splitstr3 - splitstr5)
            ElseIf splitstr2 = "/" And splitstr4 = "*" Then
                Console.WriteLine(splitstr1 / splitstr3 * splitstr5)
            ElseIf splitstr2 = "/" And splitstr4 = "/" Then
                Console.WriteLine(splitstr1 / splitstr3 + splitstr5)
            End If

            If splitstr2 = "+" And splitstr4 = Nothing Then
                Console.WriteLine(splitstr1 + splitstr3)
            ElseIf splitstr2 = "-" And splitstr4 = Nothing Then
                Console.WriteLine(splitstr1 - splitstr3)
            ElseIf splitstr2 = "*" And splitstr4 = Nothing Then
                Console.WriteLine(splitstr1 * splitstr3)
            ElseIf splitstr2 = "/" And splitstr4 = Nothing Then
                Console.WriteLine(splitstr1 / splitstr3)
            End If



            Console.ReadLine()
                Console.Clear()

            Loop
    End Sub

End Module
