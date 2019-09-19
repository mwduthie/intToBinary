using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intToBinary
{
    class Program
    {
        /// <summary>
        /// A working version of what I was attempting to do in question two.
        /// Also realised I probably could have solved question one by multiplying the double
        /// by 100 for 2 decimal places 1000 for 3 ect, casting to int, then parsing back to a double 
        /// and dividing
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("-=Integer to binary converter=-");
            Console.WriteLine("Enter positive integers, type -1 to stop.");
            int userInput = int.Parse(Console.ReadLine());
            while (userInput != -1) {
                ConvertToBinary(userInput);
                userInput = int.Parse(Console.ReadLine());
            }
        }//Main

        private static void ConvertToBinary(int userInput)
        {
            string outputBinary = "0";

            //Getting the largest possible number of bits
            //Could probably combine this all into one for loop
            for (int i=1;userInput-(Math.Pow(2,i))>=0;i++) {
                outputBinary = "0" + outputBinary;
            }
            //Using a StringBuilder so I'm not making so many new strings - should have used one above too
            StringBuilder sb = new StringBuilder();
            
            for (int i = outputBinary.Length;i>-1;i--) {

                if (userInput - Math.Pow(2, i) >= 0)
                {
                    sb.Append("1");
                    userInput -= (int)Math.Pow(2, i);
                }
                else {
                    sb.Append("0");
                }
            }
            outputBinary = sb.ToString();
            if (outputBinary[0] == '0') {
                outputBinary = outputBinary.Substring(1);
            }
            Console.WriteLine(outputBinary);
        }//Converttobinary
    }
}
