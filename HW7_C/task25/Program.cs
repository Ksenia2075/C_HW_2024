// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.      3, 5 -> 243 (3⁵)         2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
int num = Degree(A, B);

int Degree(int A, int B)
{
    int n = 1;
    for (int i=0; i<B; i++)
    {
        n = n*A;
    }
    return n;
}

Console.Write(num);


