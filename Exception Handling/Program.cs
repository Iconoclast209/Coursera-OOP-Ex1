using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int intvalue = 0;

            try
            {
                Console.Write("Enter an integer:  ");
                intvalue = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("That is NOT even a number...");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("That is NOT an integer...");
            }

            finally
            {
                Console.WriteLine("Nice work.  This program is done.");
            }


        }
    }
}
