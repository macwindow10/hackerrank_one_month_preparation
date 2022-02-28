using System;

namespace HackerRank
{
    class TimeConversion
    {
        public static void execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string s = Console.ReadLine();

            string result = timeConversion("07:05:45PM");

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static string timeConversion(string s)
        {
            var dt = Convert.ToDateTime(s);
            var result = dt.ToString("HH:mm:ss");
            return result;
        }
    }
}
