using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            int k = 0;
            Random rnd = new Random();
            double[] mas = new double[12];
            for (int i = 0; i < 12; i++)
                mas[i] = rnd.Next(1000);
            for (int i = 0; i < 12 - 1; i++)
            {
                for (int j = i + 1; j < 12; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                        k++;
                    }
                }
            }
            foreach (double num in mas)
                Console.Write(num + " ");
            Console.WriteLine("\nЧисло перестановок при сортировки: " + k);
        }
    }
}
