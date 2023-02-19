Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int secondRank = num / 10 % 10;
Console.WriteLine($"Вторая цифра {secondRank} ");