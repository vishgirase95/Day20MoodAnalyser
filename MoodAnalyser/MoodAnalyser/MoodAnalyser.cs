using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalys
    {
        public MoodAnalys(string messege)
        {
            this.messege = messege;
        }
        private string messege;


        public string AnalyseMood(string messege)
        {

            try
            {
                if (this.messege.Equals(string.Empty))
                {
                    throw new CustomiseMoodException(CustomiseMoodException.Enumtype.Empty_Input, "Empty");
                }
                if (this.messege.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }

            }
            catch (NullReferenceException)
            {

                throw new CustomiseMoodException(CustomiseMoodException.Enumtype.Empty_Input, "Null");

            }
            
        }

    }
}
