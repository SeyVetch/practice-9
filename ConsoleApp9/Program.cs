using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        class prog2
        {
            public char c
            {
                get
                {
                    return c;
                }
                set
                {
                    if (value >= 'A' && value <= 'Z')
                    {
                        c = value;
                    }
                }
            }
        }
        class prog3
        {
            int[] n;
            int i = 0;
            public int x
            {
                get
                {
                    int res = n[i];
                    i++;
                    if (i == n.Length)
                    {
                        i = 0;
                    }
                    return res;
                }
                set
                {
                    int j = i - 1;
                    if (j < 0)
                    {
                        j = n.Length - 1;
                    }
                    n[j] = value;
                }
            }
        }
        class prog4
        {
            int[] n;
            public int a
            {
                get
                {
                    int sum = 0;
                    foreach(int x in n)
                    {
                        sum += x;
                    }
                    return sum;
                }
            }
        }
        class prog5
        {
            private int n = 1;
            private string s;
            public prog5()
            {
                s = Convert.ToString(n, 8);
            }
            public int property1
            {
                set
                {
                    if (value >= 0)
                    {
                        n = value;
                        s = Convert.ToString(n, 8);
                    }
                }
            }
            public string property2
            {
                get
                {
                    return s;
                }
            }
        }
        class prog6
        {
            static int a = 1;
            public static int x
            {
                get
                {
                    int res = a;
                    a += 2;
                    return res;
                }
                set
                {
                    a = (value - 1) * 2 + 1;
                }
            }
        }
        class prog7
        {
            int start, finish;
            int[] n;
            public prog7(int x)
            {
                n = new int[x];
                start = 0;
                finish = x - 1;
            }
            public int this[int i]
            {
                get
                {
                    if (i >= start && i <= finish)
                    {
                        return n[i];
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    if (i >= start && i <= finish)
                    {
                        n[i] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
