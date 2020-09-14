Option Strict On
Option Explicit On
Option Compare Text

'Lane Coleman
'RCET0265
'Fall 2020
'BestCalculatorLC
'https://github.com/colelane/BestCalculatorLC.git
Module BestCalculatorLC

    Sub Main()
        Dim str As String
        Dim spl(4) As String
        Dim splitstr1 As Double
        Dim splitstr2 As String
        Dim splitstr3 As Double
        Dim splitstr4 As String
        Dim splitstr5 As Double
        Dim goodData As Boolean

        Console.WriteLine("This is a calculator. Enter only Q to quit at any time")
        Do
            Do

                Try
                    str = Console.ReadLine()
                    spl = Split(str, " ")
                    splitstr1 = CDbl(spl(0))
                    splitstr2 = (spl(1))
                    splitstr3 = CDbl(spl(2))
                    'The above, starting at str, the line that is input by the user is split up and inserted into an array.
                    'After entering the array in individual pieces, the pieces can be called up and analyzed as numbers
                    'or as a string.  The strings are the operators that are used later on.
                    Try
                        splitstr4 = (spl(3))
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
                    If str = "q" Then
                        Quit()
                        Exit Sub
                    End If
                    goodData = False
                End Try
                If splitstr4 > Nothing And splitstr5 = Nothing Then
                    'this if statement is there to catch the condition: 15 + 15 +10.   where the second + would be splitstr4
                    'but the 10 is misplaced so that nothing shows up in splitstr5.  
                    goodData = False
                End If
                If goodData = False Then
                    Console.WriteLine("Example format: # + # / #")
                End If
                'If any of the catches are triggerd, goodData = false so it loops back to the top.

                If splitstr2 = "+" Or splitstr2 = "-" Or splitstr2 = "*" Or splitstr2 = "/" Then
                    goodData = True
                Else
                    goodData = False
                    Console.WriteLine("Example format: # + # / #")
                End If

                If splitstr4 = "+" Or splitstr4 = "-" Or splitstr4 = "*" Or splitstr4 = "/" Or splitstr4 = Nothing Then
                    goodData = True
                Else
                    goodData = False
                    Console.WriteLine("Example format: # + # / #")
                End If


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
    Sub Quit()
        Console.WriteLine("You entered Q." & vbNewLine &
            "Have a nice day!" & vbNewLine &
            "Press Enter to Exit")

        Console.ReadLine()

    End Sub


End Module
