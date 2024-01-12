using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SchoolData;

namespace TestSchoolData
{
    public class SchoolDataTest
    {
        Student s = new Student();

        Subject sub = new Subject();
        Teacher ts = new Teacher();

        [TestCase("Praveen", ExpectedResult = true)]
        [TestCase("Sudhakar", ExpectedResult = false)]
        [TestCase("Mahesh", ExpectedResult = true)]
        [TestCase("Ramanji", ExpectedResult = true)]
        public bool IsName(string search)
        {
            return s.Search(search);
        }

        [TestCase("Mathematics", ExpectedResult = true)]
        [TestCase("Science", ExpectedResult = true)]
        [TestCase("English", ExpectedResult = true)]
        [TestCase("Social", ExpectedResult = false)]
        public bool IsSubject(string subj)
        {
            return sub.Search(subj);
        }

        [TestCase("Lokesh", ExpectedResult = true)]
        [TestCase("Rubhitha", ExpectedResult = true)]
        [TestCase("Raina", ExpectedResult = false)]
        [TestCase("Swetha", ExpectedResult = false)]
        [TestCase("Satish", ExpectedResult = true)]
        public bool IsTeacher(string t)
        {

            return ts.Search(t);

        }
    }
}