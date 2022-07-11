
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
