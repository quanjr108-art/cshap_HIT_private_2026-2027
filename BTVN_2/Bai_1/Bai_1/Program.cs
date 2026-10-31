using System;
using System.Linq.Expressions;
class Program
{
    static int CalculateDamage(int attack, int armor)
    {
        if (attack > armor) return attack - armor;
        else return 0;
    }
    static int CalculateRemainingHp(int currentHp, int damage)
    {
        if (currentHp > damage) return currentHp-damage;
        else return 0;
    }

    static void Main()
    {
        int initialHp = int.Parse(Console.ReadLine());
        int armor = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];
        int dem = 0;
        int Zero = 0;
        int HPnow = initialHp;
        for (int i = 0; i < n; i++)
        {
            mang[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            dem += 1;
            int dame = CalculateDamage(mang[i], armor);
            initialHp = CalculateRemainingHp(initialHp, dame);
            Console.WriteLine($"Don {i + 1} : Sat thuong {dame} | HP {initialHp}");
            if (initialHp == 0)
            {
                Zero = 1;
                break;
            }
        }
        if (Zero==1)
        {
            Console.WriteLine("Trang thai : Da bi ha ");
            Console.WriteLine($"So don da xu li {dem}");
            Console.WriteLine($"Tong HP da mat : {HPnow}");
            Console.WriteLine($"Don ket lieu {dem}");
        }
        else
        {
            Console.WriteLine("Trang thai : Chua bi ha ");
            Console.WriteLine($"So don da xu li {dem}");
            Console.WriteLine($"Tong HP da mat : {HPnow-initialHp}");
        }

    }
}