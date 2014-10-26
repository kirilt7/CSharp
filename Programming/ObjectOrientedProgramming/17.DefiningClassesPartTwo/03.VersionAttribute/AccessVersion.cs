[System.AttributeUsage(System.AttributeTargets.Struct |
                       System.AttributeTargets.Class |
                       System.AttributeTargets.Interface |
                       System.AttributeTargets.Enum |
                       System.AttributeTargets.Method)
]

class AccessVersion : System.Attribute
{
    public int Major { get; private set; }
    public int Minor { get; private set; }

    public AccessVersion(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }
}

