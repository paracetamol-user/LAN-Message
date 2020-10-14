using System.Security.Cryptography;
using System.Text;

namespace UserManager
{
    public class UserVerification
    {
        private static string sqlQuery = "";

        private static byte[] GetSHA256(byte[] text)
        {
            SHA256Managed managed = new SHA256Managed();
            return managed.ComputeHash(text);
        }

        private static string GetSHA256(string text)
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

        public bool CheckExistedUser(string username)
        {
            return false;
        }

        public bool CheckValidUser(string username, string passwordSHA256)
        {
            return false;
        }

        public void AddUser(string username, string passwordSHA256)
        {

        }

        public void DeleteUser(string username)
        {

        }

        public void ChangePassword(string username, string password)
        {

        }
    }
}
