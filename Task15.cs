//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число");
string input1 = Console.ReadLine()!;
int number = int.Parse(input1);

if ((number == 1) || (number == 2) || (number == 3) || (number == 4) || (number == 5))
{
    Console.WriteLine("Будний день");
}
if ((number == 6) || (number == 7))
{
    Console.WriteLine("Выходной день");
}