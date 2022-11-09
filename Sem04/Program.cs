// Семинар4 Задача1 На вход 2 числа А и В, на выход В в степени А

/*double Degree(double A, double B)
{
    double deg = Math.Pow((A), B);
    return deg;  
}

Console.WriteLine("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());

double deg = Degree(A,B);
Console.WriteLine($"The degree is {deg}");
*/

//Задача2 На вход число, на выход сумма цифр числа

/*int Sum(int number)
{
    int sum = 0;
    int ed = number % 10;
    int des = number % 100 / 10;
    int sot = number % 1000 / 100;
    int tis = number /1000;
    sum = ed + des + sot + tis;
    return sum;
}
int number = new Random().Next(1,10000);
int result = Sum(number);
Console.WriteLine($"Sum of the digits {number} is {result}");
*/

//Задача3 На вход массив из 8 элементов, на выход показать их на экране

/*int[] arr = {1, 2, 3, 4, 5, 6, 7, 8};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);
*/