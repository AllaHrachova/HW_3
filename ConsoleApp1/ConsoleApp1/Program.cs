using System;

namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            Console.WriteLine("Из скольких элементов будет состоять массив?");
            string q_st = Console.ReadLine();
            ValidInput t = new ValidInput(q_st, 10);
            int q = t.N;
            if (t.isvalid)
            {
                Console.WriteLine("Введите {0} значений", q);
                int[] Array1 = new int[q];
                int j = 1;

                for (int i = 0; i < q; i++)
                {
                    string s = Console.ReadLine();
                    ValidInput k = new ValidInput(s, 20, 40);
                    int n = k.N;
                    if (k.isvalid)
                    {
                        Array1[j] = n;
                        if (k.isvalid)
                            Console.WriteLine("Значение присвоено элементу массива № {0}", j);
                        if (Array1[j] % 3 == 0)
                        {
                            if (Array1[j] % 5 != 0)
                            {
                                Sum = Sum + Array1[j];
                            }
                        }
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Значение должно быть в диапазоне от 20 до 40");
                    }

                }
                Console.WriteLine("Сумма элементов массива - {0}", Sum);
            }
            else
            {
                Console.WriteLine("Элементов должно быть не менее 10");
            }

            Console.ReadLine();
        }
    }
}
