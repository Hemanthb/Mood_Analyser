using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string mood)
        {
            if (mood.Contains("sad"))
                return "sad";
            else
                return "HAPPY";
        }
    }
}
