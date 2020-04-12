using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;


namespace zadach1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            streamwriter sr = new streamwriter();
            sr.writestream();
            sr.change("778", 200);
            sr.change("778", 700);

            binarywriter bw = new binarywriter();
            bw.writebinary();

            string gzppath = @"C:\SomeDir\gzp.txt";
            FileStream fss = new FileStream(gzppath, FileMode.OpenOrCreate);
            GZipStream gzp = new GZipStream(fss, CompressionLevel.Optimal);
            StreamWriter sw = new StreamWriter(gzp);
            Random ran = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                sw.WriteLine(ran.Next(1000));
            }
            sw.Close();



        }
    }
}
