using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace zadach1
{
    class streamwriter
    {
        public void writestream() 
        {
            string writePath = @"C:\SomeDir\hta.txt";

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            int a = 1000000;
            Random rd = new Random();
            for (int i = 0; i < a; i++)
            {
                int b = rd.Next(0, 1000);
                sw.WriteLine(b);
            }
            Console.WriteLine("запись выполнена");
            sw.Close();

        }

        public void readstream()
        {
            string path = @"C:\SomeDir\hta.txt";
            StreamReader sr = new StreamReader(path);
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            sr.Close();

        }

        public void change(string newnumber,  int position) 
        {
            string path = @"C:\SomeDir\hta.txt";
            string[] arr = File.ReadAllLines(path);
            arr[position - 1] = newnumber;
            File.WriteAllLines(path, arr);
         }


    }
}
