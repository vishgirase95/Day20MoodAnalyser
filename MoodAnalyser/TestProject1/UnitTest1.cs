using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        private string messege;

        [TestMethod]
        public void Given_InputEmpty_ThrowEmptyOutput()
        {
          
            try
            {
                string messege = "";
                MoodAnalys obj = new MoodAnalys(messege);
                string mood =obj.AnalyseMood(messege);
              
            }
            catch (CustomiseMoodException ex)
            {


            Assert.AreEqual("Empty",ex.Message);

            }

        }
        [TestMethod]
        public void Given_NullInput_through_nullOutput()
        {
          
            try
            {
                string messege = null;
                MoodAnalys obj = new MoodAnalys(messege);
                string mood =obj.AnalyseMood(messege);

              
            }
            catch (CustomiseMoodException ex)
            {


            Assert.AreEqual("Null",ex.Message);

            }

        }

    }
}
