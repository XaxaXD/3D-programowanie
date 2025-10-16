
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
    if (b != 0
        && a >= 0)
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
        Console.WriteLine("Nie można dzielić przez zero lub pierwiastek ujemny");
}

int Operation4(int a, int b, out int result)
{
    result = 0;
    if (b == 0)
        return 1;
    else if (a < 0)
        return 2;
    else
    {
        result = a / b + (int)Math.Sqrt(a);
        return 0;
    }
}

void ErrorsV4()
{
    string strFirstNumber, strSecondNumber;
    int firstNumber, secondNumber;
    int result;

    bool repeatAgain;
    do
    {
        repeatAgain = false;
        Console.WriteLine("Podaj pierwszą liczbę");
        strFirstNumber = Console.ReadLine();

        Console.WriteLine("Podaj drugą liczbę");
        strSecondNumber = Console.ReadLine();

        firstNumber = int.Parse(strFirstNumber);
        secondNumber = int.Parse(strSecondNumber);

        int errorResult = Operation4(firstNumber, secondNumber, out result);
        if (errorResult == 0)
            Console.WriteLine("Wynik operacji: " + result);
        else if (errorResult == 1)
        {
            Console.WriteLine("Nie można dzielić przez zero");
            repeatAgain = true;
        }
        else if (errorResult == 2)
            Console.WriteLine("Pierwiastek ujemny");
    } while (repeatAgain);
}

void ErrorsV5()
{
    string strFirstNumber, strSecondNumber;
    int firstNumber, secondNumber, result;

    Console.WriteLine("Podaj pierwszą liczbę");
    strFirstNumber = Console.ReadLine();

    Console.WriteLine("Podaj drugą liczbę");
    strSecondNumber = Console.ReadLine();

    firstNumber = int.Parse(strFirstNumber);
    secondNumber = int.Parse(strSecondNumber);

    try
    {
        result = firstNumber / secondNumber;
        Console.WriteLine("Wynik dzielenia: " + result);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Wystąpił błąd: " + ex.Message);
    }
}

int Div6(int a, int b)
{
    int result;
    result = a / b;
    return result;
}

void ErrorsV6()
{
    string strFirstNumber, strSecondNumber;
    int firstNumber, secondNumber, result;

    Console.WriteLine("Podaj pierwszą liczbę");
    strFirstNumber = Console.ReadLine();

    Console.WriteLine("Podaj drugą liczbę");
    strSecondNumber = Console.ReadLine();

    firstNumber = int.Parse(strFirstNumber);
    secondNumber = int.Parse(strSecondNumber);

    try
    {
        result = Div6(firstNumber, secondNumber);
        Console.WriteLine("Wynik dzielenia: " + result);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Wystąpił błąd: " + ex.Message);
    }

}

int Operation7(int a, int b)
{
    if (a < 0)
        throw new Exception("Pierwiastek ujemny");

    int result;
    result = a / b + (int)Math.Sqrt(a);
    return result;
}

void ErrorsV7()
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

    try
    {
        result = Operation7(firstNumber, secondNumber);
        Console.WriteLine("Wynik operacji: " + result);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Wystąpił błąd: " + ex.Message);
    }
}

int Operation8(int a, int b)
{
    if (a < 0)
        throw new Exception("Pierwiastek ujemny");

    int result;
    result = a / b + (int)Math.Sqrt(a);
    return result;
}

void ErrorsV8()
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

    try
    {
        result = Operation8(firstNumber, secondNumber);
        Console.WriteLine("Wynik operacji: " + result);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Nie można dzielić przez zero: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Wystąpił błąd: " + ex.Message);
    }
    
}

ErrorsV8();
