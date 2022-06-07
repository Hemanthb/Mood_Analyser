using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyseException:Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE
        }
        public ExceptionType Type;
        public MoodAnalyseException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
