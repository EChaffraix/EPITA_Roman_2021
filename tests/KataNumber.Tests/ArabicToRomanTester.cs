using NUnit.Framework;

namespace KataNumber.Tests
{
    [TestFixture]
    public class ArabicToRomanTester
    {
        [TestCaseSource(typeof(RomanNumberTestCases))]
        public void FooBar(int arabic, string roman)
        {
            IConvert convert = new ArabicToRoman();
            string result = convert.Convert(arabic.ToString());
            Assert.That(result, Is.EqualTo(roman));
        }
    }
}