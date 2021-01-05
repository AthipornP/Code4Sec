using System;
using System.Reflection;

namespace AssemblyLoadFileSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code4Sec Assembly Load File Sample");
            var assembly = Assembly.Load("System.Text.Encoding, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
            
            Console.WriteLine("System.Text.Encoding Loaded");
            Console.WriteLine();
            Console.WriteLine("List all custom attributes...");
            foreach (var obj in assembly.GetCustomAttributes())
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }
}
