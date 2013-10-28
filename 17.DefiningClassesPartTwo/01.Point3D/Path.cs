using System.Collections.Generic;

class Path
{
    private List<point3D> points = new List<point3D>();

    public List<point3D> Points
    {
        get
        {
            return this.points;
        }
    }
    public void AddPoints(string points)
    {
        string[] allPoints = points.Split(',');
        for (int index = 0; index < allPoints.Length; index++)
        {
            allPoints[index] = allPoints[index].Replace("(", "").Replace(")", "").Trim();
            string[] eachCoordinate = allPoints[index].Split();
            if (eachCoordinate[0] != "")
            {
                point3D newPoint = new point3D(int.Parse(eachCoordinate[0]), int.Parse(eachCoordinate[1]), int.Parse(eachCoordinate[2]));
                this.points.Add(newPoint);
            }

        }
    }
    public void AddPoints(point3D[] pointsArray)
    {
        foreach (var item in pointsArray)
        {
            this.points.Add(item);
        }
    }
    public void AddPoint(point3D point)
    {
        this.points.Add(point);
    }
}

