using task7;
namespace TestProject1
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
            Assert.AreEqual(Program.MultiplyBy2(2), 4);
            Assert.AreEqual(Program.MultiplyBy2(6), 12);
            Assert.AreEqual(Program.MultiplyBy2(4), 8);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, 1);
            Assert.AreEqual(2+3, 5);
            Assert.AreEqual(2+2*2, 6);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(Math.Sqrt(4), 2);
            Assert.AreEqual(Math.Sqrt(36), 6);
            Assert.AreEqual(Math.Sqrt(9), 3);
        }
    }
}