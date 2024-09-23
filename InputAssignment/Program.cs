using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking th e user for a number.
            Console.WriteLine("Enter a number: ");

            //Logging that number to a text file.
            string text = "Your input number is: " + Console.ReadLine();
            File.WriteAllText(@"C:\Users\knhun\logs\log.txt", text); //Symbol @ means read path as is (literally)

            //Printing the text file back to the user.
            string logfile = File.ReadAllText(@"C:\Users\knhun\logs\log.txt");//Opens text file, reads the text, and closes the file.
            Console.WriteLine(logfile);
            Console.Read();
            using (StreamWriter file = new StreamWriter(@"C:\Users\knhun\logs\log.txt", true)); //Disposes of resources
        }
    }    
}
