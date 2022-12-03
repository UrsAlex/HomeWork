// Напишите программу, которая на вход принимает два числа и выдает? какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
    Console.WriteLine($"Первое число {numberA} больше второго числа {numberB}");
else 
    Console.WriteLine($"второе число {numberB} больше первого числа {numberA}");
