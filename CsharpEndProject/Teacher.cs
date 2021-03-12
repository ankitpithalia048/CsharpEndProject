using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsharpEndProject
{
        
        static class Iteacher
        {
            public static void AddTeacher()
            {
                string dir = Directory.GetCurrentDirectory();
                string path = dir + "\\data.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw =  File.CreateText(path))
                    {
                        sw.WriteLine("=========Teacher Record===========");
                    }
                }
                    
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        Console.WriteLine("Enter Name Of The Teacher");
                        sw.Write("Name: " + Console.ReadLine());
                        Console.WriteLine("Enter Class And Section Of The Teacher");
                        sw.Write(", ClassAndSection: " + Console.ReadLine());
                        Console.WriteLine("Enter ID");
                        sw.Write(", ID: " + Console.ReadLine());
                        sw.WriteLine("");
                    }
                
                
            }
            public static void GetTeacherList()
            {
                string dir = Directory.GetCurrentDirectory();
                string path = dir + "\\data.txt";
                //Console.WriteLine(path);
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("============Teacher Record===========");
                    }
                }
               
                    using(StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                
            }
        public static void UpdateTeacher(string id)
        {
            bool flag = false;
            string dir = Directory.GetCurrentDirectory();
            string path = dir + "\\data.txt";
            string[] file = File.ReadAllLines(path);
            StreamWriter writer = File.CreateText(path);
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("=========Teacher Record===========");
                }
            }
            int count = 0;
            foreach(string line in file)
            {
                //Console.WriteLine(line);
                if (line.Contains(id))
                {
                    flag = true;
                    file[count] = " ";
                    Console.WriteLine("Enter Updated Name Of The Teacher");
                   string nm = "Name: " + Console.ReadLine();
                    Console.WriteLine("Enter Updated Class And Section Of The Teacher");
                    string cs = ", ClassAndSection: " + Console.ReadLine();

                    file[count] = nm + cs + ", id: " + id;
                    //Console.WriteLine(file[count] + "  If");
                    writer.WriteLine(file[count]);
                }
                else
                {
                    //Console.WriteLine(file[count] + "  else");
                    writer.WriteLine(line);
                    count++;
                    
                    //Console.WriteLine("Teacher Id not Found");
                }
            }
            if(!flag)
            {
                Console.WriteLine("Id not Found");
            }


            writer.Close();
        }

    }
}
