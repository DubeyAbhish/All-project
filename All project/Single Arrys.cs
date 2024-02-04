using System;
namespace All_project
{
    internal class Single_Arrys

    {
        public static void Main()
        {
            //int a = 1;
            //int b = 2;
            //int c = 3;
            //int d = 4;


            int[] values = new int[5];
            int sum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write("N{0} :", (i + 1));
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i<5; i++)
            {
                Console.Write(values[i] + "\t");
            }
             Console.WriteLine();
        }


    }
} 
