namespace TestCICD
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup executed");
        }

        [Test]
        public void Test1()
        {
            int result = Add(5, 10);
            Assert.AreEqual(15, result);
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        [Test]
        public void ShowSumTest()
        {
            int a = 5;
            int b = 10;
            int sum = a + b;

            Console.WriteLine("Sum = " + sum);
            Assert.AreEqual(15, sum);
        }
    }
}