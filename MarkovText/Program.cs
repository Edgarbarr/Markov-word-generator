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
            var filepath = Filepath();

            string[] lines = File.ReadAllLines(filepath);

            //string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName (Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

           // string filepath = $"{wanted_path}\\words_alpha.txt";

           // return filepath;

           
           

            var model = new MarkovModel();

            //for (var i = 0; i < lines.Length;++i)
           {
                // Use a tab to indent each line of the file.
               Console.WriteLine("\t" + lines[i]);
          }
        }
        static string Filepath()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName (Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

             string filepath = $"{wanted_path}\\words_alpha.txt";
            return filepath;
        }
    }
}
