using System;
using System.IO;
using System.Net;

namespace Introduction_DownloadFile
{
    class Program
    {
        public const string V = "https://www.codegrepper.com/code-examples/csharp/download+file+from+url+in+c%23+console";

        static void Main(string[] args)
        {

            //sample1

            //using (var client = new WebClient())
            //{
            //    client.DownloadFile(V, "websit.txt");
            //}

            //sample2

            //using (WebClient web1 = new WebClient())
            //    web1.DownloadFile(V, "website.html");

            //sample3

            WebClient downloader = new WebClient();
            using (downloader)
            {
                try
                {
                    downloader.DownloadFile("https://irsv.upmusics.com/99/Mehryar%20%7C%20Darya%20Demo%20(320).mp3", @"D:\New Folder");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine("{0} - {1}", ae.GetType(), ae.Message);
                }
                catch (WebException webEx)
                {
                    Console.WriteLine("{0} - {1}", webEx.GetType(), webEx.Message);
                    Console.WriteLine("Destination not found!");
                }
                catch (NotSupportedException supportEx)
                {
                    Console.WriteLine("{0} - {1}", supportEx.GetType(), supportEx.Message);
                    Console.WriteLine(supportEx.Message);
                }
                catch (Exception allExp)
                {
                    Console.WriteLine("{0} - {1}", allExp.GetType(), allExp.Message);
                }
            }

        }
    }
}