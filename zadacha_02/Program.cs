Console.Clear();

Console.Write("Введите первое число: ");

int number1 = int.Parse (Console.ReadLine());

Console.Write("Введите второе число: ");

int number2 = int.Parse (Console.ReadLine());

if (number1 > number2)
{
   
    {
        Console.Write($"Максимальное значение {number1} , минимальное значение {number2}" );
        
    }
}
else
{
   
    {
       Console.Write($"Максимальное значение {number2} , минимальное значение {number1}" );
    }
}
25