using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
   public class CustomiseMoodException : Exception
    {
        public enum Enumtype{
        Null_Input, Empty_Input,
                Number_Input
        }
        
        public Enumtype Type;

        public CustomiseMoodException(Enumtype Type, string messege) : base(messege)
        {
           Type= this.Type;
        }


    }
}
