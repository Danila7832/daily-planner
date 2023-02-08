using System;
namespace prakt4
{
    public class NewNote
    {
        public Note createNewNote(DateTime date)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Введите название заметки");
                string name = Console.ReadLine();

                Console.WriteLine("Введите содержимое заметки");
                string data = Console.ReadLine();

                if (data != null && data != "" && name != null && name != "")
                {
                    return new Note(date, name, data);
                }
                else
                    Console.WriteLine("Название или содержимое не заполнено,попробуйте еще раз");

                Console.ReadKey();

            } while (true);

        }
    }
}

