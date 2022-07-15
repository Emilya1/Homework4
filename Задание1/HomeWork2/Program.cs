/*  
// Задание 1

int FindSecondDigit(int num)
{
    int number1 = num / 10;
    int number2 = number1 % 10;
    return number2;

}
Console.Write("Введите трехзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());
int result = FindSecondDigit(num);
Console.WriteLine(result);



//Задание 2
int FindThirdDigit(int num)
{
    if (num < 100)
        Console.WriteLine(" Третьей цифры нет");
        

    else
        while (num > 1000 && num > 99)
        {
            num = num / 10;
        }
    num = num % 10;
    return num;

}
Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int result = FindThirdDigit(num);
Console.WriteLine(result);


// Задание 3
bool DayOff(int num)
{
    if (num == 6 || num == 7)
        return true;

    else return false;
}
Console.WriteLine("Введите число от 1 до 7 : ");
int number = Convert.ToInt32(Console.ReadLine());
bool DayWeek = DayOff(number);
Console.WriteLine(DayWeek);

*/



