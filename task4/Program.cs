// Задача 4: Напишите программу, которая принимает 
// на вход три числа
// и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int nA, nB, nC;
Console.WriteLine("Введите 1-ое число:");
nA  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число:");
nB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 3-ое число:");
nC = Convert.ToInt32(Console.ReadLine());

if ((nA>nB) && (nA>nC))
{
    Console.WriteLine("наибольшее число 1:",nA);
}
else if ((nB>nA) && (nB>nC))
{
    Console.WriteLine("наибольшее число 2:",nB);
}
else if ((nC>nA) && (nC>nB))
{
    Console.WriteLine("наибольшее число 3:",nC);
}