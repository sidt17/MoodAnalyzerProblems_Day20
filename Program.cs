using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you happy or sad?");

            MoodAnalyser value = new MoodAnalyser("Happy");
           string result= value.AnalyseMood();

            Console.WriteLine(result);
            
        }
    }
}

