using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
class Program
{
    static int CalculateTotalDamage(int[] damages)
    {
        int totalDamage = 0;
        for (int i = 0; i < damages.Length; i++)
        {
            totalDamage += damages[i];
        }
        return totalDamage;
    }
    static void Main()
    {   
        int n=int.Parse(Console.ReadLine());
        int[] damages = new int[n];
        for (int i = 0;i < damages.Length;i++)
        {
            damages[i] = int.Parse(Console.ReadLine());
        }
        int dem = 0;
        int maxdamages = 0;
        int totalDamages=CalculateTotalDamage(damages);
        for (int i = 0;i<damages.Length;i++)
        {
            if (damages[i]>0)
            {
                dem += 1;
                if (damages[i]>maxdamages)
                { 
                    maxdamages = damages[i]; 
                }
            }
        }
        Console.WriteLine($"Tong sat thuong : {totalDamages}");
        Console.WriteLine($"So don danh trung : {dem}");
        Console.WriteLine($"So don danh truot : {n-dem}");
        Console.WriteLine($"Sat thuong lon nhat : {maxdamages}");

    }
}
