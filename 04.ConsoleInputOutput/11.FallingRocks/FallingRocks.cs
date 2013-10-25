using System;
using System.Threading.Tasks;
using System.Threading;

class FallingRocks
{
    static int score = 0;
    const int pSize = 1;
    const int rocks = 20;
    const int height = 40;
    const int width = 20;
    static char[] rockTypes = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
    static int[] rockX = new int[rocks];
    static int[] rockY = new int[rocks];
    static char[] rockLook = new char[rocks];
    static int player = 9;
    static void initialize()
    {
        Random generator = new Random();
        for (int i = 0; i < rocks; i++)
        {
            rockX[i] = generator.Next(height);
            rockY[i] = generator.Next(width + 1);
            rockLook[i] = rockTypes[generator.Next(12)];
        }
    }
    //sets the consol the way We want *************
    static void setConsole()
    {
        Console.SetWindowSize(width +2, height +2);
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }
    //Tool to set symbols
    static void SetOnPosition(int x, int y, char symbol)
    {
        Console.SetCursorPosition(y, x);
        Console.Write(symbol);
    }
    //the falling rocks and hit detection******************
    static bool rocksFalling()
    {
        for (int i = 0; i < rocks; i++)
            rockX[i]++;
        for (int i = 0; i < rocks; i++)
            if (rockX[i] == height && rockY[i] >= player - pSize && rockY[i] <= player + pSize)
                return false;
        for (int i = 0; i < rocks; i++)
            if (rockX[i] == height)
            {
                rockX[i] = 0;
                Random gen = new Random();
                rockY[i] = gen.Next(width + 1);
                rockLook[i] = rockTypes[gen.Next(12)];
                score++;
            }
        return true;
    }
    //Write operations
    static void writeRocks()
    {
        for (int i = 0; i < rocks; i++)

            SetOnPosition(rockX[i], rockY[i], rockLook[i]);
    }
    static void writePlayer()
    {
        SetOnPosition(height, player, '0');
        SetOnPosition(height, player - pSize, '(');
        SetOnPosition(height, player + pSize, ')');
    }
    static void writeBounds()
    {
        for (int i = 0; i < height; i++)
            SetOnPosition(i, width + 1, '|');
        for (int i = 0; i < width; i++)
            SetOnPosition(height + 1, i, '=');
    }
    static void movePlayerLeft()
    {
        if (player - pSize > 0)
        {
            player--;
        }

    }
    static void movePlayerRight()
    {
        if (player + pSize < width)
        {
            player++;
        }
    }
    static void Main(string[] args)
    {
        initialize();
        setConsole();
        writeBounds();
        writePlayer();
        writeRocks();
        Thread.Sleep(2000);
        while (true)
        {
            //game body
            Console.WriteLine("Score: {0}", score);
            //move player
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                    movePlayerLeft();
                if (key.Key == ConsoleKey.RightArrow)
                    movePlayerRight();
            }
            //rock fall 
            if (!(rocksFalling()))
            {
                Console.Clear();
                Console.SetCursorPosition(6, 0);
                Console.Write("You lose :/");
                Console.SetCursorPosition(6, 1);
                Console.WriteLine("Score: {0}", score);
                break;
            }
            //hit detection 
            //Redraw Ready
            writeBounds();
            writePlayer();
            writeRocks();

            //Sleep console 
            Thread.Sleep(200);
            Console.Clear();

        }
        Console.ReadLine();
    }
}