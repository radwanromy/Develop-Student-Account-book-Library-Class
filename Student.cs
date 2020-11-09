using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Student
    {
        string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        
        public Student()
        {
            Console.WriteLine("Student Default");
        }
        public Student(string name, string id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
            Console.WriteLine("Student Valued Constructor");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA : " + cgpa);
        }

    }
}