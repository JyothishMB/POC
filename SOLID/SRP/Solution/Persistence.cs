using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.Solution
{
    public class Persistence
    {
        public void WriteToTextFile(Journal j, string filename, bool overwrite = true)
        {
            if(overwrite)
                File.WriteAllText(filename, j.ToString());
            else
                File.AppendAllText(filename, j.ToString());
        }
    }
}