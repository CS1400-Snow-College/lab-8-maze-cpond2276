// Carson Pond 7/25/2026 Lab 8: Maze part I

// clearing console and giving user instuctions
Console.Clear();
Console.WriteLine("        ------===== Welcome to the Maze!! =====------");
Console.WriteLine("         Use the arrow keys to move around the maze");
Console.WriteLine(" Navigate to the (*) to win or hit the 'escape' key to quit");
Console.WriteLine("           Press any key to begin and good luck!!");
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
        TryMove(Console.CursorTop -1, Console.CursorLeft, mapRows);
    }
    else if (key == ConsoleKey.DownArrow)
    {
        TryMove(Console.CursorTop + 1, Console.CursorLeft, mapRows);
    }
    else if (key == ConsoleKey.LeftArrow)
    {
        TryMove(Console.CursorTop, Console.CursorLeft - 1, mapRows);
    }
    else if (key == ConsoleKey.RightArrow)
    {
        TryMove(Console.CursorTop, Console.CursorLeft + 1, mapRows);
    }
    if (mapRows[Console.CursorTop][Console.CursorLeft] == '*')//checking to see if cursor is on the finsihing point(could add multple finishing points with this method)
    {
        break;
    }
} while (true);

Console.Clear();
Console.WriteLine("Congrats!! You've made it through the maze!!");

//building TryMove method
static void TryMove(int proposedTop, int proposedLeft, string[] mazeRows)
{
    if (proposedTop >= 0 && proposedTop < mazeRows.Length && proposedTop < Console.BufferHeight) //checking if vertical movement is valid first
    {
        if (proposedLeft >= 0 && proposedLeft < mazeRows[proposedTop].Length && proposedLeft< Console.BufferWidth)//checking to make sure lateral movement is good AFTER making sure the row is valid
        {
            if (mazeRows[proposedTop][proposedLeft] != '#')// making the walls walls with the same logic as used to win the game
            {
            Console.CursorTop = proposedTop;// if it passes this maze of tests then the propsed move by the user can actually happen
            Console.CursorLeft = proposedLeft;
            }
        }
    }
}