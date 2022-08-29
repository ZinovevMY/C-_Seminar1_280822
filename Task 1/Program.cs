int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int firstNum = Prompt("Введите первое число: ");
int secondNum = Prompt("Введите второе число: ");
int sqrFirstNum = firstNum * firstNum;

if (secondNum > firstNum)
{
    if (secondNum == sqrFirstNum)
    {
        System.Console.WriteLine($"Число {secondNum} является квадратом числа {firstNum}");
    }
    else
    {
        System.Console.WriteLine($"Число {secondNum} не является квадратом числа {firstNum}");
    }
}
else
{
    System.Console.WriteLine("Первое введенное число больше второго!");
}
