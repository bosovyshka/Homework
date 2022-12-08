//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Отрицательные числа должны нормально работать.
// 012 
//-645 -> 5
//645 -> 5
//78 -> третьей цифры нет
//3261279 -> 6

Console.WriteLine("Введите число");
string number = Console.ReadLine()!;

if (number.Length < 3 || (number.Length ==3 && number[0] =='-')) 
{
    Console.WriteLine("Третьей цифры нет");
}    
if (number[0]=='-') 
{
    Console.WriteLine(number[3]);
}
else 
{
    Console.WriteLine(number[2]);
}
