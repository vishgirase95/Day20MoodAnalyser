using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        private string messege;

        [TestMethod]
        public void GivenEmptyMessege_WillThrowEmptyException()
        {
            try
            {
                string messege = "";
                MoodAnalys obj = new MoodAnalys(messege);
               
            }
            catch (System.Exception)
            {
                string expected = "Empty";
                MoodAnalys obj = new MoodAnalys(messege);

                string actual = obj.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }
            

        }
        [TestMethod]
        public void GivenNullMessege_willThroughNulloutput ()
        {
            try
            {
                string messege = null;
                MoodAnalys obj = new MoodAnalys(messege);

            }
            catch (System.Exception)
            {
                string messege = null;

                string expected = null;
                MoodAnalys obj = new MoodAnalys(messege);

                string actual = obj.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }


        }
    }
}
