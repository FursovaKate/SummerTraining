using System;
using System.Collections.Generic;
using System.IO;

namespace DataReceiver
{
    public static class FileHelper
    {
        static string path = @"TextFile.dat";
        public static void WriteToFile(List<Student> list)
        {
            try
            {
                using (var writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    foreach (var s in list)
                    {
                        writer.Write(s.StudentsName);
                        writer.Write(s.TestName);
                        writer.Write(s.Date.ToString());
                        writer.Write(s.Assessment);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<Student> ReadFromFile()
        {
            var studentList = new List<Student>();
            try
            {
                using (var reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        var student = new Student();
                        student.StudentsName = reader.ReadString();
                        student.TestName = reader.ReadString();
                        student.Date = DateTime.Parse(reader.ReadString());
                        student.Assessment = reader.ReadInt32();
                        studentList.Add(student);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return studentList;
        }
    }
}
