
int num;
Console.Write("Input integer number : ") ;
num = Convert.ToInt32(Console.ReadLine());
if ( num  % 2 == 0 )
{
    Console.Write($" {num}-число четное");
}
else Console.WriteLine($" {num}-число нечетное!");
