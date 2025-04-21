namespace CodingKatas.StringToCamel
{
    using System;
    using System.Text;

    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            var stringBuilder = new StringBuilder();
            var chars = str.ToCharArray();

            bool makeCap = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '_' || chars[i] == '-')
                {
                    makeCap = true;
                }
                else
                {
                    stringBuilder.Append(makeCap ? char.ToUpper(chars[i]) : chars[i]);
                    makeCap = false;
                }
            }

            return stringBuilder.ToString();
        }
    }

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void KataTests()
        {
            Assert.That(Kata.ToCamelCase("the_stealth_warrior"), Is.EqualTo("theStealthWarrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.That(Kata.ToCamelCase("The-Stealth-Warrior"), Is.EqualTo("TheStealthWarrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
    }
}
