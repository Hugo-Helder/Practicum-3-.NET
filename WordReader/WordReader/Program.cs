using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace WordReader
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Gets the path of the textfile relative to the project (no need for absolute file paths)
            // ?? is a null coalescing operator: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                @"Resources\randomtext.txt");
            
            // ...Implement the GetWords method
            
            // ...Sort the array based on length
            
        }

        public static IEnumerable<string> GetWords(/* Fill in the right parameters */)
        {
            return null;
        }
    }
}
