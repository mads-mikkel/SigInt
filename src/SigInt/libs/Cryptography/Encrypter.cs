namespace Cryptography
{

    public class CeaserCipher
    {
        public virtual string CeasarCipher(string plainTextMessage, int leftShift)
        {
            if (String.IsNullOrEmpty(plainTextMessage))
            {
                throw new ArgumentNullException(nameof(plainTextMessage));
            }

            int length = plainTextMessage.Length;
            int middleStartIndex = leftShift;
            int middleEndIndex = length - leftShift - 1;
            string leftMostElements = plainTextMessage[0..middleStartIndex];
            string middleElements = plainTextMessage[middleStartIndex..middleEndIndex];
            string rightMostElements = plainTextMessage[middleEndIndex..(length-1)];

            string encryptedMessage = String.Concat(middleElements, rightMostElements, leftMostElements);

            return encryptedMessage;
        }
    }
}