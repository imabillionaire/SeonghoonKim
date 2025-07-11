using System;

namespace PrimitiveTypesToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            //PrimitiveTypesToBinary.Program.cs
            byte byte1 = byte.MaxValue;
            byte byte2 = byte.MinValue;

            int int1 = int.MaxValue;
            int int2 = int.MinValue;

            long long1 = long.MinValue;
            long long2 = long.MinValue;

            char char1 = 'X';
            char char2 = '$';

            Console.WriteLine("Primitive Types to Binary Representation:");
            Console.WriteLine();
            Console.WriteLine("byte.MaxValue = " + byte1 + " -> " + Convert.ToString(byte1, 2));
            Console.WriteLine("byte.MinValue = " + byte2 + " -> " + Convert.ToString(byte2, 2));

            Console.WriteLine("int.MaxValue = " + int2 + " -> " + Convert.ToString(int1, 2));
            Console.WriteLine("int.MinValue = " + int2 + " -> " + Convert.ToString(int2, 2));

            Console.WriteLine("long.MaxValue = " + long1 + " -> " + Convert.ToString(long1, 2));
            Console.WriteLine("long.MinValue = " + long2 + " -> " + Convert.ToString(long2, 2));

            Console.WriteLine("Char1.Value = " + char1 + " -> " + Convert.ToString(char1, 2));
            Console.WriteLine("Char2.Value = " + char2 + " -> " + Convert.ToString(char2, 2));
            Console.WriteLine();

            int intNum = 10;
            int binaryNum = 0b10;
            int hexNum = 0x10;
            uint uIntNum = 10u;
            float floatNum = 10.0f;
            double doubleNum = 10.0;
            string stringNum = "10";

            Console.WriteLine("intNum = 10 = " + intNum);
            Console.WriteLine("binaryNum = 0b10 = " + binaryNum);
            Console.WriteLine("hexNum = 0x10 = " + hexNum);
            Console.WriteLine("uIntNum = 10u = " + uIntNum);
            Console.WriteLine("floatNum = 10.0f = " + floatNum);
            Console.WriteLine("doubleNum = 10.0 = " + doubleNum);
            Console.WriteLine("stringNum = '10' = " + stringNum);
            
            Console.WriteLine();

            //어머나;
            Console.WriteLine("어머나");

            //어머나2;
            Console.WriteLine("어머나2");

            //어머나3;
            Console.WriteLine("어머나3");

            //어머나4;
            Console.WriteLine("어머나4");
        }
    }
}