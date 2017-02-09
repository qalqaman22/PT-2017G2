using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Student
{
    class Student
    {
        //Create a student characteristics
        private string fname;
        private string lname;
        private int age;
        private float gpa;

        


        //To save elements
        public Student(string fname, string lname, int age, float gpa)
        {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.gpa = gpa;
        }



        //Override function
        public override string ToString()
        {

            return fname + " " + lname + " " + age + " " + gpa;
        }
    }
}
