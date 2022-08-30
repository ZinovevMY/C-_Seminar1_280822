//Написать программу, которая принимает 3 числа и выдает максимальное из них

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int num1 = Prompt("Введите первое число: ");
int num2 = Prompt("Введите второе число: ");
int num3 = Prompt("Введите третье число: ");
int max = num1;

if (num1 == num2 && num2 == num3)
{
    System.Console.WriteLine($"Все числа равны.");
}
else
{
    if (num2 > max)
    {
        max = num2;
    }
    else
    {
        if (num3 > max)
        {
            max = num3;
        }
    }
System.Console.WriteLine($"Среди введенных чисел {num1}, {num2}, {num3} максимальным является {max}");
}


