using System.Reflection;

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
            OperatingSystem os = Environment.OSVersion;
            Version ver = os.Version;

            Version sigIntVersion = Assembly.GetExecutingAssembly().GetName().Version;
            string sigIntVer = $"{sigIntVersion.Major}.{sigIntVersion.Minor}.{sigIntVersion.Build}";
            string copyRight = "© 2023 Mads Mikkel Rasmussen. All rights reserved.";
            string message =
                $"SigInt - Signal Intelligence ver. {sigIntVer}\n" +
                $"{copyRight}";
            
            WriteLine(message);
        }
    }
}