using System;

public class Program
{
    // Evklid usulu ile EBOB tapmaq ucun metod
    public static int EvklidUsulu(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static void Main(string[] args)
    {
        Console.Write("Birinci ededi daxil edin: ");
        int ed1 = int.Parse(Console.ReadLine());

        Console.Write("Ikinci ededi daxil edin: ");
        int ed2 = int.Parse(Console.ReadLine());

        int ebob = EvklidUsulu(ed1, ed2);

        Console.WriteLine($"{ed1} ve {ed2} edelerin EBOB-u: {ebob}");
    }
}
