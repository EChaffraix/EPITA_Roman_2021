using NUnit.Framework;

namespace KataNumber.Tests
{
    [TestFixture]
    public class RomanToArabicTester
    {
        [TestCaseSource(typeof(RomanNumberTestCases))]
        public void FooBar(int arabic, string roman)
        {
            IConvert convert = new RomanToArabic();
            string result = convert.Convert(roman);
            Assert.That(result, Is.EqualTo(arabic.ToString()));
        }
    }
}