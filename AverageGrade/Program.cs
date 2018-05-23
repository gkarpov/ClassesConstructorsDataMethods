using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            List<Student> studentList = ReadAllStudents(num);

            GradeComparer gc = new GradeComparer();
            

            studentList = FilterStudents(studentList, 5);
            //studentList = studentList.OrderBy(obj => obj.AverageGrade).ToList();
            studentList.Sort(gc);
            studentList = studentList.OrderBy(obj => obj.Name).ToList();
            
            PrintStudents(studentList);
        }
        
        static List<Student> ReadAllStudents(int num)
        {
            List<Student> tmp = new List<Student>();
            for (int i = 0; i < num; i++)
            {   
                var stud  = new Student();
                stud.ReadStudent(Console.ReadLine());
                tmp.Add(stud);

            }

            return tmp;
        }

        static List<Student> FilterStudents(List<Student> list, double grade)
        {
            
            for (int i = list.Count-1; i >=0; i--)
            {
                if (list.ElementAt(i).AverageGrade < grade)
                    list.RemoveAt(i);
            }

            return list;
        }

        static void PrintStudents(List<Student> list)
        {
            //list.Sort();

            foreach(var stud in list)
                Console.WriteLine("{0} -> {1:0.00}", stud.Name, stud.AverageGrade);
            
        }


    }

    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade
        {
            get {
                return Average(Grades);
            }
        }

        double Average(double[] grades)
        {
            double result = 0;
            foreach (var gr in grades)
            {
                result += gr;

            }
            return result / grades.Count();
        }

        public void ReadStudent(string input)
        {
            String[] tmp = input.Split(' ').ToArray();
            double[] notes = new double[tmp.Count()-1];

            this.Name = tmp[0];
            for (int i = 1; i < tmp.Count();i++ )
                notes[i-1] = double.Parse(tmp[i]);
            this.Grades = notes;
        }
    }



    class GradeComparer : IComparer<Student>
    {
        public int Compare(Student o1, Student o2)
        {
            if (o1.AverageGrade < o2.AverageGrade)
            {
                return 1;
            }
            else if (o1.AverageGrade > o2.AverageGrade)
            {
                return -1;
            }

            return 0;
        }
    }

    
}
