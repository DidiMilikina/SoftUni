using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        string firstName = tokens[0];
        string lastName = tokens[1];
        string studentFacultyNumber = tokens[2];

        Student student;
        try
        {
            student = new Student(firstName, lastName, studentFacultyNumber);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        input = Console.ReadLine();
        tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
        firstName = tokens[0];
        lastName = tokens[1];
        double workerWeekSalаry = double.Parse(tokens[2]);
        double workingHoursPerDay = double.Parse(tokens[3]);

        Worker worker;
        try
        {
            worker = new Worker(firstName, lastName, workerWeekSalаry, workingHoursPerDay);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        Console.WriteLine(student);
        Console.WriteLine();
        Console.WriteLine(worker);
        Console.WriteLine();
    }
}
