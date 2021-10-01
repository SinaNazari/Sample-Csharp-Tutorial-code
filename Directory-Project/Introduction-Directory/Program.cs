using System;
using System.IO;

namespace Introduction_Directory
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sample1***
            //Directory.CreateDirectory("C:\\Users\\nzry8\\OneDrive\\Desktop\\s");
            //Console.WriteLine("Create Directory is Success");

            //Sample2***

            // Create new folder in C:\ volume.

            Directory.CreateDirectory(@"C:\\NewFolder");

            // Create another directory with different syntax.

            Directory.CreateDirectory(@"C:\\NewFolder2");

            // Create an already-existing directory (does nothing).

            Directory.CreateDirectory(@"C:\\NewFolder2");

            //Sample3***

            //Check the existence of the file

            //string fileToCopy = "filelocation\\file_name.txt";
            //String server = Environment.UserName;
            //string newLocation = "C:\\Users\\" + server + "\\Pictures\\Tenders\\file_name.txt";
            //string folderLocation = "C:\\Users\\" + server + "\\Pictures\\Tenders\\";
            //bool exists = Directory.Exists(folderLocation);
            //if (!exists)
            //{
            //    Directory.CreateDirectory(folderLocation);
            //    if (File.Exists(fileToCopy))
            //    {
            //        Console.WriteLine("file copied");
            //        File.Copy(fileToCopy, newLocation, true);
            //    }
            //    else
            //    {
            //        Console.WriteLine("no such files");
            //    }
            //}

            Console.ReadKey();
        }
    }
}
