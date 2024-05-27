using System;
using System.Text;

namespace BankDataAccessTier
{
    internal static class clsPasswordHandling
    {
        public static string EncryptPassword(string Password, int EncryptionKey = 2)
        {
            StringBuilder SB = new StringBuilder(Password);

            for (int i = 0; i < Password.Length; i++)
            {
                SB[i] = Convert.ToChar(SB[i] + EncryptionKey);
            }

            return SB.ToString();
        }

        public static string DecryptPassword(string Password, int DecryptionKey = 2)
        {
            StringBuilder SB = new StringBuilder(Password);

            for (int i = 0; i < Password.Length; i++)
            {
                SB[i] = Convert.ToChar(SB[i] - DecryptionKey);
            }

            return SB.ToString();
        }
    }
}
