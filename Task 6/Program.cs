//Написать программу, которая на вход принимает значение, а на выходе выдает обратное значение

double Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    double value = double.Parse(strValue);
    return value;
}

double number = Prompt("Введите любое положительное число: ");

if (number > 0)
{
    System.Console.WriteLine($"Обратным значение числа {number} является {1/number}");
}
else
{
    System.Console.WriteLine("Вы ввели неверное число!");
}
