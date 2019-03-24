using System;
using System.Collections.Generic;

namespace DataReceiver
{
    class Program
    {
        static void Main()
        {
            var studentList = new List<Student>()
            {
                new Student
                {
                    StudentsName = "Tom",
                    TestName = "First test",
                    Date = new DateTime(2018, 07, 20),
                    Assessment = 5
                },
                new Student
                {
                    StudentsName = "Ben",
                    TestName = "First test",
                    Date = new DateTime(2018, 07, 20),
                    Assessment = 3
                },
                new Student
                {
                    StudentsName = "Jane",
                    TestName = "Second test",
                    Date = new DateTime(2018, 07, 22),
                    Assessment = 5
                }
            };

            FileHelper.WriteToFile(studentList);
            var assessmentDisplaying = new AssessmentDisplaying();
            var assessment = assessmentDisplaying.DisplayByName();
            foreach (var student in assessment)
            {
                Console.WriteLine("{0}, {1}, {2}", student.Assessment, student.StudentsName, student.Date);
            }
        }
    }
}
