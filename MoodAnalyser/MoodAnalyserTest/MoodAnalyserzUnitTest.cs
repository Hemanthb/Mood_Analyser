namespace MoodAnalyserTest
{
    public class Tests
    {
        
        [Test]
        public void GivenStringMood_AnalyseMood_ReturnSadMood()
        {
            string message = "I am in Sad mood";
            Mood_Analyser.MoodAnalyser moodAnalyser = new Mood_Analyser.MoodAnalyser(message.ToLower());
            
            string actualResult = moodAnalyser.AnalyseMood();
            
            Assert.AreEqual("sad", actualResult);
        }

        [Test]
        public void GivenStringAnyMood_AnalyseMood_ReturnHappyMood()
        {
            string message = "I am in Happy mood";
            Mood_Analyser.MoodAnalyser moodAnalyser = new Mood_Analyser.MoodAnalyser(message);

            string actualResult = moodAnalyser.AnalyseMood();

            Assert.AreEqual("HAPPY", actualResult);
        }

        [Test]
        public void GivenNullMood_AnalyseMood_ReturnHappyMood()
        {
            string message = null;
            Mood_Analyser.MoodAnalyser moodAnalyser = new Mood_Analyser.MoodAnalyser(message);

            string actualResult = moodAnalyser.AnalyseMood();

            Assert.AreEqual("HAPPY", actualResult);
        }
    }
}