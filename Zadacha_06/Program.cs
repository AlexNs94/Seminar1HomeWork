Console.Clear();

Console.Write ("Введите четное число : ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine ("Четное!");
}
else
{
     Console.WriteLine ("Нечетное!!");
}