using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DataReceiver
{
    public class AssessmentDisplaying
    {
        private List<Student> inputList;
        public AssessmentDisplaying()
        {
            if (File.Exists("TextFile.dat"))
            {
                try
                {
                    inputList = FileHelper.ReadFromFile();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public List<Student> DisplayByAssessment()
        {
            var studentQuery =
                from student in inputList
                where student.Assessment == 5
                orderby student.Assessment descending
                select student;

            return studentQuery.ToList();
        }

        public List<Student> DisplayByName()
        {
            var studentQuery =
                from student in inputList
                where student.StudentsName == "Jane"
                orderby student.StudentsName descending
                select student;

            return studentQuery.ToList();
        }

        public List<Student> DisplayByDate()
        {
            var studentQuery =
                from student in inputList
                where student.Date == new DateTime(2018, 07, 20)
                orderby student.Date descending
                select student;

            return studentQuery.ToList();
        }
    }
}
