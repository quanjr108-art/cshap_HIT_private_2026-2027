using System;
using System.Linq.Expressions;
class Program
{
    static int CalculateScore(int kills, int assists)
    {
        return kills * 100 + assists * 30;
    }
    static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        string[] Name=new string[n];
        int[] total=new int[n];
        int maxTotal = 0;
        int demTotal = 0;
        for (int i = 0; i < n; i++)
        {
            Name[i] = Console.ReadLine();
            int kills=int.Parse(Console.ReadLine());
            int assists=int.Parse(Console.ReadLine());
            total[i]=CalculateScore(kills, assists);
        }
        for (int i = 0;i < n; i++)
        {
            if (total[i]>maxTotal)
            {
                maxTotal = total[i];
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{Name[i]} : {total[i]}");
        }
        Console.Write("Dan dau : ");
        for (int i = 0;i<n ; i++)
        {
            if (total[i]==maxTotal)
            {
                demTotal += 1;
                if (demTotal > 1)
                {
                    Console.Write(", ");
                }
                Console.Write($"{Name[i]} ");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Diem cao nhat : {maxTotal}");
    }
}