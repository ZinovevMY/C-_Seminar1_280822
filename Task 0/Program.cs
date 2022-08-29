int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int number = Prompt("Введите любое целое число: ");
int sqrNumber = number * number;
System.Console.WriteLine($"Квадрат числа {number} равен {sqrNumber}");
