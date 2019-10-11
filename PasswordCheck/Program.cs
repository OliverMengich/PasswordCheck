using System;

namespace PasswordCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Oliver";
            string Password = "Oliver8677";
            string _password;
            string _name;
            Console.WriteLine("Enter your name");
            _name = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            _password = Console.ReadLine();
            bool Islooping = false;
            do
            {
                if (_password == Password)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Sorry");
                }
            } while (Islooping);
           
            
        
        }
    }
}
