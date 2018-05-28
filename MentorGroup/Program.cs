using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();
            students = ReadStudents();

            GroupOutput(students);

        }

        static void GroupOutput(SortedDictionary<string, Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine("{0}", st.Key);
                Console.WriteLine("Comments:");
                foreach(var com in st.Value.Comments)
                    Console.WriteLine("- {0}", com);
                Console.WriteLine("Dates attended:");
                foreach(var dat in st.Value.Dates)
                    Console.WriteLine("-- {0}", dat);
            }

        }


        static SortedDictionary<string, Student> ReadStudents()
        {
            SortedDictionary<string, Student> studs = new SortedDictionary<string, Student>();
            

            while (true)
            {
                Student tmp = new Student();
                string inp =  Console.ReadLine();
                if (inp != "end of dates")
                {
                var input =inp.Split(new char[] { ' ', ',' }).ToArray();
                
                    //tmp.name = input[0];
                    for (int i = 1; i < input.Count(); i++)
                        tmp.Dates.Add(DateTime.Parse(input[i]));

                    studs[input[0]] = tmp;
                }
                else
                {
                    break;
                }

            }
            
            while (true)
            {
                Student tmp = new Student();
                var input = Console.ReadLine().Split('-').ToArray();
                if (input[0] != "end of comments")
                {
                    //tmp.name = input[0];
                    if (studs.ContainsKey(input[0]))
                    {
                        for (int i = 1; i < input.Count(); i++)
                            tmp.Comments.Add(input[i]);

                        studs[input[0]].Comments = tmp.Comments;
                    }   
                }
                else
                {
                    break;
                }

            }
            return studs;
            
        }


    }

    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }

        public Student()
        {
            Comments = new List<string>();
            Dates = new List<DateTime>();
        }

    }                   
}
