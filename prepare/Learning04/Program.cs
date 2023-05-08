using System;

class Program
{
    static void Main(string[] args)
    {   
        // assignment class test
        Assignment assignment = new Assignment("Kali Walker", "Career Development");
        Console.WriteLine(assignment.GetSummary());

        // MathAssignment class test
        MathAssignment mathAssignment = new MathAssignment("Jason Rackham", "Fractions", "4.3", "1-17");
        Console.WriteLine();
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Scott Boyer", "Podcasting", "How To Make a Podcast");
        Console.WriteLine();
        Console.WriteLine(writingAssignment.GetWritingAssignment());
    }
}
