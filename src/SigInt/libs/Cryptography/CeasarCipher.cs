using System.Text;

namespace Cryptography
{
    public class CeaserCipher
    {

        public virtual string Encrypt(string plainTextMessage, int shift)
        {
            if (String.IsNullOrEmpty(plainTextMessage))
            {
                throw new ArgumentNullException(nameof(plainTextMessage));
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < plainTextMessage.Length; i++)
            {
                if (plainTextMessage[i] == ' ')
                {
                    result.Append(" ");
                }
                else if (char.IsUpper(plainTextMessage[i]))
                {
                    char ch = (char)((plainTextMessage[i] + shift - 65) % 26 + 65);
                    result.Append(ch);
                }
                else
                {
                    char ch = (char)((plainTextMessage[i] + shift - 97) % 26 + 97);
                    result.Append(ch);
                }
            }
            return result.ToString();
        }

        public virtual string Decrypt(string plainTextMessage, int shift)
        {
            return Encrypt(plainTextMessage, 26 - shift);
        }
    }
}