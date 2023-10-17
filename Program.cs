namespace Сумма_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a= int.Parse(Console.ReadLine());
            int tempn = a / 10;
            int tempn2 = a-tempn * 10;
            a = tempn + tempn2;
            Console.WriteLine("Сумма числа равна:" + a) ;
            Console.ReadKey();
        }
    }
}