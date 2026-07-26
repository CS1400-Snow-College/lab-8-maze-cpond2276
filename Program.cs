// Carson Pond 7/25/2026 Lab 8: Maze part I

// clearing console and giving user instuctions
Console.Clear();
Console.WriteLine("Welcome to the Maze!!");
Console.WriteLine("Use the arrow keys to move around the maze");
Console.WriteLine("Reach the (*) to escape or hit the 'escape' key to quit");
Console.WriteLine("Press any key to begin and good luck!!");
Console.ReadKey(true); // change from instuctions to map

Console.Clear();
// loading in and printing the map
string[] mapRows = System.IO.File.ReadAllLines("map.txt");

for (int i = 0; i < mapRows.Length; i++)
{
    Console.WriteLine(mapRows[i]);
}

//begining of gameplay
Console.SetCursorPosition(0, 0); // staring position set

ConsoleKey key;

do // arrows actually move you around!!
{
    key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.Escape)// giving up the maze :(
    {
        return;
    }
    else if (key == ConsoleKey.UpArrow)
    {
        Console.CursorTop--;
    }
    else if (key == ConsoleKey.DownArrow)
    {
        Console.CursorTop++;
    }
    else if (key == ConsoleKey.LeftArrow)
    {
        Console.CursorLeft--;
    }
    else if (key == ConsoleKey.RightArrow)
    {
        Console.CursorLeft++;
    }
} while (true);