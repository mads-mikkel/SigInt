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

            /* var bytes = File.ReadAllBytes(@"C:\Users\mara\source\repos\aspit\Aspit.Planner.Gui.Wpf.App\bin\Release\aspitplanner.exe");
             Printer.Print(bytes, Encoding.UTF8);*/

            TextAnalyzer analyzer = new TextAnalyzer();
            Console.WriteLine(analyzer.GetWordCount(@"One two     three
four    five "));
        }
    }
}