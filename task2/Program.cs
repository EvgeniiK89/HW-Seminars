// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите 1-e число: ");
int numbA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int numbB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int numbC = Convert.ToInt32(Console.ReadLine());

if (numbA>numbB)
{
    if (numbA>numbC)
    {
        Console.WriteLine("max = " + numbA);
    }
    else
    {
        Console.WriteLine("max = " + numbC);
    }
}

else if (numbB > numbC)
{
    Console.WriteLine("max = " + numbB);
}
else
{
    Console.WriteLine("max = " + numbC);
}
