// Напишите программу, которая принимает на вход число и выдает, является ли число четным (делится ли оно на два без остатка)

Console.WriteLine("Inter Number ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0) 
{
    Console.WriteLine($"even number {number}");
}
else
{
    Console.WriteLine($"odd number {number}");
}