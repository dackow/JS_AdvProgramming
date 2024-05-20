namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(6)]
        public void TestMethod2(int i)
        {
            if (i == 4)
                Assert.Fail();
        }


        public void TestMethod3(int i)
        {
        }
    }
}