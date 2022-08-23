using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.Problem
{
    public class Journal
    {
        private List<string> journals = new List<string>();
        public Journal()
        {

        }
        public void AddJournal(string journal)
        {
            journals.Add(journal);
        }
        public void RemoveJournal(int index)
        {
            journals.RemoveAt(index);
        }

        public void WriteToTextFile(string filename)
        {
            File.WriteAllText(filename, this.ToString());
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, journals);
        }

    }
}