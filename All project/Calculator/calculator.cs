using System;
namespace All_project.Calculator
{
     class calculator
    {
        public static void Main()
        {
            int Res;
            Console.Write("Enter your first Number");
            int firstNumber =Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter SecoundNumber : ");
            int secoundNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ope(+,-,*,/,%) :");
            string Ope = Console.ReadLine();

            switch(Ope)
            {
                case "+":
                    Res = firstNumber + secoundNumber;
                    Console.Write("ADD :" + Res);
                    break;
                case "-":
                    Res = firstNumber - secoundNumber;
                    Console.Write("Div :" + Res);
                    break;
                case "*":
                    Res = firstNumber * secoundNumber;
                    Console.Write("Mul :" + Res);
                    break;
                case "/":
                    Res = firstNumber / secoundNumber;
                    Console.Write("Div :" + Res);
                    break;
                case "%":
                    Res = firstNumber % secoundNumber;
                    Console.Write("pr :" + Res);
                    break;



            }


        }

    }
}
