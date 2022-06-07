using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyseException(MoodAnalyseException.ExceptionType.EMPTY_MESSAGE, "Mood cannot be Empty");
                }
                if (this.message.Contains("sad"))
                    return "sad";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyseException(MoodAnalyseException.ExceptionType.NULL_MESSAGE, "Mood cannot be Null");
                
            }
        }
    }
}
