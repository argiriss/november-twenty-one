using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOneNovember
{
    static class Utilities
    {
        public static void SwapInt(ref int a, ref int b)
        {
            int temp=a;
            a = b;
            b = temp;
        }


        public static void SwapGen<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static List<double> LongestSubsequence(List<double> list)
        {
            List<double> List2=new List<double>();
            int temp = 0;
            int count = 1;
            double max = list[0];
            for(int i=0; i<list.Count-1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    count++;
                    if (i == list.Count - 2)
                    {
                        if (count > temp)
                        {
                            max = list[i];
                            temp = count;
                        }
                    }
                }
                else
                {
                    if (count > temp)
                    {
                        temp = count;
                        count = 1;

                    }
                    else
                    {
                        count = 1;
                    }
                }

            }

            for (int y = 0; y < temp; y++)
            {
                List2.Add(max);
                Console.WriteLine(max);
            }
            
            return List2;
        }

        //auto einai to sosto
        public static List<T> LongestSubsequence<T>(List<T> list)
        {
            List<T> List2 = new List<T>();
            int temp = 0;
            int count = 1;
            T max = list[0];
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Equals(list[i + 1]))
                {
                    count++;
                    if (i== list.Count - 2)
                    {
                        if (count > temp)
                        {
                            max = list[i];
                            temp = count;
                        }
                    }
                    
                }
                else
                {
                    if (count > temp)
                    {
                        max = list[i];
                        temp = count;
                        count = 1; 
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }

            for (int y = 0; y < temp; y++)
            {
                List2.Add(max);
                Console.WriteLine(max);
            }

            return List2;
        }
    }
}
