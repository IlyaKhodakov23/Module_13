using System.Collections;
using System.Text;

namespace Lesson_13._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new[]
            {
               "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
               1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
            };

            //Сохраните их значения в ArrayList так, чтобы после строкового названия месяца шёл его числовой номер.

            var newlist = new ArrayList();
            for (int i = 0; i < months.Length-1; i++)
            {
                newlist.Add(months[i]);
                newlist.Add(numbers[i]);

            }
            foreach (var value in newlist)
            {
                Console.WriteLine(value);
            }

            //Задание 13.2.6
            //Напишите метод, который на вход принимает любой Arraylist input, а на выходе выдает другой Arraylist с двумя элементами,
            //где первый — число(сумма целочисленных элементов input), а второй — строка(текст, составленный из строковых элементов input).
            var arraylist = new ArrayList()
            {
                1,
                "Ilya",
                2,
                3,
                "Khodakov"
            };

            int sum = 0;
            StringBuilder text = new StringBuilder();

            foreach (var value in arraylist)
            {
                if (value is int)
                {
                    sum += (int)value;
                }
                if (value is string)
                {
                    text.Append(value);
                }
            }
            var result = new ArrayList { sum, Convert.ToString(text) };
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
        }
    }
}