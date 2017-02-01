using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class QuelleErstellen
    {
        public QuelleErstellen()
        {

        }

        public string MerkmalKennung { get; set; }
        public string MerkmalBeschreibung { get; set; }
        public string MerkmalTyp { get; set; }

        public void ErzeugeLogdatei()
        {
            string[] lines = { MerkmalKennung , MerkmalBeschreibung , MerkmalTyp  };

            System.IO.File.WriteAllLines(@"C:\Users\Public\WriteLines.txt", lines);
        }
        // Example #1: Write an array of strings to a file.
        // Create a string array that consists of three lines.
        
        // WriteAllLines creates a file, writes a collection of strings to the file,
        // and then closes the file.  You do NOT need to call Flush() or Close().

    }
}
