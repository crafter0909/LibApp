using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Тестирование библиотеки:");

                Console.WriteLine("Введите тип:");
                Console.WriteLine("1. Книга:");
                Console.WriteLine("2. Журнал:");
                Console.WriteLine("3. Сборник:");
                Console.WriteLine("Любая другая клавиша для выхода:");
                ConsoleKeyInfo sw = Console.ReadKey();
                Console.WriteLine();
                Lib lib = null;
                
                switch (sw.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Введите название:");
                        string name0 = Console.ReadLine();
                        Console.WriteLine("Введите автора:");
                        string author0 = Console.ReadLine();
                        Console.WriteLine("Введите количество страниц:");
                        int.TryParse(Console.ReadLine(), out int a);
                        lib = new Book(name0, a, author0);
                        break;
                    case '2':
                        Console.WriteLine("Введите название:");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Введите автора:");
                        string author1 = Console.ReadLine();
                        Console.WriteLine("Введите количество страниц:");
                        int.TryParse(Console.ReadLine(), out int v);
                        lib = new Journal(name1, v, author1);
                        break;
                    case '3':
                        Console.WriteLine("Введите название:");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Введите автора:");
                        string author2 = Console.ReadLine();
                        Console.WriteLine("Введите количество страниц:");
                        int.TryParse(Console.ReadLine(), out int f);
                        lib = new Digest(name2, f, author2);
                        break;
                }

                Console.WriteLine(lib?.Format());
                Console.WriteLine("Нажмите любую клавишу для продолжения.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
