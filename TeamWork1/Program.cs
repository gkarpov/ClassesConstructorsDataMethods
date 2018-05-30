using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TeamWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            SortedDictionary<string, Team> teams = new SortedDictionary<string, Team>();

            CreateTeams(num, teams);
            JoinTeams(teams);
            PrintTeams(teams);

        }

        private static void PrintTeams(SortedDictionary<string, Team> teams)
        {
           
            foreach (var tm in teams.OrderBy(x => x.Key).ThenBy(x => x.Value.members.Count))
            {
                if (tm.Value.members.Count != 0)
                {
                    Console.WriteLine("{0}", tm.Key);
                    Console.WriteLine("- {0}", tm.Value.creator);

                    tm.Value.members.Sort();

                    foreach (var mem in tm.Value.members)
                        Console.WriteLine("-- {0}", mem);
                }
            }
            
            Console.WriteLine("Teams to disband:");

            foreach (var tm in teams.OrderBy(x => x.Key))
            {
                if(tm.Value.members.Count == 0)
                Console.WriteLine("{0}", tm.Key);
            }
            
        }

        private static void JoinTeams(SortedDictionary<string, Team> teams)
        {
           
            while (true)
            {
                var input = Console.ReadLine();
                
                if(input == "end of assignment")
                    break;

                var split = input.Split(new char[] { '-', '>' });
                
                if(!teams.ContainsKey(split[2]))
                {
                    Console.WriteLine("Team {0} does not exist!", split[2]);
                    continue;
                }
                
               if (teams.Any(cr => cr.Value.creator == split[0])||teams.Any(c => c.Value.members.Contains(split[0])))
               {
                     Console.WriteLine("Member {0} cannot join team {1}!", split[0], split[2]);
                     continue;
               }
               
                teams[split[2]].members.Add(split[0]);
                    
           }

                

        }




        private static void CreateTeams(int num, SortedDictionary<string, Team> tm)
        {
           

            //string[] input = new string[2];

            for (int i = 0; i < num; i++)
            {
                
                var input = Console.ReadLine().Split('-').ToArray();

                //if (tm.ContainsKey(input[1]))
                if (tm.Any(t => t.Key == input[1]))
                {
                    Console.WriteLine("Team {0} was already created!", input[1]);
                    continue;
                }
                
                if (tm.Any(c => c.Value.creator == input[0]))
                {
                   Console.WriteLine("{0} cannot create another team!", input[0]);
                   continue;
                        
                }
                
                tm[input[1]] = new Team(input[0]);
                Console.WriteLine("Team {0} has been created by {1}!", input[1], input[0]);
            }

        }
    
    }

    class Team
    {
        public string creator { get; set; }
        public List<string> members { get; set; }

        public Team(string nm)
        {
            this.creator = nm;
            members = new List<string>();
        }
    }
}
