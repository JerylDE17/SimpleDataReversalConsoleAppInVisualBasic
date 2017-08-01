Module Module1

    Sub Main()

        Console.WriteLine("Data Reversal Console App")

        Console.Write("What is your First Name?: ")
        Dim firstName As String = getReversedString(Console.ReadLine())

        Console.Write("What is your Last Name?: ")
        Dim lastName As String = getReversedString(Console.ReadLine())

        Console.Write("How old are you?: ")
        Dim age As Integer = getReversedString(Console.ReadLine())

        Console.Write("Where is your Birth Place?: ")
        Dim birthPlace As String = getReversedString(Console.ReadLine())

        DisplayResult(firstName, lastName, age, birthPlace)

        Console.ReadLine()
    End Sub

    Sub DisplayResult(reversedFirstName As String, reversedLastName As String, reversedAge As String, reversedBirthPlace As String)
        Console.Write("Results: ")
        Console.Write("{0} {1} {2} {3}", reversedFirstName, reversedLastName, reversedAge, reversedBirthPlace)
    End Sub

    Function getReversedString(ByVal message As String) As String
        Dim messageArray As Char() = message.ToCharArray()
        Array.Reverse(messageArray)
        Return String.Concat(messageArray)
    End Function

End Module
