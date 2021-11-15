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
            MoodAnalys obj = new MoodAnalys(messege);
            string expected = "Happy";
            string actual = obj.AnalyseMood(messege);
            Assert.AreEqual(expected, actual);

        }
    }
}
