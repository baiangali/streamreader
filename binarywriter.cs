using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace zadach1
{
    class binarywriter
    {
        public void writebinary()
        {
            string path = @"c:\SomeDir\text.txt";
            BinaryWriter f = new BinaryWriter(new FileStream(path, FileMode.Create));
            Random rnd = new Random();
            int raz = 1000000;
            int[] s = new int[raz];
                for (int i = 0; i < raz; i++)
                {
                    s[i] = rnd.Next(1000);
                    f.Write(s[i]); 
                }
            f.Close();
 
        }

        public void readbinary()
        {
            string path = @"c:\SomeDir\text.txt";
            BinaryReader br = new BinaryReader(File.Open (path, FileMode.Open));
            Console.WriteLine(br.ReadInt32());
            br.Close();
        }
       

    }
}
