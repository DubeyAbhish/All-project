using System;
namespace Ram
{
    class Userid 
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

                    IsAuthenticated = false;
                    Console.WriteLine("invalid userid or password");
                }
            } while (!IsAuthenticated);
            
        }

    }

}

