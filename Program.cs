using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool column = true, line = true;
            Random rnd = new Random();
            Console.WriteLine("Введите кол-во строк:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[n, m];
            for(int i = 0; i<n;i++)
            {
                for(int k = 0; k<m;k++)
                {
                    mass[i, k] = rnd.Next(0, 1000);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    for (int p = 0;p<n;p++) //проверка по столбцам
                    {
                        if (mass[i, k] < mass[p,k])
                        {
                            column = false;
                        }
                    }
                    for (int p = 0; p < m; p++) //проверка по строкам
                    {
                        if (mass[i, k] > mass[i, p])
                        {
                            line = false;
                        }
                    }
                    if(line==true&&column==true)
                    {
                        Console.WriteLine(mass[i, k]);
                    }
                }
            }
        }
    }
}
