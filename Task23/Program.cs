Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());


void qube(int agr)
{
    int i =1;
    while (i<=agr)
    {
       Console.WriteLine($"{i} {Math.Pow((i),3)}"); 
       i++;
    }
}
qube(num);