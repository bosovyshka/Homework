//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число");
string input1 = Console.ReadLine()!;
int number = int.Parse(input1);

int secondDigit = ((number % 100) - (number % 10)) / 10 ;
{
    Console.WriteLine(secondDigit);
}
