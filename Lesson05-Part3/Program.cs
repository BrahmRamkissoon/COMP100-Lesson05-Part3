using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_Part3
{
    class Program
    {
        static void Main ( string [] args )
        {
            int age;
            string prompt;
            string movieRating = "G";

            Console.Write( "Enter your age: " );
            prompt = Console.ReadLine();
            age = Convert.ToInt32( prompt );

            if (((age >=0) && (age <= 10)) || (movieRating =="G"))
            {
                Console.WriteLine( "You're So Young" );
                Console.WriteLine( "Oh Yeah!" );
            }
            else if (( age > 10 ) && ( age <= 20 ))
            {
                Console.WriteLine( "Exciting Age!" );
            } else if((age>20) &(age<=30))
            {
                Console.WriteLine( "The World is your Oyster" );
            }
            else if ( (age > 30) && (age <= 40) )
            {
                Console.WriteLine("Exciting Age!");
            } else if (age > 40)
            {
                Console.WriteLine("You're getting old!");
            }
            else
            {
                Console.WriteLine("Error - Incorrect input!!!");
            }
            
            Console.WriteLine();
            Console.WriteLine( "Press any key to exit..." );
            Console.ReadKey();



        }
    }
}
