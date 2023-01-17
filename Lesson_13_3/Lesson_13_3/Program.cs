using System.Collections;

namespace Lesson_13_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            //// добавляем контакты
            //phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
            //phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));
            //Console.WriteLine("Введите имя");
            //string name = Console.ReadLine();
            //Console.WriteLine("Введите номер телефона");
            //long phone = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Введите почту");
            //string email = Console.ReadLine();
            //Contact newcontact = new Contact(name, phone, email);
            //foreach (Contact contact in phoneBook)
            //{
            //    Console.WriteLine(contact.Name);
            //}
            //AddUnique(newcontact, phoneBook);
            var months = new List<string>()
            {
               "Jan", "Feb", "Mar", "Apr", "May"
            };
            var missing = new ArrayList()
            {
               1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            
        }

        public static void GetMiss(List<string> months, ArrayList miss)
        {
            // инициализируем массив для 7 нужных нам недостающих элементов
            var missArray = new string[7];
            // извлекаем эти элементы из ArrayList, и копируем в массив
            miss.GetRange(4, 7).CopyTo(missArray);
            // Добавляем наш массив в конец списка
            months.AddRange(missArray);
            // смотрим, что получилось
            foreach (var m in months)
            {
                Console.WriteLine(m);
            }
        }

        public class Contact // модель класса
        {
            public Contact(string name, long phoneNumber, String email) // метод-конструктор
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }

            public String Name { get; set; }
            public long PhoneNumber { get; set; }
            public String Email { get; set; }
        }

        //Задание 13.3.4
        //Напишите метод для нашей телефонной книги, который получает на вход список и новый контакт, и добавляет его, только если он уникален.
        public static void AddUnique(Contact newcontact, List<Contact> phoneBook)
        {
            bool alreadyExists = false;

            // пробегаемся по списку и смотрим, есть ли уже с таким именем
            foreach (var contact in phoneBook)
            {
                if (contact.Name == newcontact.Name)
                {
                    //  если вдруг находим  -  выставляем флаг и прерываем цикл
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
                phoneBook.Add(newcontact);
            //  сортируем список по имени
            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var contact in phoneBook)
            {
                Console.WriteLine(contact.Name + ":" + contact.PhoneNumber);
            }
        }
    }
}