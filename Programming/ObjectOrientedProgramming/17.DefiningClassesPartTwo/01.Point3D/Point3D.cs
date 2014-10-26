class point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    private static readonly int[] pointO = new int[3];

    public point3D(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    public override string ToString()
    {
        string point = string.Format("({0}, {1}, {2})", X, Y, Z);
        return point.ToString();
    }
    static point3D()
    {
        point3D.pointO[0] = 0;
        point3D.pointO[1] = 0;
        point3D.pointO[2] = 0;
    }
    static int[] PointO
    {
        get
        {
            return point3D.pointO;
        }
    }
}


