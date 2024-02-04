using System;
namespace Ram
{
    class Mumbai
    {
        public static void Main()
        {
            bool IsAuthenticated = true;
            do
            {
                Console.Write("userid :");
                string userid = Console.ReadLine();

                Console.Write("password :");
                string password = Console.ReadLine();

                if (userid == "admin" && password == "1234")
                {
                    IsAuthenticated = true;
                    Console.Write("Welcome :" + userid);
                }
                else
                {
                    {
                        IsAuthenticated = false;
                        Console.WriteLine("invalid userid or password");
                    }

                }
            } while (!IsAuthenticated);




            //    int Res;
            //    Console.WriteLine("Enter your FirstNumber :");
            //    int FirstNumber = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter your secoundNumber :");
            //    int SecoundNumber = Convert.ToInt32(Console.ReadLine());

            //TakeOperator:
            //    Console.Write("Operator(+,-,*,/,%) :");
            //    string Ope = Console.ReadLine();

            //    switch (Ope)
            //    {
            //        case "+":
            //            Res = FirstNumber + SecoundNumber;
            //            Console.WriteLine("Add :" + Res);
            //            break;

            //        case "-":
            //            Res = FirstNumber - SecoundNumber;
            //            Console.WriteLine("Div :" + Res);
            //            break;

            //        case "*":
            //            Res = FirstNumber * SecoundNumber;
            //            Console.WriteLine("Mul :" + Res);
            //            break;

            //        case "/":
            //            Res = FirstNumber / SecoundNumber;
            //            Console.WriteLine("Div :" + Res);
            //            break;

            //        case "%":
            //            Res = FirstNumber % SecoundNumber;
            //            Console.WriteLine("Pre :" + Res);
            //            break;
            //        default:
            //            Console.WriteLine("OOPS! invalid input.");
            //            goto TakeOperator;


            //    }
            //    Console.Write("Press Y to continue : ");
            //    ToContinue = Console.ReadKey().KeyChar;
            //    ToContinue = char.ToLower(ToContinue);
            //    Console.WriteLine();

            //}   while(ToContinue == 'y');
        }
    }
}