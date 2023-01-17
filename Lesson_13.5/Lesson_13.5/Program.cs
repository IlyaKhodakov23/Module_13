namespace Lesson_13._5
{
    internal class Program
    {
        public static Stack<string> words = new Stack<string>();
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.QueueMethod();
            //var stack = new Stack<string>();
            //stack.Push("FirstWord");
            //stack.Push("LastWord");
            ////Сначала выводим последнее Ластворд
            //var element = stack.Pop();
            ////Смотрим верхнее оставшееся ФерстВорд
            //var element2 = stack.Peek();
            //Console.WriteLine(element);
            //Console.WriteLine(element2);

            //Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            //Console.WriteLine(" Либо можно ввести pop или peek, если хотите достать слово или посмотреть");
            //Console.WriteLine();

            //while (true)
            //{
            //    var input = Console.ReadLine();
            //    switch(input)
            //    {
            //        case "pop":
            //            words.Pop();
            //            Console.WriteLine();
            //            Console.WriteLine("В стеке:");
            //            foreach (var word in words)
            //            {
            //                Console.WriteLine(" " + word);
            //            }
            //            break;
            //        case "peek":
            //            Console.WriteLine();
            //            Console.WriteLine("Последний элемент:");
            //            Console.WriteLine(words.Peek());
            //            break;
            //        default:
            //            words.Push(input); // Изменить здесь
            //            Console.WriteLine();
            //            Console.WriteLine("В стеке:");
            //            foreach (var word in words)
            //            {
            //                Console.WriteLine(" " + word);
            //            }
            //            break;
            //    }     
            //}
        }
    }
}