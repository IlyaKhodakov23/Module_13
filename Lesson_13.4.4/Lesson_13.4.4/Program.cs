using System.Diagnostics;

namespace Lesson_13._4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // запускаем новый таймер
            var stopWatch = Stopwatch.StartNew();

            //Dictionary<string, Contact> PhoneBook = new Dictionary<string, Contact>();
            //PhoneBook.Add("Илья", new Contact ( 894564684, "erggre43334" ));
            //PhoneBook.Add("Виктор", new Contact(894654546467, "п545р46р56"));
            //foreach (var con in PhoneBook)
            //{
            //    Console.WriteLine(con.Key + ":" + con.Value.PhoneNumber);
            //}

            ////  Попробуем достать контакт для изменения данных
            //if (PhoneBook.TryGetValue("Илья", out Contact contact))
            //{
            //    contact.PhoneNumber = 86546486486;
            //}

            //foreach (var con in PhoneBook)
            //{
            //    Console.WriteLine(con.Key + ":" + con.Value.PhoneNumber);
            //}

            SortedDictionary<string, Contact> PhoneBook = new SortedDictionary<string, Contact>();
            PhoneBook.Add("Илья", new Contact(894564684, "erggre43334"));
            PhoneBook.Add("Виктор", new Contact(894654546467, "п545р46р56"));
            foreach (var con in PhoneBook)
            {
                Console.WriteLine(con.Key + ":" + con.Value.PhoneNumber);
            }

            //  Попробуем достать контакт для изменения данных
            if (PhoneBook.TryGetValue("Илья", out Contact contact))
            {
                contact.PhoneNumber = 86546486486;
            }

            foreach (var con in PhoneBook)
            {
                Console.WriteLine(con.Key + ":" + con.Value.PhoneNumber);
            }

            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

        }

        public class Contact // модель класса
        {
            public Contact(long phoneNumber, String email) // метод-конструктор
            {
                PhoneNumber = phoneNumber;
                Email = email;
            }

            public long PhoneNumber { get; set; }
            public String Email { get; set; }
        }
    }
}