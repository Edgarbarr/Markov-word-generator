using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MarkovText
{
    class Program
    {
        static void Main(string[] args)
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName (Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

            string filepath = $"{wanted_path}\\words_alpha.txt";

            Console.WriteLine(wanted_path+"\\word_alpha.txt");
           string[] lines = File.ReadAllLines(filepath);

            for (var i = 0; i < 10;++i)
           {
                // Use a tab to indent each line of the file.
               Console.WriteLine("\t" + lines[i]);
          }
        }
    }
}
