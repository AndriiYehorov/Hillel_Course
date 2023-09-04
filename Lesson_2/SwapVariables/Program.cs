using System;

byte num1 = 3;
byte num2 = 5;
Console.WriteLine("Первый метод!");
Console.Write(num1);
Console.WriteLine(num2);
//1
byte temp = (byte) (num1 * num2);
num1 = (byte) (temp / num1);
num2 = (byte) (temp / num2);
Console.Write(num1);
Console.WriteLine(num2);

//2
byte num3 = 6;
byte num4 = 5;
Console.WriteLine("Второй метод!");
Console.Write(num3);
Console.WriteLine(num4);
(num3, num4) = (num4, num3); //Использование кортежей, не очень понятно что это, но такой вариант есть
Console.Write(num3);
Console.WriteLine(num4);

Console.ReadKey();