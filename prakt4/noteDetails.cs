using System;
namespace prakt4
{
    public class NoteDetails
    {
        public NoteDetails(Note note)
        {
            Console.Clear();

            Console.WriteLine(note.Name);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Содержимое: " + note.Data);
            Console.WriteLine("Дата: " + note.Date);

            Console.ReadKey();







            MainMenu.setPressEnter(false);
        }
    }
}

