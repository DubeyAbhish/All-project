using System;
namespace All_project
{
    internal class MultiDimentionArrays
    {
        public static void Main(string[] args)

        {
            int[,] values = new int[2, 3];

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++
                {
                    Console.Write("Values [{0},{1} :]",row,col);
                    values[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine(values[row, col]);
                }
            }
   
        }
    }

}
