Console.Write("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

void palindrome (int num)
{  
 int FifthDigit = num % 10;
 int QuarterDigit = (num / 10) % 10;
 int OneDigit = num / 10000;
 int SecondDigit = (num / 1000) % 10;

if (num > 9999 && num < 100000)
{
    if (OneDigit == FifthDigit)
   {
        if (SecondDigit == QuarterDigit)
    {
        Console.WriteLine ("Палиндром"); 
        return; 
    }
   }
    Console.WriteLine ("Непалиндром");
    return; 
}

  Console.WriteLine ("Некорректное значение");


}
palindrome (num);
