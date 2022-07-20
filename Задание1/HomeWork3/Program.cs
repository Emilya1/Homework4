/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

bool Palindrome(int num)
{
    int num1 = num / 10000;
    int num2 = num % 10;
    int num3 = num / 1000 % 10;
    int num4 = num % 100 / 10;
    if ( num1 == num2 && num3 == num4)
    return true;
    
    else return false;
}
Console.Write("Введите пятизначное число : ");
int numbers = Convert.ToInt32(Console.ReadLine());
bool number =Palindrome(numbers);
Console.WriteLine(number);



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance= Math.Sqrt(Math.Pow((y1 - y2), 2) + Math.Pow((x1 - x2), 2) + Math.Pow((z1 - z2), 2));
    return distance;
}

Console.Write( "Введите значение X точки A: ");
int x1=Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите значение Y точки A: ");
int y1=Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите значение Z точки A: ");
int z1=Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите значение X точки B: ");
int x2=Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите значение Y точки B: ");
int y2=Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите значение Z точки B: ");
int z2=Convert.ToInt32(Console.ReadLine());

double number3 = Distance( x1,y1,z1, x2, y2, z2);
Console.WriteLine($"Расстояние - {number3}");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cube(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write(current * current * current + " ");
        current++;
    }
   
}  
Console.WriteLine("Введите целое положительное число");
int number =Convert.ToInt32(Console.ReadLine());
Cube(number);

*/