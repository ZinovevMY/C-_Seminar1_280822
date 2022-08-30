//Написать программу, принимающую число N и выводящую все четные числа от 1 до N

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int number = Prompt("Веедите любое положительное целое число: ");

for (int i = 2; i <= number; i = i + 2)
{
    System.Console.Write(i + " ");
}
