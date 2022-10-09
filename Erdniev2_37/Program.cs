namespace Csharpe
{
    class Program
    {



        static void Main(string[] args)
        {
            int[] g = new int[90];
            int s = 0;
            for (int i = 0; i < 90; i++)
            {
                g[i] = i + 10;
                Console.Write(g[i]);
                s++;
            }
            Console.WriteLine("\nВведите число (в диапазоне 1 <= k <= 180): ");
            int k = Convert.ToInt32(Console.ReadLine());
            int c3 = -1, c2 = -1, c1 = -1;
            Share(ref c1, ref c2, ref c3, k);


            if (k >= 1 && k <= 180)
            {
                OutPut(g, c1, c2, c3, k);
            }
        }


        static void Share(ref int c1, ref int c2, ref int c3, int k)
        {
            if (k < 10)
            {
                c1 = k;
            }
            else if (k > 10 && k < 100)
            {
                c2 = k / 10;
                c1 = k - c2 * 10;
            }
            else if (k > 100)
            {
                c3 = k / 100;
                c2 = (k - (c3 * 100)) / 10;
                c1 = k - (c3 * 100) - (c2 * 10);
            }
        }


        static void OutPut(int[] g, int c1, int c2, int c3, int k)
        {
            int num = 0;
            int j = 0;
            if (c3 >= 0)
            {
                j = 0;
                num = 0;
                Console.Write($"\nНомера пар цифр, в которые входит цифра {c3}: ");
                for (int i = 0; i < 90; i++)
                {
                    j++;
                    if (j == 1)
                    {
                        num++;
                        if (c3 == g[i] / 10 || c3 == g[i] - g[i] / 10 * 10)
                        {
                            Console.Write(num + ";");
                        }
                        j = 0;
                    }
                }
            }
            if (c2 >= 0)
            {
                j = 0;
                num = 0;
                Console.Write($"\nНомера пар цифр, в которые входит цифра {c2}: ");
                for (int i = 0; i < 90; i++)
                {
                    j++;
                    if (j == 1)
                    {
                        num++;
                        if (c2 == g[i] / 10 || c2 == g[i] - g[i] / 10 * 10)
                        {
                            Console.Write(num + ";");
                        }
                        j = 0;
                    }
                }
            }
            if (c1 >= 0)
            {
                j = 0;
                num = 0;
                Console.Write($"\nНомера пар цифр, в которые входит цифра {c1}: ");
                for (int i = 0; i < 90; i++)
                {
                    j++;
                    if (j == 1)
                    {
                        num++;
                        if (c1 == g[i] / 10 || c1 == g[i] - g[i] / 10 * 10)
                        {
                            Console.Write(num + ";");
                        }
                        j = 0;
                    }
                }
            }
            Console.Write("\n\n");
            if (c3 >= 0)
            {
                j = 0;
                Console.Write($"\n\nДвузначное число, образованное парой цифр, в которую входит цифра {c3}: ");
                for (int i = 0; i < 90; i++)
                {
                    j++;
                    if (j == 1)
                    {
                        if (c3 == g[i] / 10 || c3 == g[i] - g[i] / 10 * 10)
                        {
                            Console.Write(g[i] + ";");
                        }
                        j = 0;
                    }
                }
            }
            if (c2 >= 0)
            {
                j = 0;
                Console.Write($"\nДвузначное число, образованное парой цифр, в которую входит цифра {c2}: ");
                for (int i = 0; i < 90; i++)
                {
                    j++;
                    if (j == 1)
                    {
                        if (c2 == g[i] / 10 || c2 == g[i] - g[i] / 10 * 10)
                        {
                            Console.Write(g[i] + ";");
                        }
                        j = 0;
                    }
                }
            }
            if (c1 >= 0)
            {
                j = 0;
                Console.Write($"\nДвузначное число, образованное парой цифр, в которую входит цифра {c1}: ");
                for (int i = 0; i < 90; i++)
                {
                    j++;
                    if (j == 1)
                    {
                        if (c1 == g[i] / 10 || c1 == g[i] - g[i] / 10 * 10)
                        {
                            Console.Write(g[i] + ";");
                        }
                        j = 0;
                    }
                }
            }
            for (int i = 0; i < 90; i++)
            {
                if (i == k)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("\n\n" + k + "-я цифра в этом массиве чисел - чётная\n\n");
                    }
                    else if (i % 2 != 0)
                    {
                        Console.Write("\n\n" + k + "-я цифра в этом массиве чисел - не чётная\n\n");
                    }
                }
                else if (i == 89 && k > 90)
                {
                    Console.WriteLine("\n\nВ данном массиве чисел только 90 цифр, " + k + " цифры нет\n\n");
                }
            }
        }
    }
}