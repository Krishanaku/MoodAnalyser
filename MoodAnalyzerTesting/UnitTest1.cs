using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;

namespace MoodAnalyzerTesting
{
    [TestClass]
    public class MoodAnalayzerTest
    {
        MoodAnalyzers moodAnalyzer = new MoodAnalyzers();
        [TestMethod]
        public void Return_Mood_Sad()
        {
            String result = moodAnalyzer.AnalyzedMood(" I am in Sad Mood ");
            Assert.AreEqual(result, "Sad");


        }
        [TestMethod]
        public void Return_Mood_Happy()
        {
            String result = moodAnalyzer.AnalyzedMood(" I am in Any Mood ");
            Assert.AreEqual(result, "Happy");


        }
        [TestMethod]
        public void Return_Sad_Contructor()
        {
            MoodAnalyzers moodAnalyzer = new MoodAnalyzers(" I am in Sad Mood ");


            String result = moodAnalyzer.AnalyzedMood();
            Assert.AreEqual(result, "Sad");


        }
        [TestMethod]
        public void Return_Happy_Contructor()
        {
            String result = moodAnalyzer.AnalyzedMood(" I am in Any Mood ");
            Assert.AreEqual(result, "Happy");


        }
        [TestMethod]
        public void Null_Return_Using_Custom_Exception()
        {
            MoodAnalyzers moodAnalyzer = new MoodAnalyzers(null);
            try
            {
                String result = moodAnalyzer.AnalyzedMood();
                
            }
            catch (MoodAnalayzerCustomExeption ex)
            {
                Assert.AreEqual("null input",ex.Message);
            }


        }
        [TestMethod]
        public void Empty_Return_Using_Custom_Exception()
        {
            MoodAnalyzers moodAnalyzer = new MoodAnalyzers("");
            try
            {
                String result = moodAnalyzer.AnalyzedMood();

            }
            catch (MoodAnalayzerCustomExeption ex)
            {
                Assert.AreEqual("Empty value", ex.Message);
            }


        }
    }
}
