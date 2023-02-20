using System.Reflection;
using System.CommandLine;

using static System.Console;

namespace SigInt.CLI
{
    internal class CliProgram
    {
        static readonly string nl = Environment.NewLine;

        static void Main(string[] args)
        {
            DisplayWelcome();
        }

        private static void DisplayWelcome()
        {
            var versionString = Assembly.GetEntryAssembly()?
                                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                                .InformationalVersion
                                .ToString();

            string copyRight = "© 2023 Mads Mikkel Rasmussen. All rights reserved.";
            
            string message =
                $"SigInt - Signal Intelligence ver. {versionString}\n" +
                $"{copyRight}";

            WriteLine(message);
        }
    }
}