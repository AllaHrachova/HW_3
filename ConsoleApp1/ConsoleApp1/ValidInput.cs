using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    class ValidInput
    {
        int min = 10;
        int max = 10000;
        public bool isvalid;

        int n;
        public int N
        {
            get { return n; }
            set
            {
                if (value < min)
                {
                    n = min;
                    isvalid = false;
                }
                else if (value > max)
                {
                    n = max;
                    isvalid = false;
                }
                else
                {
                    n = value;
                    isvalid = true;
                }
            }

        }
        public ValidInput(string n_st, int n_min, int n_max)
        {
            min = n_min;
            max = n_max;
            isvalid = true;

            try
            {
                N = Convert.ToInt32(n_st);
                if (!isvalid)
                {
                }
            }
            catch
            {
                Console.WriteLine("Некорректное значение. Введите натуральное число");
            }
        }

        public ValidInput(string n_st, int n_min)
        {
            min = n_min;
            isvalid = true;

            try
            {
                N = Convert.ToInt32(n_st);
                if (!isvalid)
                {
                }
            }
            catch
            {
                Console.WriteLine("Некорректное значение. Введите число в заданном диапазоне");
            }
        }

        public ValidInput()
        {
        }
    }
}

