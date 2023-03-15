// int Factorial(int n)
// {
//     // Базовый случай - случай выхода из рекурсии
//     if (n == 1) return 1; // факториал 1=1

//     // рекурсивный случай - задание рекурсии (вызов функции внутри функции)
//     return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(4));


// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// Console.WriteLine("Ввведите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return end.ToString();
//     return (start + "," +  PrintNumbers(start + 1, end));

// }
// Console.WriteLine(PrintNumbers(1,N));

// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Ввведите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     if(num==0)return 0;
//     return (num % 10 + SumNumbers(num / 10));
 
// }
// Console.WriteLine(SumNumbers(number));

// Задача 69: Напишите программу, которая 
// на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



Console.WriteLine("Ввведите число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите степень ");
int B = Convert.ToInt32(Console.ReadLine());
int GetPower(int A, int B)
{   
    if(B==0) return 1;
    if (B==1) return A;
     return (A* GetPower(A,B-1));
}
Console.WriteLine(GetPower(A,B));
