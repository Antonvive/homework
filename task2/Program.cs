//Задача 2: Напишите программу, которая на вход принимает
//два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
int nA, nB;
Console.WriteLine("Введите 1-ое число:");
nA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число:");
nB=Convert.ToInt32(Console.ReadLine());

if (nA>nB)
{
    Console.WriteLine("наибольшее число 1:",nA);
}
else
{
    Console.WriteLine("наибольшее число 2:",nB);
}