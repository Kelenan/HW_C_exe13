/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число ");
long num = long.Parse(Console.ReadLine() ?? "");    // при вводе больших чисел ошибка: Value was either too large or too small for an Int32. Поэтому стоит long
    
if (num <= 99) 
{
    Console.WriteLine($"num = {num}, resalt = третьей цифры нет");
    return;
}

long s = 1;  //переменная на которую делится N значное число 
while(true)
{
    if (num >= 1000 * s)  //находим насколько нужно разделить число перед нахождением отстатка отделения, чтоб осталось 3 первых цыфры
        s = s * 10;
    else break;
}
    
long a2 = num / s;
a2 = a2 % 10;

Console.WriteLine($"num = {num}, resalt = {a2}");

