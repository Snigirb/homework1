// Задача 64:Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//     Console.Write($"{n} ");
//     if (n > 1) ShowNumbers(n - 1);
// }
// Console.WriteLine("Enter num");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num>1)
//     ShowNumbers(num);
// else
//     Console.WriteLine("There are NO natural numbers");



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumber(int m,int n){
//     if(m>n){
//     return SumNumber(m-1,n)+m;
//     }
//     else return n;
// }
// Console.WriteLine("Enter M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter N");
// int n = Convert.ToInt32(Console.ReadLine());
// if(m>n){
//     int number = SumNumber(m,n);
//     Console.Write($"Summ of natural numbers between {m} and {n} is: "+number);
//     }
// else{
//     int number = SumNumber(n,m);
//     Console.Write($"Summ of natural numbers between {m} and {n} is: "+number);//Знаю, немного перегрузил код в этом разделе, но мне так и не понравился тот метод определения бОльшего числа, из-за которого все ругались минут 20 на семинаре
//     }
// Console.WriteLine();



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akkerman(int m,int n){
//     if (m==0)
//         return n+1;
//     else if (m!=0 && n==0)
//         return Akkerman(m-1,1);
//     else
//         return Akkerman(m-1,Akkerman(m,n-1));
// }
// Console.WriteLine("Enter M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter N");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{Akkerman(m,n)}");