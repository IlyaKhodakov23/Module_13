using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Practicum_13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //StreamReader stream = new StreamReader("C:\\Users\\user\\Desktop\\IT\\Code\\Module_13_Collection\\Practicum_13_1\\Text1.txt");
            //listadd();
            //linkedlistadd();
            popular10words();
        }

        static void listadd()
        {
            StreamReader str = new StreamReader("C:\\Users\\user\\Desktop\\IT\\Code\\Module_13_Collection\\Practicum_13_1\\Text1.txt");
            var timer = new Stopwatch();
            timer.Start();
            List<string> text = new List<string>();
            while (!str.EndOfStream)
            {
                text.Add(str.ReadLine());
            }
            timer.Stop();
            Console.WriteLine("Время добавления в list: " + timer.Elapsed.Milliseconds);
            Console.WriteLine(text.Count);
            //foreach (string line in text) { Console.WriteLine(line); }
        }

        static void linkedlistadd()
        {
            StreamReader str = new StreamReader("C:\\Users\\user\\Desktop\\IT\\Code\\Module_13_Collection\\Practicum_13_1\\Text1.txt");
            var timer = new Stopwatch();
            timer.Start();
            LinkedList<string> text = new LinkedList<string>();
            var sent = text.AddFirst(str.ReadLine());
            while (!str.EndOfStream)
            {
                text.AddAfter(text.First, str.ReadLine());
                
            }
            timer.Stop();
            Console.WriteLine("Время добавления в linkedlist: " + timer.Elapsed.Milliseconds);
            //Console.WriteLine(text.First.Value);
            Console.WriteLine(text.Count);
            //foreach (string line in text) { Console.WriteLine(line); }
        }

        static void popular10words()
        {
            string txt = File.ReadAllText("C:\\Users\\user\\Desktop\\IT\\Code\\Module_13_Collection\\Practicum_13_1\\Text1.txt");
            //уберем пунктуацию
            var noPunctuationText = new string(txt.Where(c => !char.IsPunctuation(c)).ToArray());
            //зададим разделители
            char[] delimetrs = new char[] { ' ', '\r', '\n', '\t' };
            var words = noPunctuationText.Split(delimetrs);
            //Console.WriteLine(words.Length);
            //List<string> list = new List<string>();
            //foreach (var word in words)
            //{
            //    list.Add(word);
            //    //Console.WriteLine(word);
            //}
            //сложим элементы в сортированный словарь
            SortedDictionary<string, int> sortwords = new SortedDictionary<string, int>();
            foreach (var word in words)
            {
                //исключим слова, предлоги, междометия, союзы с менее чем 4 буквами
                if (word.Length > 3)
                {
                    //проверяем что слова нет
                    if (!sortwords.ContainsKey(word))
                    {
                        //добавляем в словарь
                        sortwords.Add(word, 1);
                        //Console.WriteLine(word);
                    }
                    else
                    {
                        //если слово есть, находим по ключу и прибавляем 1!!!
                        sortwords[word] += 1;
                    }
                }
            }
            //отсортируем по значению
            var sorted = sortwords.OrderByDescending(x => x.Value).ToArray();
            //возьмем 10 первых
            var top10 = sorted.Take(10);
            foreach (KeyValuePair<string, int> word in top10)
            {
                Console.WriteLine(word.Key + ":" + word.Value);
            }



        }
    }
}