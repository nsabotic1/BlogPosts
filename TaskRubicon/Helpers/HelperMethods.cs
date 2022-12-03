using System.Text;
using System.Text.RegularExpressions;

namespace TaskRubicon.Helpers
{
    public class HelperMethods : IHelperMethods
    {
        public string CreateSlug(string slug)
        {
            string str = slug.ToLower();
            byte[] tempBytes;
            tempBytes = Encoding.GetEncoding("Cyrillic").GetBytes(str);
            string asciiStr = Encoding.UTF8.GetString(tempBytes);
            // invalid chars           
            asciiStr = Regex.Replace(asciiStr, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            asciiStr = Regex.Replace(asciiStr, @"\s+", " ").Trim();
            // cut and trim 
            asciiStr = asciiStr.Substring(0, asciiStr.Length <= 45 ? asciiStr.Length : 45).Trim();
            asciiStr = Regex.Replace(asciiStr, @"\s", "-"); // hyphens   
            //remove double hypens
            int i = 1;
            while (i < asciiStr.Length)
            {
                if (asciiStr[i] == asciiStr[i - 1] && asciiStr[i] == '-')
                {
                    asciiStr = asciiStr.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }
            return asciiStr;
        }
    }
}
