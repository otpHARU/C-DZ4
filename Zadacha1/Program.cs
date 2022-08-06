// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Int32.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Int32.Parse(Console.ReadLine());

int exp = Exp(numberA, numberB);
Console.WriteLine("Число " + numberA + " в степени " + numberB + " = " + exp);

int Exp(int numberA, int numberB)
{
    int result = 1;

    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
