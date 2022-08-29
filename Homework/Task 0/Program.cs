//Написать программу, которая принимает два числа и определяет, какое из них больше, а какое меньше

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int firstNum = Prompt("Введите первое число: ");
int secondNum = Prompt("Введите второе число: ");

if (firstNum > secondNum)
{
    System.Console.WriteLine($"Число {firstNum} большее, а {secondNum} меньшее.");
}
else
{
    if (firstNum < secondNum)
    {
        System.Console.WriteLine($"Число {secondNum} большее, а {firstNum} меньшее.");
    }
    else
    {
            System.Console.WriteLine($"Числа равны!");

    }
}