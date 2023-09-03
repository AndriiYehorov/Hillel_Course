int num = 319;

int num1 = num % 10;    // last digit of the number
int num_temp = num / 10; // number without last digit 
int num2 = num_temp % 10; // second digit of the number
num_temp = num_temp / 10;
int num3 = num_temp % 10; // first digit of the number
Console.Write(num2);
Console.Write(num3);
Console.Write(num1);
Console.ReadKey();