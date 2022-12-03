// Напишите программу, которая принимает на вход число (N), а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int numberA = 2;
while (numberA < number)
   {
    Console.WriteLine($"{numberA}");
    numberA += 2;
   } 