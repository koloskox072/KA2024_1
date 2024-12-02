namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, ilosc, wynik=0, min1, min2;
                ilosc = int.Parse(Console.ReadLine());
            for (int i = 0; i < ilosc; i++)
            {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                    if (a < b) min1 = a;
                    else min1 = b;
                    if (c < min1) min1 = c;
                    if (a < b) min2 = a;
                    else min2 = b;
                    if (c < min1) min2 = c;
                wynik = wynik + (2*a*b) + (2*a*c) + (2*b*c) +(min1*min2);
            }
            Console.WriteLine(wynik);
            
        }
    }
}
