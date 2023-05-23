using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyzer.MoodAnalayzerCustomExeption;

namespace MoodAnalyzer
{
    public  class MoodAnalyzers
    {
        string message;
        public MoodAnalyzers()
        {

        }
        public MoodAnalyzers(string message)
        {
            this.message = message;

        }
        public string AnalyzedMood(string message)
        {
            if(message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
        public string AnalyzedMood()
        {
            if(message.Equals(string.Empty))
            {
                throw new MoodAnalayzerCustomExeption(MoodAnalayzeEnum.NULL_MOOD, "Empty value");

            }
            try
            {
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }

            }
            catch(NullReferenceException)
            {
                throw new MoodAnalayzerCustomExeption(MoodAnalayzeEnum.NULL_MOOD,"Null Input");

            }

        }
    }
}
