// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//456 -> 5
//782 -> 8
//918 -> 1 
int num2(int number)
{
    int firstCouple = number / 10;
    int firstDigit = number / 100;
    int result =(firstCouple - (firstDigit*10));
    return result;
}

Console.WriteLine("введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"{number} -> {num2(number)}");
