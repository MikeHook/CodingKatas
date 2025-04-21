namespace CodingKatas.DigitalRoot
{
    public class Number
    {        
        public static int DigitalRoot(long n)
        {
            if (n < 10)
            {
                return (int)n;
            }

            var chars = n.ToString().ToCharArray();

            double newNum = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                newNum = newNum + char.GetNumericValue(chars[i]);
            }

            return DigitalRoot((long) newNum);
        }

        /*
         * Efficient version using the modulus operator
        public static int DigitalRoot(long number)
        {
            if (number == 0)
                return 0;
            if (number % 9 == 0)
                return 9;
            return (int)(number % 9);
        }*/
    }

    [TestFixture]
    public class NumberTest
    {
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(10, ExpectedResult = 1)]
        [TestCase(16, ExpectedResult = 7)]
        [TestCase(195, ExpectedResult = 6)]
        [TestCase(992, ExpectedResult = 2)]
        [TestCase(167346, ExpectedResult = 9)]
        [TestCase(999999999999, ExpectedResult = 9)]
        [Order(1)]
        public int Tests(long n)
        {
            return Number.DigitalRoot(n);
        }
    }
}
