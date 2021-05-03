using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    class InputHelper
    {
        int Min;
        int Max;
        public int input;
        public int element;
        public bool valid;
      
        public int Input
        {
            get
            {
                return input;
            }
            set
            {
                if (value < Min)
                {
                    valid = false;
                }
                else if (value > Max)
                {
                    valid = false;
                }
                else
                {
                    input = value;
                    valid = true;
                }
            }
        }
        public int Element
        {
            get
            {
                return element;
            }
            set
            {
                element = value;
            }
        }

        public  bool Valid
        { 
            get
            {
                return valid;
            }
            set
            {
                valid = value;
            }
        }

        public InputHelper(int  Min)
        {
           do
            {
                try
                {
                    input  = Convert.ToInt32(Console.ReadLine());
                    if (input < Min)
                    {
                        Console.WriteLine("Введите число не меньше " + Min);
                    }
                }
                catch
                {
                    Console.WriteLine("Введите натуральное число не меньше " + Min);
                }
            }
            while (input < Min);
        }

        public InputHelper()
        {
            do
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input <= 0)
                    {
                        Console.WriteLine("Некорректный ввод. Введите натуральное число");
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод. Введите натуральное число");
                }
            }
            while (input <= 0);
        }

        public InputHelper(int Min, int Max, int Input)
        {
            try
            {
                if (Input < Min)
                {
                    valid = false;
                    Console.WriteLine("Некорректное значение. Введите число в заданном диапазоне");
                }
                else if (Input <= Max)
                {
                    valid = true;
                }
                if (Input > Max)
                {
                    valid = false;
                    Console.WriteLine("Некорректное значение. Введите число в заданном диапазоне");
                }
            }
        catch
            {
                Console.WriteLine("Некорректное значение. Введите натуральное число");
            }
        }
    }
}

