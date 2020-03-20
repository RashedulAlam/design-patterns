using System;
using System.Diagnostics;
using Design_Patterns.SingleResponsibility;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("My first Journal");
            journal.AddEntry("My second Journal");
            var persistence = new Persistence();
            persistence.WriteAllText(journal, @"D:\1.txt");
            Process.Start(@"cmd.exe",@"D:\1.txt");
            Console.WriteLine(journal);
        }
    }
}
