using System.Text;

namespace XGames.Domain.Externsions
{
    public static class Extension
    {
        public static string ConvertToMD5(this string password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            var _password = (password += "|2d331caa-f6c0-40c0-bb43-6e32989c2881");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(_password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
           
        }        
    }
}
