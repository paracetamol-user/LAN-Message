using System.Security.Cryptography;
using System.Text;

namespace UserManager
{
    public partial class UserVerification
    {

        public byte[] GetSHA256(byte[] text)
        {
            SHA256Managed managed = new SHA256Managed();
            return managed.ComputeHash(text);
        }

        public string GetSHA256(string text)
        {
            if (text == null)
                return string.Empty;

            byte[] textByte = Encoding.ASCII.GetBytes(text);
            byte[] hashValue = GetSHA256(textByte);
            string hashString = "";

            foreach(byte b in hashValue)
            {
                hashString += string.Format("{0:x2}", b);
            }

            return hashString;
        }
    }
}
