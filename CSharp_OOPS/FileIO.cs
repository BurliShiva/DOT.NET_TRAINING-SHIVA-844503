using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo("c:\\samplediretory");
            //dir.Create();

            //FileInfo file = new FileInfo(@"c:\samplediretory\sample.txt");
            //file.Create();

            //Console.WriteLine("The Directory and file is created ");

            //FileStream fs = new FileStream(@"c:\samplediretory\sample.txt",FileMode.OpenOrCreate,FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("The text has been written to the file using file IO manipulation");
            FileStream fs = new FileStream(@"c:\samplediretory\sample.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("The text has been written to the file using append");


            sw.Close();
            fs.Close();

            Console.WriteLine("some text is added to the file");

            fs = new FileStream(@"c:\samplediretory\sample.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
           // var content = sr.ReadToEnd();
            //Console.WriteLine("The file content the:{0}",content);

            string lineByLine;

            while ((lineByLine = sr.ReadLine()) != null) 
            {
                Console.WriteLine("\nThe file content: {0}", lineByLine);
            }
            sr.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
