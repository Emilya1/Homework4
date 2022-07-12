/* TASK Семинар 1
 int  num1, num2;
Console.Write("Input first integer number : ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number : ");
num2 = Convert.ToInt32(Console.ReadLine());
 if ( num1> num2 )  
 {
    Console.WriteLine($"{num1}-max, {num2}-min" );
 }
 if ( num1 < num2 )  Console.WriteLine($"{num2}-max, {num1}-min");
 if (num1 == num2 ) Console.WriteLine ("Введите разные числа!");




 int num1, num2, num3, max = 0;
Console.Write("Input first integer number : ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number : ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number : ");
num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
   max = num1;
}
else
{
   max = num2;
}
if (max < num3)
{
   max = num3;
}
else Console.WriteLine($"max number {max}");






int num;
Console.Write("Input integer number : ") ;
num = Convert.ToInt32(Console.ReadLine());
if ( num  % 2 == 0 )
{
    Console.Write($" {num}-число четное");
}
else Console.WriteLine($" {num}-число нечетное!");





Console.Write("Input  positive integer number : ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= num)
 {
if (current % 2 == 0)
{
    Console.Write(current + " ");
}
    current ++;
 }

*/