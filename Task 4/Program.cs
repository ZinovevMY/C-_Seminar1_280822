//Напишите программу, которая на вход принимает число N, а на выходе выдает все целые числа в промежутке от -N до N

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int number = Prompt("Введите любое положительное целое число: ");

System.Console.WriteLine($"Все целые числа в интервале от -{number} до {number}: ");
for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + " ");
}