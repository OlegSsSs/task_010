// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int second = a/10;
int b = second%10;

Console.WriteLine(b);
