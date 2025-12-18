using static SE6.Program;
namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.IsFalse(CheckFerm(1,2,3,4));
        }
        [Test]
        public void Test2()
        {
            Assert.IsFalse(CheckFerm(4, 3, 2, 5));
        }
        [Test]
        public void Test3()
        {
            Assert.IsFalse(CheckFerm(4, 4, 4, 4));
        }
    }
}