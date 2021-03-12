using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsharpEndProject
{
    class TeacherRecords
    {
        public static void Do()
        {
            string input;
            do
            {
                Console.WriteLine("Please Select One option from below:");
                Console.WriteLine("1.Add Data\n2.List Data\n3. Update Data");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    AddData();
                }
                else if(option ==2)
                {

                    ListData();
                }
                else
                {
                    UpdateData();
                }
                Console.WriteLine("\n\nWant to continue?Want to add or list data?(Type yes/no)");
                input = Console.ReadLine();

            } while (input.Equals("yes"));
        }
        private static void AddData()
        {
            string input;
            do
            {
                
                Console.WriteLine("\n========================== Adding Data of the Teacher record File =========================\n");
                Iteacher.AddTeacher();
                
                
                Console.WriteLine("\n\nWant to add more data?(Type yes/no)");
                input = Console.ReadLine();

            } while (input.Equals("yes"));
        }
        private static void ListData()
        {
            Console.WriteLine("\n========================== List Data of the Teacher record File ==========================\n");
            Iteacher.GetTeacherList();
        }
        private static void UpdateData()
        {
            string input;
            do
            {
                string id;
                Console.WriteLine("\n========================= Updating Data of the Teacher record File ==========================\n");
                Console.WriteLine("Enter the Id of the teacher: ");
                id = Console.ReadLine();
                Iteacher.UpdateTeacher(id);
                Console.WriteLine("\n\nWant to update more data?(Type yes/no)");
                input = Console.ReadLine();

            } while (input.Equals("yes"));
        }
    }
}
