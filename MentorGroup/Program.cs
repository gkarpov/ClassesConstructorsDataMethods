using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

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
                    foreach (var com in st.Value.Comments)
                        Console.WriteLine("- {0}", com);
                    Console.WriteLine("Dates attended:");
                    foreach (var dat in st.Value.Dates)
                        Console.WriteLine("-- {0:dd/MM/yyyy}", dat);
                
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
                    if(!studs.ContainsKey(input[0]))
                        studs[input[0]] = new Student();
                    if (input.Count() > 1)
                    {
                        for (int i = 1; i < input.Count(); i++)
                        {
                           studs[input[0]].Dates.Add(DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        }
                        studs[input[0]].Dates.Sort();
                    }

                }
                else
                {
                    break;
                }

            }
            
            while (true)
            {
                Student tmp = new Student();
                string inp =  Console.ReadLine();
                if (inp != "end of comments")
                {
                    var input = inp.Split('-').ToArray();
                
                    if (studs.ContainsKey(input[0]))
                    {
                        for (int i = 1; i < input.Count(); i++)                           
                            studs[input[0]].Comments.Add(input[i]);
                        
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
