//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// int [] CreateRandomArray(int size){
//     int [] array = new int [size];
//     for (int i = 0;i<size;i++){
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
//  }

// void ShowArray(int[] array){
//     for (int i=0;i<array.Length;i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void EvenInArray(int[]array){
//     int count = 0;
//     for (int i=0;i<array.Length;i++){
//         if (array[i]%2==0){
//             count+=1;
//         }
//     }
//     Console.WriteLine($"there are {count} even numbers in the array");
// }
// Console.WriteLine("Enter size:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreateRandomArray(size);
// ShowArray(newArray);
// EvenInArray(newArray);


//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// int [] CreateRandomArray(int size){
//     int [] array = new int [size];
//     for (int i = 0;i<size;i++){
//         array[i] = new Random().Next();//В задаче сказано, что число должно быть СЛУЧАЙНЫМ, но для удобства проверки можно скобках после next вписать более приемлимый интервал. (Это не совет, а просто показываю, что я правда разобрался с материалом)
//     }
//     return array;
//  }

// void ShowArray(int[] array){
//     for (int i=0;i<array.Length;i++){
//         Console.Write($"{array[i]}  ");
//     }
//     Console.WriteLine();
// }

// void OddSumm(int[]array){
//     int res = 0;
//     for (int i=1;i<array.Length;i+=2){
//         res+=array[i];}
//     Console.WriteLine($"{res}");
// }

// Console.WriteLine("Enter size:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreateRandomArray(size);
// ShowArray(newArray);
// OddSumm(newArray);


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double [] CreateRandomArray(int size){
//     double [] array = new double [size];
//     for (int i = 0;i<size;i++){
//         array[i] = new Random().Next(-500,500);
//     }
//     return array;
//  }

// void ShowArray(double [] array){
//     for (int i=0;i<array.Length;i++){
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine();
// }

// void MaxMinDiff(double [] array){
//     double diff = array.Max()-array.Min();
//     Console.WriteLine($"Min is {array.Min()}");
//     Console.WriteLine($"Max is {array.Max()}");
//     Console.WriteLine($"Diff is {diff}");
// }

// Console.WriteLine("Enter size:");
// int size = Convert.ToInt32(Console.ReadLine());
// double [] newArray = CreateRandomArray(size);
// ShowArray(newArray);
// MaxMinDiff(newArray);