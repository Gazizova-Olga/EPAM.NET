using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        
            public List<char> str = new List<char>();

            public static MyString operator +(MyString str1, MyString str2)
            {
                MyString result = str1;
                result.str.AddRange(str2.str);
                return result;

            }

            public static MyString operator -(MyString str1, MyString str2)
            {
                MyString result = str1;
                for (int i = str1.Length - 1; i >= 0; i--)
                {
                    if (str1.str[i] == str2.str[0])
                    {
                        bool match = true;
                        for (int j = 1; j < str2.Length; j++)
                        {
                            if (str1.str[i + j] != str2.str[j])
                            {
                                match = false;
                                break;
                            }
                        }
                        if (match)
                        {
                            result.str.RemoveRange(i, str2.Length);//все вхождения
                                                                   //  break;  //только последнее вхождение
                        }
                    }
                }
                return result;

            }

            public static bool operator ==(MyString str1, MyString str2)
            {
                if (str1.Length != str2.Length)
                {
                    return false;
                }
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1.str[i] != str2.str[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            public static bool operator !=(MyString str1, MyString str2)
            {
            return !(str1 == str2);
            }

            public int Length
            {
                get
                {
                    return str.Count;
                }
            }

            public new string ToString()
            {
                string s = str[0].ToString();
                for (int i = 1; i < Length; i++)
                {
                    s += str[i];
                }
                return s;
            }
        
    }
}
