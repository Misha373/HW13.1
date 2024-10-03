using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13._1
{
    internal class DoTasks
    {
        public List<string> Tasks = new List<string>();
        public List<bool> TasksStatus = new List<bool>();
        public void AddTasks()
        {
            Console.Write("Введіть назву справи: ");
            string task = Console.ReadLine();
            Tasks.Add(task);
            TasksStatus.Add(false); // Нові справи спочатку позначаються як невиконані
            Console.WriteLine("Справу додано до списку.");
        }
        public void DisplayTasks()
        {
            if (Tasks.Count == 0)
            {
                Console.WriteLine("Список справ порожній.");
                return;
            }
            else
            {
                Console.WriteLine("Список справ:");
                for (int i = 0; i < Tasks.Count; i++)
                {
                    string status;
                    if (TasksStatus[i])
                    {
                        status = "[Виконано]";
                    }
                    else
                    {
                        status = "[Не виконано]";

                    }
                    
                    Console.WriteLine($"{i + 1}. {Tasks[i]} {status}");
                }
            }
        }
        public void MarkTaskAsDone()
        {
            if (Tasks.Count == 0)
            {
                Console.WriteLine("Список справ порожній.");
                return;
            }
            try
            {
                Console.Write("Введіть номер справи яку ви виконали: ");
                int Num = int.Parse(Console.ReadLine());
               TasksStatus[Num-1] = true;
                Console.WriteLine("Справа успішно виконана.");
            }
            catch
            {
                Console.WriteLine("Невірний номер справи");
            }
        }
        public void DeleteTask()
        {
            if(Tasks.Count == 0)
            {
                Console.WriteLine("Список справ порожній.");
                return;
            }
            try
            {


                Console.Write("Введіть номер справи яку ви хочете видалити: ");
                int Num = int.Parse(Console.ReadLine());
                Tasks.RemoveAt(Num-1);
                TasksStatus.RemoveAt(Num-1);
                Console.WriteLine("Справа успішно видалена");
            }
            catch
            {
                Console.WriteLine("Невірний номер справи");
            }
        }

    }
}
