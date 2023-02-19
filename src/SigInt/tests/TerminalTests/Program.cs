using Cryptography;
using Cryptography.Analyzers;
using Cryptography.Tools;

using System.Text;
using System.Threading;

namespace TerminalTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CeaserCipher cc = new();
            string m = "novemtresterminusunusnovemunusterminusunusquinquesexterminusunusnullaquinque".ToUpper();
            string c = cc.Encrypt(m, 13);

            Console.WriteLine(c);

            var bytes = Encoding.UTF8.GetBytes(c);


            for (int i = 0; i < bytes.Length; i++)
            {
                if (i % 16 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    byte[] b = bytes[i..(i + 1)];
                    var hex = BitConverter.ToString(b).Replace("-", "");
                    Console.Write(hex + " ");
                }
            }*/

            var file = @"C:\data\bytetest.txt";
            TextAnalyzer analyzer = new TextAnalyzer();
            var result = analyzer.RunStatisticalAnalysis(File.ReadAllText(file));
            Console.WriteLine(result);
             var bytes = File.ReadAllBytes(file);
             Printer.Print(bytes, Encoding.UTF8);
            
        }
    }
}