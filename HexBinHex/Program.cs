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
            Console.WriteLine("Enter a binary or hexadecimal number:");
            string inputValue = Console.ReadLine();

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

            // Add this line to wait for user input before closing the console window
            Console.WriteLine("Press any key to exit.");
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
