using System;
using System.Collections.Generic;
using System.IO;

namespace Design_Patterns.SingleResponsibility
{
    public class Journal
    {
        private readonly List<string> _journalEntiriesList = new List<string>();

        public int AddEntry(string text)
        {
            _journalEntiriesList.Add(text);
            return _journalEntiriesList.Count;
        }

        public void RemoveEntry(int index)
        {
            _journalEntiriesList.RemoveAt(index);
        }

        // public void Save(string fileName)
        // {
        //     File.WriteAllText(fileName, ToString());
        // }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _journalEntiriesList);
        }
    }
}
