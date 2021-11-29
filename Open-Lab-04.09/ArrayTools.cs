using System;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
          
 
		string[]  a = strings.Distinct().ToArray();
            return a;
        }
    }
}
