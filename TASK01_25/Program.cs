/*
Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

Console.Write("Enter num to be powered: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter power: ");
int pow = Convert.ToInt32(Console.ReadLine());
int res = num;

for (int i = 2; i <= pow; i ++) {
    res = res * num;
}

Console.WriteLine($"{num} to the power of {pow} is " + res);