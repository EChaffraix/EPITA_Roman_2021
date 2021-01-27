using System.Collections.Generic;

namespace KataNumber
{
    public class ArabicToRoman : IConvert
    {
        protected List<Rule> rules =
            new List<Rule>
            {
                new Rule(1, "I"),
                new Rule(2, "II"),
                new Rule(3, "III"),
                new Rule(4, "IV"),
                new Rule(5, "V"),
                new Rule(6, "VI"),
                new Rule(7, "VII"),
                new Rule(8, "VIII"),
                new Rule(9, "IX"),
                new Rule(10, "X"),
                new Rule(20, "XX"),
                new Rule(30, "XXX"),
                new Rule(40, "XL"),
                new Rule(50, "L"),
                new Rule(60, "LX"),
                new Rule(70, "LXX"),
                new Rule(80, "LXXX"),
                new Rule(90, "XC"),
                new Rule(100, "C"),
                new Rule(200, "CC"),
                new Rule(300, "CCC"),
                new Rule(400, "CD"),
                new Rule(500, "D"),
                new Rule(600, "DC"),
                new Rule(700, "DCC"),
                new Rule(800, "DCCC"),
                new Rule(900, "CM"),
                new Rule(1000, "M"),
                new Rule(2000, "MM"),
                new Rule(3000, "MMM")
            };

        public virtual string Convert(string numberInString)
        {
            if (!int.TryParse(numberInString, out var number))
                return "Input is not an integer";

            string result = string.Empty;
            while (number > 0)
            {
                for (int i = rules.Count - 1; i >= 0; i--)
                {
                    var rule = rules[i];
                    if (number >= rule.Value)
                    {
                        number -= rule.Value;
                        result += rule.ToString();
                    }
                }
            }

            return result;
        }
    }
}