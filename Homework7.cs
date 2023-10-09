//массив, заполненный случайными вещественными числами
// double [,] Create2dArray(int min,int max, int row,int col){
//     double [,]array = new double [row,col];
//     for(int i =0;i < row;i++){
//         for (int j=0;j<col;j++){
//             array[i,j]= new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }
// void Show2dArray(double[,] array){
//     for(int i =0;i<array.GetLength(0);i++){
//         for(int j =0;j<array.GetLength(1);j++){
//             Console.Write($"{array[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }
// Console.WriteLine("Enter min of array");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter max of array:");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter num of rows");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter num of cols");
// int cols = Convert.ToInt32(Console.ReadLine());

// double [,] array = Create2dArray(min,max,rows,cols);
// Show2dArray(array);




//задача 50.На вход принимает позицию эл-та в 2массиве, и возвращает значение.Если что такого эл-ла нет, выдает ошибку.
// int [,] Create2dArray(int min,int max, int row,int col){
//     int[,]array = new int [row,col];
//     for(int i =0;i < row;i++){
//         for (int j=0;j<col;j++){
//             array[i,j]= new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i =0;i<array.GetLength(0);i++){
//         for(int j =0;j<array.GetLength(1);j++){
//             Console.Write($"{array[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }
// void ShowElement(int[,]array,int numOfRow, int numOfCol){
//     for(int i =0;i < array.GetLength(0);i++){
//         for (int j=0;j<array.GetLength(1);j++){
//             if (i+1==numOfRow) {
//                 if (j+1==numOfCol){
//                     Console.WriteLine($"Ваше число - {array[i,j]}");
//                 }
//             }
//         }
//     }
// }
// Console.WriteLine("Enter min of array");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter max of array:");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter num of rows");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter num of cols");
// int cols = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2dArray(min,max,rows,cols);
// Show2dArray(array);

// Console.WriteLine("Давайте найдем ваше число. Введите номер строки:");
// int numOfRow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("А теперь номер столбца:");
// int colnumOfCol = Convert.ToInt32(Console.ReadLine());


// if(numOfRow>rows || colnumOfCol>cols){
//     Console.WriteLine("Такого значения в массиве НЕТ");
// }
// else
//     ShowElement(array,numOfRow,colnumOfCol);



//Двухмерный массив где нужно найти среднее арифиметическое в каждой строке.
// int [,] Create2dArray(int min,int max, int row,int col){
//     int[,]array = new int [row,col];
//     for(int i =0;i < row;i++){
//         for (int j=0;j<col;j++){
//             array[i,j]= new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array){
//     for(int i =0;i<array.GetLength(0);i++){
//         for(int j =0;j<array.GetLength(1);j++){
//             Console.Write($"{array[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }
// int[] AverageInRow(int[,]array){
//     int [] arrayMaxes = new int[array.GetLength(0)];
//     for (int i =0;i<array.GetLength(0);i++){
//         for (int j =0;j<array.GetLength(1);j++){
//             arrayMaxes[i]+= array[i,j];
//         }
//     }
//     return arrayMaxes;
// }
// void ShowAverage (int[]arr,int cols){
//     for (int i =0;i<arr.Length;i++){
//         double result = arr[i]/cols;
//         Console.Write($"{result} ");
//     }

// }
// Console.WriteLine("Enter min of array");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter max of array:");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter num of rows");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter num of cols");
// int cols = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2dArray(min,max,rows,cols);
// Show2dArray(array);
// Console.WriteLine();
// int[]newarray = AverageInRow(array);
// ShowAverage(newarray,cols);