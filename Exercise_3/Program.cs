Console.Clear();
int Prompt(string message)
{
Console.Write("Введите любое число: ");
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekDay(int num)
{
    if (num > 0 && num <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}
int weekDay = Prompt ("Введите любое число: ");
if (ValidateWeekDay(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это не выходной день");
    }
}