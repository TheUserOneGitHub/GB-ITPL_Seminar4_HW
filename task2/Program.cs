// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter an integer number");
long number = Convert.ToInt64(Console.ReadLine());

if (number < 0)
{
    number = number * -1;
}

long numberDigitTest = number;
long digit = 0;
while (numberDigitTest > 0)
{
    numberDigitTest = numberDigitTest / 10;
    digit++;
}
if (number == 0)
{
    Console.WriteLine($"The number is 1 digit");
}
else
{
    Console.WriteLine($"The number is {digit} digit(s)");
}

long[] array = new long[digit];
// Console.WriteLine($"The array length is {array.Length}");

long arrayNum = 1;
long i = 0;

while (i < digit)
{
    arrayNum = number % 10;
    // Console.WriteLine(arrayNum);
    array[i] = arrayNum;
    number = number / 10;
    i++;
}

long position = 0;
long sum = 0;
while (position < digit)
{
    sum = sum + array[position];
    position++;
}

Console.WriteLine($"The sum of digits of number is {sum}");