using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk9quiz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is our last name?");
            string userLastName = Console.ReadLine();

            Console.WriteLine("What is you age?");
            string userAge = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userFavoriteColor = Console.ReadLine();

           Console.WriteLine("Hello,"+ userName+ userLastName + "!" + "You are" +  userAge + "years old and your favorite color is" + userFavoriteColor);
        }
    }
}
