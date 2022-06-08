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
        [Test]
        public void GivenMoodNull_AnalyzeMoodAndHandleNullException_ReturnNullMood()
        {
            try
            {
                string message = null;
                Mood_Analyser.MoodAnalyser moodAnalyser = new Mood_Analyser.MoodAnalyser(message);
                string actualResult = moodAnalyser.AnalyseMood();
            }
            catch (Mood_Analyser.MoodAnalyseException exc)
            {
                Assert.AreEqual("Mood cannot be Null", exc.Message);
            }
        }
        [Test]
        public void GivenMoodEmpty_AnalyzeMoodAndHandleEmptyException_ReturnEmptyMood()
        {
            try
            {
                string message = "";
                Mood_Analyser.MoodAnalyser moodAnalyser = new Mood_Analyser.MoodAnalyser(message);
                string actualResult = moodAnalyser.AnalyseMood();
            }
            catch (Mood_Analyser.MoodAnalyseException exc)
            {
                Assert.AreEqual("Mood cannot be Empty", exc.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            Object expected = new Mood_Analyser.MoodAnalyser(message);

            Object obj = Mood_Analyser.MoodAnalyserFactory.CreateMoodAnalyse("Mood_Analyser.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        [Test]
        public void GivenMoodAnalyserImproperClassName_ShouldReturnMoodAnalyserNoclassException()
        {
            try
            {
                string message = null;
                Object expected = new Mood_Analyser.MoodAnalyser(message);

                Object obj = Mood_Analyser.MoodAnalyserFactory.CreateMoodAnalyse("Mood_Analyser.Moodanalyser", "Moodanalyser");
                expected.Equals(obj);
            }
            catch(Mood_Analyser.MoodAnalyseException e)
            {
                Assert.AreEqual("Class not Found",e.Message);
            }
        }
    }
}