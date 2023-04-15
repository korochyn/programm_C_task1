//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int num_a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num_b = int.Parse(Console.ReadLine()!);
if (num_a > num_b) {
    Console.WriteLine("Наибольшее число = " + num_a);
    Console.WriteLine("Наименьшее число = " + num_b);
    }
else {
    Console.WriteLine("Наибольшее число = " + num_b);
    Console.WriteLine("Наименьшее число = " + num_a);
    }


