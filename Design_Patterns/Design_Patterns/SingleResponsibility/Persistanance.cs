using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Design_Patterns.SingleResponsibility
{
    public class Persistence
    {
        public void WriteAllText(Journal journal, string fileName, bool overWrite = false)
        {
            if (overWrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, journal.ToString());
            }
        }
    }
}
