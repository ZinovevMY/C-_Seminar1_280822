//Напишите программу вычисления модуля числа

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int number = Prompt("Введите любое целое число: ");

if (number < 0)
{
    System.Console.WriteLine($"Модуль числа {number} равен {-number}");
}
else
{
    System.Console.WriteLine($"Модуль числа {number} равен {number}");
}