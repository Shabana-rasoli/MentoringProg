namespace TestProject2ndtest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int a = 1;
            int b = 1;

            // Act
            int sum = a + b;

            // Assert
            Assert.AreEqual(2, sum);
        }
    }
}