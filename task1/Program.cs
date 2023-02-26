//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Enter a number as the basis for exponentiation");
double numBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a natural number as an exponent");
double numExp = Convert.ToDouble(Console.ReadLine());

if (numExp <= 0)
{
    Console.WriteLine("Enter a natural number as an exponent");
}
else if (numExp % 1 != 0)
{
    Console.WriteLine("Enter a natural number as an exponent");
}

else
{
    double numRes = numBase;
    double Result = 0;

    for (int i = 1; i < numExp; i++)
    {
        Result = numRes * numBase;
        numRes = Result;
    }

    Console.WriteLine(Result);
}