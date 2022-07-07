void InputAndOutput()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма цифр числа {number} равна {SumDigits(number)}");
}

int SumDigits(int number)
{
    int result = number % 10;
    while (number > 0)
    {
        number = number / 10;
        result = result + number % 10;
    }
    return result;
}
InputAndOutput();