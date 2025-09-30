
void ErrorsV1()
{
    string strFirstNumber, strSecondNumber;
    int firstNumber, secondNumber, result;

    Console.WriteLine("Podaj pierwszą liczbę");
    strFirstNumber = Console.ReadLine();

    Console.WriteLine("Podaj drugą liczbę");
    strSecondNumber = Console.ReadLine();

    firstNumber = int.Parse(strFirstNumber);
    secondNumber = int.Parse(strSecondNumber);

    if (secondNumber != 0)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine("Wynik dzielenia: " + result);
    }
    else
    {
        Console.WriteLine("Nie można dzielić przez zero");
    }
}

int? Div(int a, int b)
{
    if (b != 0)
    {
        int result;
        result = a / b;
        return result;
    }
    else
        return null;
}

void ErrorsV2()
{
    string strFirstNumber, strSecondNumber;
    int firstNumber, secondNumber;
    int? result = null;

    Console.WriteLine("Podaj pierwszą liczbę");
    strFirstNumber = Console.ReadLine();

    Console.WriteLine("Podaj drugą liczbę");
    strSecondNumber = Console.ReadLine();

    firstNumber = int.Parse(strFirstNumber);
    secondNumber = int.Parse(strSecondNumber);

    result = Div(firstNumber, secondNumber);
    if (result != null)
        Console.WriteLine("Wynik dzielenia: " + result);
    else
        Console.WriteLine("Nie można dzielić przez zero");
}

int? Operation(int a, int b)
{
    if (b != 0)
    {
        int result;
        result = a / b + (int)Math.Sqrt(a);
        return result;
    }
    else
        return null;
}

void ErrorsV3()
{
    string strFirstNumber, strSecondNumber;
    int firstNumber, secondNumber;
    int? result = null;

    Console.WriteLine("Podaj pierwszą liczbę");
    strFirstNumber = Console.ReadLine();

    Console.WriteLine("Podaj drugą liczbę");
    strSecondNumber = Console.ReadLine();

    firstNumber = int.Parse(strFirstNumber);
    secondNumber = int.Parse(strSecondNumber);

    result = Operation(firstNumber, secondNumber);
    if (result != null)
        Console.WriteLine("Wynik operacji: " + result);
    else
        Console.WriteLine("Nie można dzielić przez zero");
}

