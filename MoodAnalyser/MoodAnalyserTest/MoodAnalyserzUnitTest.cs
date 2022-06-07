namespace MoodAnalyserTest
{
    public class Tests
    {
        
        [Test]
        public void GivenStringMood_AnalyseMood_ReturnSadMood()
        {
            Mood_Analyser.MoodAnalyser moodAnalyser = new Mood_Analyser.MoodAnalyser();
            
            string actualResult = moodAnalyser.AnalyseMood("I'm in sad mood");
            
            Assert.AreEqual("sad", actualResult);
        }

        [Test]
        public void GivenStringAnyMood_AnalyseMood_ReturnHappyMood()
        {
            Mood_Analyser.MoodAnalyser moodAnalyser = new Mood_Analyser.MoodAnalyser();

            string actualResult = moodAnalyser.AnalyseMood("I'm in Any mood");

            Assert.AreEqual("HAPPY", actualResult);
        }

    }
}