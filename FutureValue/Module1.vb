Module Module1
    'Program Name:  FutureValue
    'Programmer:    James Pugh
    'Date:  05/27/2017
    'Description: Determines how much to invest today based on desired future value, rate of return and number of years invested.

    Sub Main()
        'Declarations
        Dim decFutureValue As Decimal = 0
        Dim dblRate As Double = 0
        Dim intYears As Integer = 0
        Dim DecPresentValue As Decimal = 0

        'Get Input
        Console.Write("what is the desired future amount? ")
        decFutureValue = CDec(Console.ReadLine())
        Console.Write("what is the rate of return? ")
        dblRate = CDbl(Console.ReadLine())
        Console.Write("How many years will the money be invested? ")
        intYears = CInt(Console.ReadLine())

        'Calculate Present Value
        DecPresentValue = CDec(decFutureValue / (1 + dblRate) ^ intYears)

        'Display Present Value
        Console.WriteLine()
        Console.WriteLine("You will need to invest " & DecPresentValue)
        Console.WriteLine()

        'Hold Program on the screen
        Console.Write("Press the enter key to terminate the program.")
        Console.Read()

    End Sub

End Module
