Module Module1
    Sub Main()
        ColourMixing()
    End Sub
    Sub one()
        Timer()
        Console.WriteLine("Task 1")
        Console.WriteLine("Ewan")
        Console.WriteLine("9E")
        Console.Read()
        Console.Clear()
        ASub()
    End Sub
    Sub ASub()
        Console.Read()
        Console.WriteLine("Task 2")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.BackgroundColor = ConsoleColor.White
        Console.Clear()
        Console.WriteLine("Ewan")
        Console.Read()
        Console.Clear()
        AnotherSub()
    End Sub
    Sub AnotherSub()
        Console.Read()
        Console.WriteLine("Task 2")
        Console.Read()
        NotMain()
    End Sub
    Sub NotMain()

        Dim length As String
        Dim width As String
        Dim height As String

        Console.Read()
        Console.ResetColor()
        Console.WriteLine("What is the length of your cuboid?")
        length = Console.ReadLine()
        Console.WriteLine("What is the width of your cuboid?")
        width = Console.ReadLine()
        Console.WriteLine("What is the height of your cuboid?")
        height = Console.ReadLine()
        Console.WriteLine("Your cuboid has height " & height & ", width " & width & " and length " & length)
        Console.WriteLine("The volume of your cuboid is " & width * height * length)
        Console.Read()
        Console.Clear()

        ASub()
    End Sub
    Sub Timer()
        Dim a As Integer
        Dim time As Integer

        a = 0
        Console.WriteLine("How long do you want to wait for (please type and integer)?")
        time = Console.ReadLine()
        While a < time
            Threading.Thread.Sleep(1000)
            a = a + 1
            Console.WriteLine(a)
        End While
        Console.WriteLine("Time up")
        Console.Read()

    End Sub
    Sub Grading()
        Dim grade As Integer
        Dim asian As String

        Console.WriteLine("Are you Asian? (Write Yes or No with a capital letter to start)")
        asian = Console.ReadLine()
        Console.WriteLine("What was your test score? (out of 100 as an integer)")
        grade = Console.ReadLine()
        If grade >= 75 And asian = "Yes" Then
            Console.WriteLine(" An A, Well done, but not good enough >:(")
            Console.Read()
        ElseIf grade < 75 And grade >= 60 And asian = "Yes" Then
            Console.WriteLine("A B, Not great and nowhere near good enough >:(")
            Console.Read()
        ElseIf grade < 60 And grade >= 35 And asian = "Yes" Then
            Console.WriteLine("A C, You aren't allowed to be here get out and never come back.")
            Console.Read()
        ElseIf grade < 35 And asian = "Yes" Then
            Console.WriteLine("A D,Go to room 36, there's a firing squad there, they very much want to meet you.")
            Console.Read()
        ElseIf grade >= 75 And asian = "No" Then
            Console.WriteLine(" An A, Well done :) you get a medal and infinite money!")
            Console.Read()
        ElseIf grade < 75 And grade >= 60 And asian = "No" Then
            Console.WriteLine("A B, Amazing! All your dreams can come true")
            Console.Read()
        ElseIf grade < 60 And grade >= 35 And asian = "No" Then
            Console.WriteLine("A C, You're just too good, keep on going there buddy :)")
            Console.Read()
        ElseIf grade < 35 And asian = "No" Then
            Console.WriteLine("A D, You did great, keep trying hard")
            Console.Read()
        End If
    End Sub
    Sub High()
        Dim number As Integer
        Dim guess As Integer
        Dim trys As Integer
        Dim high As Integer
        Dim low As Integer

        trys = 1
        Console.WriteLine("We're going to play a higher lower game. I'm going to pick a number between 1 and 100, you have to guess. (enter only integers)")
        Randomize()
        number = Int(Rnd() * 100) + 1
        While True
            Console.BackgroundColor = ConsoleColor.Black
            If trys > 1 Then
                Console.WriteLine("Take another guess")
            Else
                Console.WriteLine("Take a guess.")
            End If
            Console.WriteLine(number)
            guess = Console.ReadLine()
            If number = guess Then
                trys = trys + 1
                Console.WriteLine("Well done!")
                Console.WriteLine("You took " & trys & " attempts!")
                Exit While
            ElseIf number < guess Then
                trys = trys + 1
                high = 0
                While high <> 10
                    high = high + 1
                    Console.WriteLine("Sorry your guess is too high!")
                    Threading.Thread.Sleep(100)
                    Console.Clear()
                    Console.BackgroundColor = ConsoleColor.Black
                    Console.WriteLine("Sorry your guess is too high!")
                    Threading.Thread.Sleep(100)
                    Console.Clear()
                    Console.BackgroundColor = ConsoleColor.Red
                End While
            ElseIf number > guess Then
                trys = trys + 1
                low = 0
                While low <> 10
                    low = low + 1
                    Console.WriteLine("Sorry your guess is too high!")
                    Threading.Thread.Sleep(100)
                    Console.Clear()
                    Console.BackgroundColor = ConsoleColor.Black
                    Console.WriteLine("Sorry your guess is too high!")
                    Threading.Thread.Sleep(100)
                    Console.Clear()
                    Console.BackgroundColor = ConsoleColor.Blue
                End While
            End If
        End While
    End Sub
    Sub ColourMixing()
        Dim colour1 As Integer
        Dim colour2 As Integer
        Dim colour3 As Integer
        Dim yes1 As Char
        Dim hi As Integer
        Dim hi1 As Integer
        Dim hi2 As Integer
        Dim hi3 As Integer
        Dim hi4 As Integer
        Dim not_again As Integer
        Dim again As String

        While not_again = 0
            colour1 = 0
        colour2 = 0
        Console.WriteLine("Hello! Would you like to mix colours?")
        Console.WriteLine("(Type y or n)")
        yes1 = Console.ReadLine()
        While hi <> 1
            If yes1 = "y" Then
                Console.Clear()
                Console.WriteLine("OK cool!")
                hi = 1
            ElseIf yes1 = "n" Then
                Console.Clear()
                Console.WriteLine("OK shut down then or say yes >:(")
                Console.WriteLine("(Type y or n)")
                yes1 = Console.ReadLine()
            Else
                Console.Clear()
                Console.WriteLine("Sorry I don't understand")
                Console.WriteLine("(Type y or n)")
                yes1 = Console.ReadLine()
            End If
        End While
        While hi1 <> 1
            If hi2 <> 1 Then
                Console.Clear()
                Console.WriteLine("Ok let's get started!")
                Console.WriteLine("Choose a colour!")
                Console.WriteLine("---------------------")
                Console.WriteLine("(1) Blue")
                Console.WriteLine("(2) Red")
                Console.WriteLine("(3) Black")
                Console.WriteLine("Type the number on the left!")
                Console.WriteLine("---------------------")
                colour1 = Console.ReadLine()
                hi2 = 1
            Else
                Console.Clear()
                Console.WriteLine("Please listen to me")
                Console.WriteLine("Choose a colour!")
                Console.WriteLine("---------------------")
                Console.WriteLine("(1) Blue")
                Console.WriteLine("(2) Red")
                Console.WriteLine("(3) Black")
                Console.WriteLine("Type the number on the left!")
                Console.WriteLine("---------------------")
                colour1 = Console.ReadLine()
            End If
            If colour1 = 1 Or colour1 = 2 Or colour1 = 3 Then
                hi1 = 1
            Else
                Console.WriteLine("Nothing is happening")
            End If
        End While
        While hi3 <> 1
            If hi4 <> 1 Then
                Console.Clear()
                Console.WriteLine("Now a second colour!")
                Console.WriteLine("Choose a colour!")
                Console.WriteLine("---------------------")
                Console.WriteLine("(1) Blue")
                Console.WriteLine("(2) Red")
                Console.WriteLine("(3) Black")
                Console.WriteLine("Type the number on the left!")
                Console.WriteLine("---------------------")
                colour2 = Console.ReadLine()
                hi4 = 1
            Else
                Console.Clear()
                Console.WriteLine("Please listen to me")
                Console.WriteLine("Choose a colour!")
                Console.WriteLine("---------------------")
                Console.WriteLine("(1) Blue")
                Console.WriteLine("(2) Red")
                Console.WriteLine("(3) Black")
                Console.WriteLine("Type the number on the left!")
                Console.WriteLine("---------------------")
                colour2 = Console.ReadLine()
            End If
            If colour2 = 1 Or colour2 = 2 Or colour2 = 3 Then
                hi3 = 1
            Else
                Console.WriteLine("Nothing is happening")
            End If
        End While
        colour3 = colour1 * colour2
            If colour3 = 1 Then
                Console.BackgroundColor = ConsoleColor.Blue
                Console.WriteLine("--------------")
                Console.WriteLine("You made blue!")
                Console.WriteLine("--------------")
                Console.Read()
                Console.ResetColor()
            ElseIf colour3 = 2 Then
                Console.BackgroundColor = ConsoleColor.Magenta
                Console.WriteLine("-----------------")
                Console.WriteLine("You made magenta!")
                Console.WriteLine("-----------------")
                Console.Read()
                Console.ResetColor()
            ElseIf colour3 = 3 Then
                Console.BackgroundColor = ConsoleColor.DarkBlue
                Console.WriteLine("-------------------")
                Console.WriteLine("You made dark blue!")
                Console.WriteLine("-------------------")
                Console.Read()
                Console.ResetColor()
            ElseIf colour3 = 4 Then
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("-------------")
                Console.WriteLine("You made red!")
                Console.WriteLine("-------------")
                Console.Read()
                Console.ResetColor()
            ElseIf colour3 = 6 Then
                Console.BackgroundColor = ConsoleColor.DarkRed
                Console.WriteLine("------------------")
                Console.WriteLine("You made dark red!")
                Console.WriteLine("------------------")
                Console.Read()
                Console.ResetColor()
            ElseIf colour3 = 9 Then
                Console.BackgroundColor = ConsoleColor.Black
                Console.WriteLine("--------------------")
                Console.WriteLine("You made dark black!")
                Console.WriteLine("--------------------")
                Console.Read()
                Console.ResetColor()
            End If
            Console.WriteLine("Would you like to mix again?(y or n)")
            Console.Read()
            again = Console.ReadLine()
            If again = "y" Then
                Console.WriteLine("Ok once again!")
                Console.Read()
                Console.Read()
                Console.Clear()
            ElseIf again = "n" Then
                Console.WriteLine("Goodbye then")
                Console.Read()
                Console.Read()
                not_again = 1
            Else
                Console.WriteLine("I'll take that as a Yes!")
                Console.Read()
                Console.Read()
                Console.Clear()
            End If
        End While

    End Sub
End Module