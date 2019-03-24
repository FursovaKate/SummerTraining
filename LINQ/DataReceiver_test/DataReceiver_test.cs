using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataReceiver;

namespace HW_11_test
{
    [TestClass]
    public class AssessmentDisplayingTest
    {
        List<Student> studentList = new List<Student>()
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

        [TestMethod]
        public void DisplayByAssessmentTest()
        {
            FileHelper.WriteToFile(studentList);
            var assessmentDisplaying = new AssessmentDisplaying();
            var actual = assessmentDisplaying.DisplayByAssessment().ToString();
            var expected = new List<Student>()
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
                    StudentsName = "Jane",
                    TestName = "Second test",
                    Date = new DateTime(2018, 07, 22),
                    Assessment = 5
                }
            }.ToString();
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void DisplayByNameTest()
        {
            FileHelper.WriteToFile(studentList);
            var assessmentDisplaying = new AssessmentDisplaying();
            var actual = assessmentDisplaying.DisplayByName().ToString();
            var expected = new List<Student>()
            {
                new Student
                {
                    StudentsName = "Jane",
                    TestName = "Second test",
                    Date = new DateTime(2018, 07, 22),
                    Assessment = 5
                }
            }.ToString();
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void DisplayByDateTest()
        {
            FileHelper.WriteToFile(studentList);
            var assessmentDisplaying = new AssessmentDisplaying();
            var actual = assessmentDisplaying.DisplayByName().ToString();
            var expected = new List<Student>()
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
            }.ToString();
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
