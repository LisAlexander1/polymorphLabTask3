using System;

//Чиннов 3 вариант сложный

namespace polymorphLabTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new("Козлов Артем Владимирович",10),
                new SmartStudent("Лукъянов Глеб Олегович", 17),
                new SmartStudent("Майборода Анатолий",15),
                new SmartStudent("Миронова Анастасия Валерьевна", 20),
                new("Павлов Виталий Евгеньевич", 11),
                new("Пономаренко Владимир Михайлович", 5),
                new SmartStudent("Саидбаев Александр Павлович", 15),
                new("Фадеев Тимур Сергеевич", 18),
                new("Фисенко Ярослав Сергеевич", 2),
                new("Хайруллоев Давлат Дилмуродович", 19),
                new SmartStudent("Горбачев Денис", 15),
                new("Шляхтин Леонид Денисович", 5),
                new SmartStudent("Богомолов Даниил Олегович", 11),
                new("Миньков Владимир Александрович", 15),
                new("Петросян Араик Завенович", 20),
                new("Скрипников Сергей Алексеевич", 16),
                new GeniusStudent("Ухватов Владислав Алексеевич", 1),
                new GeniusStudent("Чиннов Данил Владимирович", 18),
                new SmartStudent("Дягелев Киририлл", 20)
            };

            do
            {
                for (int i = 0; i < students.Length; i++)
                {
                    Console.ForegroundColor = i % 2 == 0 ? ConsoleColor.White : ConsoleColor.DarkCyan;
                    Console.Write(students[i].Info() + " - ");
                    bool result = students[i].PassExam();
                    Console.ForegroundColor = result ? ConsoleColor.Green : ConsoleColor.Red;
                    Console.WriteLine(result ? "cдал" : "не сдал");
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Нажмите любую кнопку, чтобы повторить экзамен");
                Console.ReadKey();
                Console.Clear();
            } while (true);
            
        }
    }
}