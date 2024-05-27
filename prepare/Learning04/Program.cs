using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Favio Callejas", "Multiplication and Division");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment b1 = new MathAssignment("Favio Callejas", "Addition and subtraction", "9.1", "9-21");
        Console.WriteLine(b1.GetSummary());
        Console.WriteLine(b1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment c1 = new WritingAssignment("Favio Callejas", "History of Bolivia", "Presidents of Bolivia");
        Console.WriteLine(c1.GetSummary());
        Console.WriteLine(c1.GetWritingInformation());
    }
}