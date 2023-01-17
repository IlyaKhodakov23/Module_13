using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13._5
{
    internal class Queue
    {
        public void QueueMethod()
        {
            // создаем очередь
           Queue<int> q = new Queue<int>();
 
           // добавляем в нее целые числа от 0 до 10
           for (int i = 0; i <= 10; i++)
           {
               q.Enqueue(i);
               Console.WriteLine($"{i} зашёл в очередь" );
           }
 
           // Посмотрим, кто первый в очереди
           Console.WriteLine( $"Первый элемент:   {q.Peek()}" );
          
           // Обратите внимание, после  вызова Peek() элемент остается в очереди
          
           //  Посмотрим всю очередь
           Console.WriteLine("Элементы в очереди");
           foreach (int i in q)
               Console.Write(i +  " ");
 
           Console.WriteLine();
           Console.WriteLine($"В очереди  {q.Count} элементов");
          
           // обработаем очередь -
           // достанем из неё элементы один за другим
           var queueLength = q.Count;
           for (int i = 0; i < queueLength; i++)
               Console.WriteLine($"{q.Dequeue()} вышел из очереди");
          
           //  Посмотрим, сколько элементов осталось
        }
    }
}
