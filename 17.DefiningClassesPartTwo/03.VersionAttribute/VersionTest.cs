using System;

[AccessVersion(1, 5)]
class VersionTest
{
    static void Main()
    {
        Type type = typeof(VersionTest);
        object[] allVersions = type.GetCustomAttributes(false);
        foreach (AccessVersion version in allVersions)
        {
            Console.WriteLine("The current version of the class is {0}.{1}\n",
                version.Major, version.Minor);
        }
    }
}

