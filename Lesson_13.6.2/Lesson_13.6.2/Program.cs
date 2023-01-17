using System.Linq;
using System.Text.RegularExpressions;

namespace Lesson_13._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader("C:\\Users\\user\\Desktop\\IT\\Code\\Module_13_Collection\\Practicum_13_1\\Text1.txt");
            List<string> text = new List<string>();
            
            while (!stream.EndOfStream)
            {
                string line = stream.ReadLine();
                //Regex.Replace(line, ",", string.Empty);
                //Regex.Replace(line, ".", string.Empty);
                //Regex.Replace(line, "-", string.Empty);
                text.Add(line);
            }
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            stream.Close();
            foreach (string line in text) { Console.WriteLine(line); }


        }
    }
}