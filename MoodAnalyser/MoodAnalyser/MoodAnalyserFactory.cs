using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyserFactory
    {
        public static Object CreateMoodAnalyse(String className,string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly Executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = Executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch(ArgumentNullException)
                {
                    throw new MoodAnalyseException(MoodAnalyseException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
                }
            }
            else
            {
                throw new MoodAnalyseException(MoodAnalyseException.ExceptionType.NO_SUCH_METHOD, "Constructor not Found");
            }
        }
        public static Object CreateMoodAnalyseUsingParameterizedConstructor(String className, string constructorName,string message)
        {
            Type type = typeof(MoodAnalyser);


            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] {typeof(string)} );
                    Object instance = constructorInfo.Invoke(new Object[] {message});
                    return instance;
                }
                else
                {
                    throw new MoodAnalyseException(MoodAnalyseException.ExceptionType.NO_SUCH_METHOD, "Constructor not Found");
                    
                }
            }
            else
            {
                throw new MoodAnalyseException(MoodAnalyseException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }
    }
}
