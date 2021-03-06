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

            Object obj = Mood_Analyser.MoodAnalyserReflector.CreateMoodAnalyse("Mood_Analyser.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        [Test]
        public void GivenMoodAnalyserImproperClassName_ShouldReturnMoodAnalyserNoclassException()
        {
            try
            {
                string message = null;
                Object expected = new Mood_Analyser.MoodAnalyser(message);

                Object obj = Mood_Analyser.MoodAnalyserReflector.CreateMoodAnalyse("Mood_Analyser.Moodanalyser", "Moodanalyser");
                expected.Equals(obj);
            }
            catch (Mood_Analyser.MoodAnalyseException e)
            {
                Assert.AreEqual("Class not Found", e.Message);
            }
        }

        [Test]
        public void GivenMoodAnalyserImproperConstructorName_ShouldReturnMoodAnalyserNoMethodException()
        {
            try
            {
                string message = null;
                Object expected = new Mood_Analyser.MoodAnalyser(message);

                Object obj = Mood_Analyser.MoodAnalyserReflector.CreateMoodAnalyse("Mood_Analyser.MoodAnalyser", "Moodanalyser");
                expected.Equals(obj);
            }
            catch (Mood_Analyser.MoodAnalyseException e)
            {
                Assert.AreEqual("Constructor not Found", e.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyseProperMesssage_UseParameterizedConstructor_ReturnMoodAnalyserObject()
        {
            string message = "HAPPY";
            Object expected = new Mood_Analyser.MoodAnalyser(message);

            Object obj = Mood_Analyser.MoodAnalyserReflector.CreateMoodAnalyseUsingParameterizedConstructor("Mood_Analyser.MoodAnalyser", "MoodAnalyser", message);
            expected.Equals(obj);
        }
        [Test]
        public void GivenMoodAnalyserImproperClassName_UsingParameterizedConstructor_ShouldReturnMoodAnalyserNoclassException()
        {
            try
            {
                string message = "sad";
                Object expected = new Mood_Analyser.MoodAnalyser(message);

                Object obj = Mood_Analyser.MoodAnalyserReflector.CreateMoodAnalyseUsingParameterizedConstructor("Mood_Analyser.MoodAnalyser", "MoodAnalyser", message);
                expected.Equals(obj);
            }
            catch (Mood_Analyser.MoodAnalyseException e)
            {
                Assert.AreEqual("Class not Found", e.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserImproperConstructorName_UsingParameterizedConstructor_ShouldReturnMoodAnalyserNoConstructorException()
        {
            try
            {
                string message = "sad";
                Object expected = new Mood_Analyser.MoodAnalyser(message);

                Object obj = Mood_Analyser.MoodAnalyserReflector.CreateMoodAnalyseUsingParameterizedConstructor("Mood_Analyser.MoodAnalyser", "MoodAnalyser", message);
                expected.Equals(obj);
            }
            catch (Mood_Analyser.MoodAnalyseException e)
            {
                Assert.AreEqual("Constructor not Found", e.Message);
            }
        }

        [Test]
        public void GivenHappy_InvokeMethod_ShouldReturnHappy()
        {
            string message = "HAPPY";
            string mood = Mood_Analyser.MoodAnalyserReflector.InvokeAnalyseMood("AnalyseMood", "Happy");
            Assert.AreEqual(mood, message);
        }
        [Test]
        public void GivenImproperField_UseReflectorInvoke_ReturnExceptionNoField()
        {
            try
            {
                string message = "Happy";
                string fieldName = "messag";
                Object expected = new Mood_Analyser.MoodAnalyser(message);
                Object actual = Mood_Analyser.MoodAnalyserReflector.SetField(message, fieldName);
                Assert.AreEqual(expected.ToString(), actual.ToString());
            }
            catch (Mood_Analyser.MoodAnalyseException e)
            {
                Assert.AreEqual("Field is not Found", e.Message);
            }
        }
        public void GivenNullInMessageField_UseReflectorInvoke_ReturnExceptionNullMessage()
        {
            try
            {
                string message = null;
                string fieldName = "message";
                Object expected = new Mood_Analyser.MoodAnalyser(message);
                Object actual = Mood_Analyser.MoodAnalyserReflector.SetField(message, fieldName);
                Assert.AreEqual(expected.ToString(), actual.ToString());
            }
            catch (Mood_Analyser.MoodAnalyseException e)
            {
                Assert.AreEqual("Field is not Found", e.Message);
            }
        }
    }
}