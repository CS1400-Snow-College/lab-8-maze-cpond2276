// Carson Pond 7/25/2026 Lab 8: Maze part I

Console.Clear();
Console.WriteLine("Welcome to the Maze!!");
Console.WriteLine("Use the arrow keys to move around the maze");
Console.WriteLine("Reach the (*) to escape. Good luck!!");
Console.WriteLine(" ");

string[] mapRows = System.IO.File.ReadAllLines("map.txt");

for (int i = 0; i < mapRows.Length; i++)
{
    Console.WriteLine(mapRows[i]);
}

