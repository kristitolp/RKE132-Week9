

using System.Collections.Generic;

static void DisplayDataFromFile(List<string> someList)
{
    foreach (string line in someList)
    {
        Console.WriteLine(line);
    }
}