using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static int tabCount = 0;
    static string tab;
    static bool addNewLine = false;
    static bool isFirst = true;
    static StringBuilder sb = new StringBuilder();
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        tab = Console.ReadLine();
        for (int i = 0; i < lines; i++)
        {
            string line = Console.ReadLine();
            ProcessLine(line);
        }
        Console.WriteLine(sb);
    }

    private static void ProcessLine(string line)
    {
        for (int i = 0; i < line.Length; i++)
        {
            char currChar = line[i];
            if (addNewLine && char.IsWhiteSpace(currChar))
            {
                continue;
            }
            if (addNewLine)
            {
                sb.AppendLine();
                addNewLine = false;
                isFirst = true;
            }
            if (currChar == '{')
            {
                if (!addNewLine)
                {
                    if (!isFirst)
                    {
                        sb.AppendLine();
                    }
                }
                AddTabs();
                sb.Append(currChar);
                tabCount++;
                addNewLine = true;
                isFirst = false;
            }
            else if (currChar=='}')
            {
                tabCount--;
                if (!addNewLine)
                {
                    if (!isFirst)
                    {
                        sb.AppendLine();
                    }
                }
                AddTabs();
                sb.Append(currChar);
                addNewLine = true;
                isFirst = false;
            }
            else
            {
                if (isFirst)
                {
                    AddTabs();
                }
                if (!(char.IsWhiteSpace(currChar) && isFirst))
                {
                    if (!(i<line.Length-1 && char.IsWhiteSpace(line[i+1]) && char.IsWhiteSpace(line[i])))
                    {
                        sb.Append(currChar); 
                    }
                }
                isFirst = false;
            }
        }
        if (line[line.Length-1]!='{' && line[line.Length-1]!='}')
        {
            sb.AppendLine();
            isFirst = true;
        }
    }
    static void AddTabs()
    {
        if (tabCount != 0)
        {
            for (int i = 0; i < tabCount; i++)
            {
                sb.Append(tab);
            }
        }
    }
}
