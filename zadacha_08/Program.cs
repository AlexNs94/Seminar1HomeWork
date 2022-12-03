Console.Clear();

Console.Write("Введите N число : ");

int number = int.Parse(Console.ReadLine());

int count = 0;

if (number > 0)
{
    count = (number % 2 == 0);
    while ( count > 0);
    Console.Write ($"count") ; 
    count++;
}
else 
{
    Console.Write ("У отрицательных чисел , нет четных чисел ");
}