using System;

namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MinElementsNumber = 10;
            int ElementsNumber;
            int MinElement;
            int MaxElement;
            int i = 0;
            int Sum = 0;
            Console.WriteLine("Введите число элементов массива?");
            InputHelper SetElementsNumber  = new InputHelper(MinElementsNumber);
            ElementsNumber = SetElementsNumber.Input;
            do
            {
                Console.WriteLine("Введите минимальный элемент массива");
                InputHelper SetMinElement = new InputHelper();
                MinElement = SetMinElement.Input;
                Console.WriteLine("Введите максимальный элемент массива");
                InputHelper SetMaxElement = new InputHelper();
                MaxElement = SetMaxElement.Input;
                if (MaxElement < MinElement)
                {
                    Console.WriteLine("Максимальный элемент массива должен быть меньше минимального. ");
                }
            }
            while (MaxElement < MinElement);
            int[] Array1 = new int[SetElementsNumber.input];
            do
            {
                Console.WriteLine("Введите значение № " + (i + 1) + " в диапазоне от " + MinElement + " до " + MaxElement);
                try
                {
                    int ArrayElement = Convert.ToInt32(Console.ReadLine());
                    InputHelper SetArrayElements = new InputHelper(MinElement, MaxElement, ArrayElement);
                    if (SetArrayElements.valid)
                    {
                        Array1[i] = ArrayElement;
                        //Console.WriteLine("Значение № " + (i + 1) + " = " + Array1[i]);
                        if ((Array1[i] % 3 == 0) & (Array1[i] % 5 != 0))
                        {
                            Sum = Sum + Array1[i];
                        }
                        i++;
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод. Введите натуральное число");
                }
            }
            while (i < ElementsNumber);
            Console.WriteLine("Сумма элементов массива - {0}", Sum);
            Console.ReadLine();
        }
    }
}
