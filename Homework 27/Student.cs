using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_27
{
    internal class Student
    {
        public int No;
        public string? FullName;
        static int _staticNo;
        public Dictionary <string, int> Exams=new Dictionary<string, int> ();

        public Student()
        {
            _staticNo++;
            No = _staticNo;
        }

        public void AddExam(string examName)
        {
            if (examName == null)
            {
                throw new Exception("There is no exam!");
            }
            
        }


    }
}
