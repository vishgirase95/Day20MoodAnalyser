using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        private string messege;

        [TestMethod]
        public void TestMethod1()
        {
            string messege = null;
            MoodAnalys obj = new MoodAnalys();
            string expected = "Hap";
            string actual = obj.AnalyseMood();
            Assert.AreEqual(expected, actual);

        }
    }
}
