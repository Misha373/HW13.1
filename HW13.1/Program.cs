using System.Threading.Tasks;

namespace HW13._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DoTasks dotasks = new DoTasks();
            Program program = new Program();
            
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Додати нову справу");
                Console.WriteLine("2. Вивести список справ");
                Console.WriteLine("3. Позначити справу як виконану");
                Console.WriteLine("4. Видалити справу");
                Console.WriteLine("5. Вийти з програми");
                Console.Write("Введіть ваш вибір: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        dotasks.AddTasks();
                        break;
                    case "2":
                        dotasks.DisplayTasks();
                        break;
                    case "3":
                        dotasks.MarkTaskAsDone();
                        break;
                    case "4":
                        dotasks.DeleteTask();
                        break;
                    case "5":
                        Console.WriteLine("Завершення роботи програми.");
                        return;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
                
            }
        }
    }
}
