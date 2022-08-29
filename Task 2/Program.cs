int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int dayNumber = Prompt("Введите интересующий номер дня недели: ");

if (dayNumber < 1 || dayNumber > 7)
{
    System.Console.WriteLine("Нет такого дня недели!");
}
else
{
    System.Console.WriteLine(days[dayNumber-1]);
}