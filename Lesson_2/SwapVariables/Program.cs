// способы поменять местами переменные, не включая способы рассмотренные на уроке
byte a = 3;
byte b = 5;

byte c = (byte) (a * b);
a = (byte) (c / a);
b = (byte) (c / b);
Console.WriteLine(a);
Console.WriteLine(b);