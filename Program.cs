bool NumberInInterval(int value, int min, int max)
{
if (value >= min && value <= max)
 return true;
else 
{
Console.WriteLine($"Ошибка! Число должно находиться в интервале от {min} до {max}!");
 return false;
}   
}
Console.Clear();
string s;
int n;
do
{
Console.Write("Веедите пятизначное число: ");
s = Console.ReadLine();
n = Convert.ToInt32(s);
} while (!NumberInInterval(n, 10000, 99999));
if ((n / 10000 == n % 10) && (n % 10000 / 1000 == n % 100 / 10))
    Console.WriteLine($"Число {n} - палиндром.");
else
    Console.WriteLine($"Число {n} - НЕ палиндром.");
