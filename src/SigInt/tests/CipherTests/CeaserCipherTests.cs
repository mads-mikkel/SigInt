using Cryptography;

namespace CipherTests
{
    public class CeasarCipherTests
    {
        const string message = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
        const string cipherText = "QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD";
        const string mixedCaseMessage = "The Caesar Cipher technique is one of the earliest and simplest methods of encryption technique";
        const string mixedCaseCipher = "Qeb Zxbpxo Zfmebo qbzekfnrb fp lkb lc qeb bxoifbpq xka pfjmibpq jbqelap lc bkzovmqflk qbzekfnrb";

        [Fact]
        public void EncrypUppercaseOnly()
        {
            // Arrange 
            int leftShift = 23;
            string plainText = message;
            string expected = cipherText;
            CeaserCipher ceaserCipher = new();

            // Act:
            string actual = ceaserCipher.Encrypt(plainText, leftShift);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DecryptUppercaseOnly()
        {
            // Arrange 
            int leftShift = 23;
            string cipher = cipherText;
            string expected = message;
            CeaserCipher ceaserCipher = new();

            // Act:
            string actual = ceaserCipher.Decrypt(cipher, leftShift);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EncryptLowercaseOnly()
        {
            // Arrange 
            int leftShift = 23;
            string plainText = message.ToLower();
            string expected = cipherText.ToLower();
            CeaserCipher ceaserCipher = new();

            // Act:
            string actual = ceaserCipher.Encrypt(plainText, leftShift);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DecryptLowercaseOnly()
        {
            // Arrange 
            int leftShift = 23;
            string cipher = cipherText.ToLower();
            string expected = message.ToLower();
            CeaserCipher ceaserCipher = new();

            // Act:
            string actual = ceaserCipher.Decrypt(cipher, leftShift);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EncryptMixedCase()
        {
            // Arrange 
            int leftShift = 23;
            string plainText = mixedCaseMessage;
            string expected = mixedCaseCipher;
            CeaserCipher ceaserCipher = new();

            // Act:
            string actual = ceaserCipher.Encrypt(plainText, leftShift);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DecryptMixedcase()
        {
            // Arrange 
            int leftShift = 23;
            string cipher = mixedCaseCipher;
            string expected = mixedCaseMessage;
            CeaserCipher ceaserCipher = new();

            // Act:
            string actual = ceaserCipher.Decrypt(cipher, leftShift);

            // Assert:
            Assert.Equal(expected, actual);
        }
    }
}