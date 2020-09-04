Option Strict On
Option Explicit On
Option Compare Text
Module BestCalculatorLC

    Sub Main()
        Dim str As String
        Dim spl(5) As Object
        Dim splitstr1 As Double
        Dim splitstr2 As String
        Dim splitstr3 As Double
        Dim splitstr4 As String
        Dim splitstr5 As Double
        Dim goodData As Boolean

        Console.WriteLine("This is a calculator")
        Do
            Do
                Try
                    str = Console.ReadLine()
                    spl = Split(str, " ")
                    splitstr1 = CDbl(spl(0))
                    splitstr2 = CStr(spl(1))
                    splitstr3 = CDbl(spl(2))
                    Try
                        splitstr4 = CStr(spl(3))
                    Catch
                        splitstr4 = Nothing
                    End Try
                    Try
                        splitstr5 = CDbl(spl(4))
                    Catch
                        splitstr5 = Nothing
                    End Try

                    goodData = True
                Catch
                    goodData = False
                End Try
                If splitstr4 > CStr(Nothing) And splitstr5 = Nothing Then
                    goodData = False
                End If
                If goodData = False Then Console.WriteLine("Example format: # + # / #")

            Loop Until goodData = True
            'addition
            If splitstr2 = "+" And splitstr4 = "+" Then
                Console.WriteLine(splitstr1 + splitstr3 + splitstr5)
            ElseIf splitstr2 = "+" And splitstr4 = "-" Then
                Console.WriteLine(splitstr1 + splitstr3 - splitstr5)
            ElseIf splitstr2 = "+" And splitstr4 = "*" Then
                Console.WriteLine(splitstr1 + splitstr3 * splitstr5)
            ElseIf splitstr2 = "+" And splitstr4 = "/" Then
                Console.WriteLine(splitstr1 + splitstr3 / splitstr5)
            ElseIf splitstr2 = "+" And splitstr4 = "^" Then
                Console.WriteLine(splitstr1 + splitstr3 ^ splitstr5)
            End If
            'subtraction
            If splitstr2 = "-" And splitstr4 = "+" Then
                Console.WriteLine(splitstr1 - splitstr3 + splitstr5)
            ElseIf splitstr2 = "-" And splitstr4 = "-" Then
                Console.WriteLine(splitstr1 - splitstr3 - splitstr5)
            ElseIf splitstr2 = "-" And splitstr4 = "*" Then
                Console.WriteLine(splitstr1 - splitstr3 * splitstr5)
            ElseIf splitstr2 = "-" And splitstr4 = "/" Then
                Console.WriteLine(splitstr1 - splitstr3 / splitstr5)
            ElseIf splitstr2 = "-" And splitstr4 = "^" Then
                Console.WriteLine(splitstr1 - splitstr3 ^ splitstr5)
            End If
            'multiplication
            If splitstr2 = "*" And splitstr4 = "+" Then
                Console.WriteLine(splitstr1 * splitstr3 + splitstr5)
            ElseIf splitstr2 = "*" And splitstr4 = "-" Then
                Console.WriteLine(splitstr1 * splitstr3 - splitstr5)
            ElseIf splitstr2 = "*" And splitstr4 = "*" Then
                Console.WriteLine(splitstr1 * splitstr3 * splitstr5)
            ElseIf splitstr2 = "*" And splitstr4 = "/" Then
                Console.WriteLine(splitstr1 * splitstr3 / splitstr5)
            ElseIf splitstr2 = "*" And splitstr4 = "^" Then
                Console.WriteLine(splitstr1 * splitstr3 ^ splitstr5)
            End If
            'division
            If splitstr2 = "/" And splitstr4 = "+" Then
                Console.WriteLine(splitstr1 / splitstr3 + splitstr5)
            ElseIf splitstr2 = "/" And splitstr4 = "-" Then
                Console.WriteLine(splitstr1 / splitstr3 - splitstr5)
            ElseIf splitstr2 = "/" And splitstr4 = "*" Then
                Console.WriteLine(splitstr1 / splitstr3 * splitstr5)
            ElseIf splitstr2 = "/" And splitstr4 = "/" Then
                Console.WriteLine(splitstr1 / splitstr3 / splitstr5)
            ElseIf splitstr2 = "/" And splitstr4 = "^" Then
                Console.WriteLine(splitstr1 / splitstr3 ^ splitstr5)
            End If
            'powers
            If splitstr2 = "^" And splitstr4 = "+" Then
                Console.WriteLine(splitstr1 ^ splitstr3 + splitstr5)
            ElseIf splitstr2 = "^" And splitstr4 = "-" Then
                Console.WriteLine(splitstr1 ^ splitstr3 - splitstr5)
            ElseIf splitstr2 = "^" And splitstr4 = "*" Then
                Console.WriteLine(splitstr1 ^ splitstr3 * splitstr5)
            ElseIf splitstr2 = "^" And splitstr4 = "/" Then
                Console.WriteLine(splitstr1 ^ splitstr3 / splitstr5)
            ElseIf splitstr2 = "^" And splitstr4 = "^" Then
                Console.WriteLine(splitstr1 ^ splitstr3 ^ splitstr5)
            End If
            'two numbers only.
            If splitstr2 = "+" And splitstr4 = Nothing Then
                Console.WriteLine(splitstr1 + splitstr3)
            ElseIf splitstr2 = "-" And splitstr4 = Nothing Then
                Console.WriteLine(splitstr1 - splitstr3)
            ElseIf splitstr2 = "*" And splitstr4 = Nothing Then
                Console.WriteLine(splitstr1 * splitstr3)
            ElseIf splitstr2 = "/" And splitstr4 = Nothing Then
                Console.WriteLine(splitstr1 / splitstr3)
            ElseIf splitstr2 = "^" And splitstr4 = Nothing Then
                Console.WriteLine(splitstr1 ^ splitstr3)
            End If


            Console.WriteLine(vbNewLine)
            'Console.ReadLine()
            'Console.Clear()

        Loop
    End Sub

End Module
