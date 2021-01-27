using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataNumber
{
    public class RomanToArabic : ArabicToRoman
    {
        public override string Convert(string roman)
        {
            int result = 0;
            while (roman.Length > 0)
            {
                for (int i = rules.Count - 1; i >= 0; i--)
                {
                    var rule = rules[i];
                    var romanValue = rule.ToString();
                    if (roman.StartsWith(romanValue))
                    {
                        if (romanValue.Length < roman.Length)
                        {
                            roman = roman.Substring(romanValue.Length, roman.Length - romanValue.Length);
                        }
                        else roman = "";

                        result += rule.Value;
                    }
                }
            }

            return result.ToString();
        }
    }

    public class Rule
    {
        private readonly int _value;
        public int Value => _value;

        private readonly string _representation;

        public Rule(int value, string representation)
        {
            _value = value;
            _representation = representation;
        }

        public override string ToString()
        {
            return _representation;
        }
    }
}