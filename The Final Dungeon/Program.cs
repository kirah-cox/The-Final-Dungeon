using System.Text;
using AllMaps;
using AllCreations;
using MyTools;

public class Program
{
    public static void Main()
    {
        string character = "@";

        Map map = new Map();

        StringBuilder sb = new StringBuilder();

        while (true)
        {
            Tools.DrawMap(sb, map, character);

            Tools.Move();
        }
    }
}

