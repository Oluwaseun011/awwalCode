using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 3, 4, 5, 1, 2 };
            Console.WriteLine(Circuit(a,b));
        }

        static int Circuit(int[] a, int[] b)
        {
            int startPoint = -1;
            for(int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                for(int j = i; j <= a.Length + i ; j++)
                {
                    if(j ==  a.Length-1)
                    {
                        int z = j - a.Length-1;
                        sum += (a[j] - b[j] + a[z]);
                    }
                    else if (j >= a.Length - 1)
                    {
                        int z = j - a.Length - 1;
                        sum += (a[z] - b[z] + a[z + 1]);
                    }
                    else
                    {
                        sum += (a[j] - b[j] + a[j + 1]);
                        
                    }

                    if (sum < 0) break;



                }
                startPoint = sum;
            }

            return startPoint;
        }
    }
}
