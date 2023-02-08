using System;
namespace prakt4
{
    public static class ArrowMenu
    {
        public static int drawArrowMenu(int startPosition, int menuCount)
        {
            int curentPosition = startPosition;

            bool flag = true;
            ConsoleKey key;
            do {
                Console.SetCursorPosition(0, curentPosition);
                Console.WriteLine("->");

                key = Console.ReadKey().Key;

                switch (key) {
                    case ConsoleKey.UpArrow:
                        if (curentPosition - 1 >= startPosition) {
                            Console.SetCursorPosition(0, curentPosition);
                            Console.WriteLine("  ");
                            curentPosition--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (curentPosition + 1 <= menuCount + startPosition - 1)
                        {
                            Console.SetCursorPosition(0, curentPosition);
                            Console.WriteLine("  ");
                            curentPosition++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        MainMenu.setPressEnter(true);
                        flag = false;
                        break;
                    case ConsoleKey.Escape:
                        MainMenu.setRepeat(false);
                        break;
                    case ConsoleKey.LeftArrow:
                        flag = false;
                        break;
                    case ConsoleKey.RightArrow:
                        flag = false;
                        break;
                }


            } while (MainMenu.getRepeat() && flag);

            return curentPosition;
        }
    }
}

