using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Tools
{
    public static class Printer
    {
        public static void Print(byte[] bytes, Encoding encoding)
        {
            
            int length = bytes.Length;
            if(length > 65535)
            {
               //throw new ArgumentException("Size exceeds limit of 64K (65.535 bytes).");
            }
            string nl = Environment.NewLine;

            List<string> lines = new() { $"Printing {length:N0} bytes:{nl}" };
            string delimiter =
                             $"================================================================================={nl}";
            string header = $"Line  XB   | Data{String.Empty.PadRight(44)}| {encoding.HeaderName.PadRight(17)}|{nl}" + delimiter;

            int k = 0, j = 1;
            for (int i = 0; i < length; i += 16)
            {
                if (i % 256 == 0)
                    lines.Add(String.Concat(nl, header));
                string line = $"{j++:D5}", hexLine = $"{i:X4}";
                byte[] byteLine;
                string dataLine;
                if (i < length - 16)
                {
                    byteLine = bytes[i..(i + 16)];
                    dataLine = $"{BitConverter.ToString(byteLine).Replace('-', ' ')}";
                }
                else
                {
                    byteLine = bytes[i..];
                    dataLine = $"{BitConverter.ToString(byteLine).Replace('-', ' ').PadRight(47)}";
                }
                string encodingLine = $"{encoding.GetString(byteLine).PadRight(16)}";
                encodingLine = ReplaceControlChars(encodingLine);
                line += $" {hexLine} | {dataLine} | {encodingLine} |{nl}";
                lines.Add(line);
                if (i % 16 == 0)
                {
                    k += 16;
                }
            }

            foreach (string line in lines)
            {
                Console.Write(line);
            }
            Console.WriteLine($"{nl}Done printing {length:N0} bytes.");
        }

        private static string ReplaceControlChars(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsControl(arr[i]))
                {
                    arr[i] = ' ';
                }
            }
            return new string(arr);
        }
    }
}