using System;
using System.Collections.Generic;
using System.Text;
static class ExpandSubstring
{
    public static StringBuilder Substring(this StringBuilder str, int index, int length)
    {
        StringBuilder result = new StringBuilder();
        for (int i = index; i < index+length; i++)
        {
            result.Append(str[i]);
        }
        
        return result;
    }
}
class ExtensionMethodSubstring
	{
        static void Main()
        {
            StringBuilder someStringBuiler = new StringBuilder();
            someStringBuiler.Append("Extension Method Substring.");
            Console.WriteLine(someStringBuiler.Substring(5,10));
        }
    }
    
