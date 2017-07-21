using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { //arrange
            var valuescontroller = new ValuesController();
            //act
            var result = valuescontroller.bmi(0, 0.0);

            //assert 
            Assert.AreEqual(0, result);

        }
    }
}
