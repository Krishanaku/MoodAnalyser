using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyzer.MoodAnalayzerCustomExeption;

namespace MoodAnalyzer 
{
    public  class MoodAnalayzerCustomExeption : Exception
    {
       public enum MoodAnalayzeEnum
        {
            NULL_MOOD,
            EMPTY_MOOD

        }
        public MoodAnalayzeEnum enumObj;
        public MoodAnalayzerCustomExeption(MoodAnalayzeEnum enumObj,string message) : base(message) 
        {
            this.enumObj = enumObj;

        }


    }

}
