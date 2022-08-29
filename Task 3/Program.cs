//Напишите программу вычисления функции x = f(a)
//Примем f(a) = (4x - 1)/2

double Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    double value = double.Parse(strValue);
    return value;
}
System.Console.WriteLine("Вычислим значение f(a) = (4x - 1)/2");
double number = Prompt("Введите значение x: ");
double result = (4*number - 1)/2;
System.Console.WriteLine($"Результат вычисления равен {result}");