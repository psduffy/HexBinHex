using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexBinHex
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a binary or hexadecimal number (or type 'exit' to quit):");
                string inputValue = Console.ReadLine();

                // Check if the user wants to exit the program
                if (inputValue.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                string outputValue;

                if (IsBinary(inputValue))
                {
                    outputValue = "Hex: " + BinaryToHex(inputValue);
                }
                else if (IsHexadecimal(inputValue))
                {
                    outputValue = "Binary: " + HexToBinary(inputValue);
                }
                else
                {
                    outputValue = "Invalid input.";
                }

                Console.WriteLine(outputValue);
            }

            Console.WriteLine("Program exited. Press any key to close.");
            Console.ReadKey();
        }

        static bool IsBinary(string value)
        {
            foreach (char c in value)
            {
                if (c != '0' && c != '1') return false;
            }
            return true;
        }

        static bool IsHexadecimal(string value)
        {
            foreach (char c in value)
            {
                if (!Uri.IsHexDigit(c)) return false;
            }
            return true;
        }

        static string BinaryToHex(string binary)
        {
            int decimalValue = Convert.ToInt32(binary, 2);
            return decimalValue.ToString("X");
        }

        static string HexToBinary(string hex)
        {
            int decimalValue = Convert.ToInt32(hex, 16);
            return Convert.ToString(decimalValue, 2);
        }
    }
}
