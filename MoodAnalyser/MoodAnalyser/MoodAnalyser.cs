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
                if (this.messege.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }

            }
            catch (Exception)
            {

                return "Happy";
            }
            
        }

    }
}
