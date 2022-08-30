//Написать программу, принимающую на вход число и определяющую, является ли оно четным

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int number = Prompt("Введите любое целое число: ");

if (number % 2 == 0)
{
    System.Console.WriteLine($"Число {number} четное.");
}
else
{
    System.Console.WriteLine($"Число {number} нечетное.");
}

