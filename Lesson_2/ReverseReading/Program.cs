
int num = 629;

int num1 = num % 10;    // последняя цыфра числа
int num_temp = num / 10; // число без последней цыфры 
int num2 = num_temp % 10; // вторая цыфра числа
num_temp = num_temp / 10;
int num3 = num_temp % 10; // первая цыфра числа
Console.Write(num1);
Console.Write(num2);
Console.Write(num3);
Console.ReadKey();
