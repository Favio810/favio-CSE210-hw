using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment aa = new Assignment("Favio Callejas", "Multiplication and Division");
        Console.WriteLine(aa.GetSummary());
        Console.WriteLine();

        MathAssignment bb = new MathAssignment("Favio Callejas", "Addition and subtraction", "9.1", "9-21");
        Console.WriteLine(bb.GetSummary());
        Console.WriteLine(bb.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment cc = new WritingAssignment("Favio Callejas", "History of Bolivia", "Presidents of Bolivia");
        Console.WriteLine(cc.GetSummary());
        Console.WriteLine(cc.GetWritingInformation());
    }
}