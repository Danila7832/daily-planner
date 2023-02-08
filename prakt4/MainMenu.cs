using System;
namespace prakt4
{
    public class MainMenu
    {
        private static bool repeat = true;
        private static bool pressEnter = false;

        public List<Note> showMainMenu(List<Note> notes)
        {
            DateTime date = DateTime.Today.Date;

            ConsoleKey key;
            do {
                Console.Clear();

                Console.WriteLine("Выбрана дата " + date);
                Console.WriteLine("Для создания новой заметки нажмите пробел");
                Console.WriteLine("Для выхода нажмите escape");


                List<Note> todayNotes = new List<Note>();
                foreach (Note note in notes) {
                    if (note.getDate().Equals(date)) {
                        todayNotes.Add(note);
                    }
                }

                int startPosition = 4;
                int curentPosition = startPosition;
                for (int i = 0; i < todayNotes.Count(); i++) {
                    Console.SetCursorPosition(2, startPosition + i);
                    Console.WriteLine(i + 1 + ". " + todayNotes[i].getName());
                }

                key = Console.ReadKey().Key;
                switch (key) {
                    case ConsoleKey.LeftArrow:
                        date = date.AddDays(-1);
                        break;
                    case ConsoleKey.RightArrow:
                        date = date.AddDays(1);
                        break;
                    case ConsoleKey.Spacebar:
                        notes.Add(new NewNote().createNewNote(date));
                        break;
                    case ConsoleKey.Escape:
                        repeat = false;
                        break;
                    default:
                        if (todayNotes.Count() > 0)
                        {
                            curentPosition = ArrowMenu.drawArrowMenu(startPosition, todayNotes.Count()) - startPosition;
                        }
                        break;
                }

                if (pressEnter) {
                    new NoteDetails(todayNotes[curentPosition]);
                }
             
            } while (repeat);

            return notes;
        }

        public static void setRepeat(bool value) {
            repeat = value;
        }

        public static bool getRepeat()
        {
            return repeat;
        }

        public static void setPressEnter(bool value)
        {
            pressEnter = value;
        }
    }
}

