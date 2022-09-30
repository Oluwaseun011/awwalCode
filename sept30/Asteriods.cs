using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sept30
{
    public class Asteriods
    {
        public static string Collides(int[] arr)
        {
            Stack<int> cols = new Stack<int>();
            foreach (int item in arr)
            {
                if(cols.Count == 0)cols.Push(item);
                else
                {
                    bool flag = true;
                    int q = item;

                    while (flag)
                    {
                        
                        int a = cols.Peek();
                        int b = q;
                        
                        if (CompareSign(a, b) == true)
                        {
                            cols.Push(b);
                            flag = false;
                        }

                        else
                        {

                            if (Math.Abs(a) == Math.Abs(b))
                            {
                                cols.Pop();
                            }
                            else if (Math.Abs(a) > Math.Abs(b))
                            {
                                cols.Pop();
                                q = cols.Peek();
                                cols.Push(a);
                            }
                            else if (Math.Abs(a) < Math.Abs(b))
                            {
                                cols.Pop();
                                q = cols.Peek();
                                cols.Push(b);
                            }

                        }

                    }
                }
            }

            return String.Join(',', cols.ToArray());
        }

       /* public static bool CheckThrough(Stack<int> asd, int d)
        {
            bool flag = true;

            while(flag)
            {
                int a = asd.Peek();
                if (CompareSign(a, d) == true)
                {
                    asd.Push(d);
                    flag = false;
                }

                else
                {
                    
                    if (Math.Abs(a) == Math.Abs(d))
                    {
                        asd.Pop();
                    }
                    else if (Math.Abs(a) > Math.Abs(d))
                    {
                        asd.Pop();
                        asd.Push(a);
                        d = asd.Peek();
                    }
                    else if (Math.Abs(a) < Math.Abs(d))
                    {
                        asd.Pop();
                        asd.Push(d);
                        d = asd.Peek();
                    }

                }

            }

            return true;
        }*/

        public static bool CompareSign(int p, int q)
        {
            bool x = true;
            if (p < 0 && q > 0) x = false;
            if (p > 0 && q < 0) x = false;
            return x;
        }



    }
}
