namespace Cryptography
{
    internal static class Utils
    {
        private static string[] uppercase25 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        internal static string[] GetUppercase25()
        {
            string[] arr = new string[uppercase25.Length];
            Array.Copy(uppercase25, arr, uppercase25.Length);
            return arr;
        }
    }
}