using System;

namespace OnlineCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] courses = { 'A', 'B', 'C' };
            HashSet<int> student_set = new HashSet<int>();

            foreach (char course in courses)
            {
                Console.Write($"How many students for course {course}? ");
                int.TryParse(Console.ReadLine(), out int student_count);


                for (int i = 0; i < student_count; i++)
                {
                    int.TryParse(Console.ReadLine(), out int student_code);
                    student_set.Add(student_code);
                }
            }

            Console.WriteLine($"Total students: {student_set.Count}");
        }
    }
}