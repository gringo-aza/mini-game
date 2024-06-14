using System;

string star = "*";

ConsoleKey consoleKey;

int width = 0;
int height = 0;


try
{
    do
    {
        Console.SetCursorPosition(width, height);
        consoleKey = Console.ReadKey(true).Key;

        switch (consoleKey)
        {
            case ConsoleKey.UpArrow:
                height--;
                CursorToNewPosition(width, height, star);
                break;
            case ConsoleKey.DownArrow:
                height++;
                CursorToNewPosition(width, height, star);
                break;
            case ConsoleKey.LeftArrow:
                width--;
                CursorToNewPosition(width, height, star);
                break;
            case ConsoleKey.RightArrow:
                width++;
                CursorToNewPosition(width, height, star);
                break;
            default:
                Console.Write("you pressed the wrong button");
                break;
        }

    } while (Convert.ToBoolean(Console.ReadKey().Key));
}

catch
{
    Console.Write("The value must be greater than or equal to zero n\and less than the console's buffer size in that dimension.");
}


static void CursorToNewPosition(int w, int h, string s)
{
    Console.Clear();
    Console.SetCursorPosition(w, h);
    Console.Write(s);
}