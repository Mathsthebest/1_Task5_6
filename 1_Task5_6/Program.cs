using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N - количество строк и стобцов");
            int N = Convert.ToInt32(Console.ReadLine());
            int sumDiag1 = 0;
            int sumDiag2 = 0;
            

            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Введите число в {0}-й строке, в {1}-м столбце", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,4}", array[i, j]);

                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                sumDiag1 += array[i, i];
                sumDiag2 += array[i, N-1-i];
            }
            

            if (sumDiag1 != sumDiag2)
            {
                Console.WriteLine("Квадрат -  не магический!");
                Console.ReadKey();
                return;
             }
                                          
                for (int k = 0; k < N; k++)
                {
                    int sumStroka = 0;
                    int sumStolb = 0;
                    

                     
                    for (int l = 0; l < N; l++)
                    {
                        sumStroka += array[k, l];
                        sumStolb += array[l, k];
                       
                    }
                    
                    
                    if ((sumStroka != sumDiag1) || (sumStolb != sumDiag1))
                    {
                        Console.WriteLine("Квадрат -  не магический!");
                    Console.ReadKey();
                    return;
                    }
                                        
                }

            Console.WriteLine("Квадрат - магический!");
            Console.ReadKey();
        }
    }
}
