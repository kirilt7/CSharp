using System;
using System.IO;

class PointsStorage
{
    public static void SavePath(Path path)
    {
        StreamWriter fileWriter = new StreamWriter("input.txt", true);
        using (fileWriter)
        {
            foreach (var item in path.Points)
            {
                fileWriter.Write("({0} {1} {2}),", item.X, item.Y, item.Z);
            }
        }
    }
    public static Path LoadPath()
    {
        StreamReader fileReader = new StreamReader("input.txt");
        string path = null;
        using (fileReader)
        {
            path = fileReader.ReadToEnd();
        }
        if (path != null)
        {
            Path newPath = new Path();
            newPath.AddPoints(path);
            return newPath;
        }
        else
        {
            throw new NullReferenceException("The file is empty");
        }
    }
}

