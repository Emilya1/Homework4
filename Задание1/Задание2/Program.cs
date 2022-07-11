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
