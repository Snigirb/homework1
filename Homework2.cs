//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// void CutNumber (int num){
//     if (num<100 || num>999){
//         Console.WriteLine("Error");
//     }
//     else{
//         int first_digit = num/10;
//         int second_digit = first_digit%10;
//         Console.WriteLine($"New num is {second_digit}");
//     }
// }
// Console.WriteLine("Enter the number :");
// int number = Convert.ToInt32(Console.ReadLine());
// CutNumber(number);


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// void CutNumber (int num){
//     if (num<100){
//         Console.WriteLine("third digit doesnot exist");
//     }
//         else if(num>99 && num<1000){
//         int new_num=num%10;
//         Console.WriteLine($"Third digit is {new_num}");
//     }
//     else if(num>999 && num<10000){
//         int first_digit = num/10;
//         int new_num = first_digit%10;
//         Console.WriteLine($"Third digit is {new_num}");
//     }
//     else if(num>9999 && num<100000){
//         int first_digit = num/100;
//         int new_num = first_digit%10;
//         Console.WriteLine($"Third digit is {new_num}");
//     }
//     else if(num>99999 && num<1000000){
//         int first_digit = num/1000;
//         int new_num = first_digit%10;
//         Console.WriteLine($"Third digit is {new_num}");
//     }
//     else if(num>999999 && num<10000000){
//         int first_digit = num/10000;
//         int new_num = first_digit%10;
//         Console.WriteLine($"Third digit is {new_num}");
//     }
//     else if(num>9999999 && num<100000000){
//         int first_digit = num/100000;
//         int new_num = first_digit%10;
//         Console.WriteLine($"Third digit is {new_num}");
//     }
//     else if(num>99999999 && num<1000000000){
//         int first_digit = num/1000000;
//         int new_num = first_digit%10;
//         Console.WriteLine($"Third digit is {new_num}");
//     }
//     else
//         Console.WriteLine($"The number is too big");
// }
// Console.WriteLine("Enter the number :");
// int number = Convert.ToInt32(Console.ReadLine());
// CutNumber(number);
//Думаю, девятизначных чисел хватит. Но если нужно ещё больше, то можно копипастнуть последний элсиф,
//изменить отрезок на следующий разряд и добавить нолик к делимому для first_digit



//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// void CutNumber (int num){
//     if (num==1){
//         Console.WriteLine("Monday is not a day off");
//     }
//     else if (num==2){
//         Console.WriteLine("Tuesday is not a day off");
//     }
//     else if (num==3){
//         Console.WriteLine("Wednesday is not a day off");
//     }
//     else if (num==4){
//         Console.WriteLine("Thursday is not a day off");
//     }
//     else if (num==5){
//         Console.WriteLine("Friday is not a day off");
//     }
//     else if (num==6){
//         Console.WriteLine("Congratulations! Saturday is a day off!");
//     }
//     else {
//         Console.WriteLine("Congratulations! Sunday is a day off!");
//     }
// }
// Console.WriteLine("Enter the number of day of week:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number<1 || number>7){
//     Console.WriteLine("Error");
// }
// else CutNumber(number);