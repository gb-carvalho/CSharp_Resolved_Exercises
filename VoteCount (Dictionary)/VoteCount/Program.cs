using System;
using System.IO;

namespace VoteCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This should be a user input, but i don`t wanna write this
            string root_directory = @"C:\Users\GB\Desktop\Projetos\C# (Udemy)\VoteCount (Dictionary)\";
            string file = root_directory + "votes.txt";

            Dictionary<string, int> votes = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine() ?? "";
                        string[] vote_infos = line.Split(',');
                        string name = vote_infos[0];
                        int vote_count = int.Parse(vote_infos[1]);

                        if (votes.ContainsKey(name))
                        {
                            votes[name] += vote_count;
                        }
                        else
                        {
                            votes[name] = vote_count;
                        }
                    }
                }

                foreach (KeyValuePair<string, int> vote in votes)
                {
                    Console.WriteLine(vote.Key + ": " + vote.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


        }
    }
}