Console.Clear();
int Prompt(string message)
{
Console.Write("Введите любое число: ");
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int GetThirdRank(int num)
{
   while (num > 999)
   {
      num /= 10;
   }
   return num % 10;
}

bool ValidateNumber (int num) 
{
   if (num < 100)
   {
      Console.WriteLine("Третий цифры нет");
      return false;
   }
   return true;
}    

int num = Prompt("Введите число: ");
if (ValidateNumber(num))
{
   Console.WriteLine(GetThirdRank(num));
}  