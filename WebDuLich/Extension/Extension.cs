using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebDuLich.Extension
{
    public static class Extension
    {
        public static string ToVnd( this double donGia)
        {
            return donGia.ToString("#,##0") + "đ";
        }
        public static string ToTitleCase(string str)
        {
            string result = str;
            if (!string.IsNullOrEmpty(str))
            {
                var words = str.Split(' ');
                for(int index = 0; index < words.Length; index++)
                {
                    var s = words[index];
                    if(s.Length > 0)
                    {
                        words[index] = s[0].ToString().ToUpper() + s.Substring(1);
                    }
                }
                result = string.Join(" ", words);
            }
            return result;
        }

        public static string ToUrlFriendly(this string url)
        {
            var result = url.ToLower().Trim();
            result = Regex.Replace(result, "âàáạăặậẫảẩẳẵ", "a");
            result = Regex.Replace(result, "[êèéẹẻẽếềệểễ]", "e");
            result = Regex.Replace(result, "[ôòóọỏõốồộổỗ]", "o");
            result = Regex.Replace(result, "[ưùúụủũứừựửữ]", "u");
            result = Regex.Replace(result, "[íìịỉĩ]", "i");
            result = Regex.Replace(result, "[ýỳỵỷỹ]", "y");

            return result;
        }

    }
}
