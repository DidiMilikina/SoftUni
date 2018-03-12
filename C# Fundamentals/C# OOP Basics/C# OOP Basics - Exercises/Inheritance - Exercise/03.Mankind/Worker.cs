using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Worker : Human
{
    private double workerWeekSalаry;
    private double workingHoursPerDay;

    public Worker(string firstName, string lastName, double workerWeekSalаry, double workingHoursPerDay)
        :base(firstName, lastName)
    {
        this.LastName = lastName;
        this.WorkerWeekSalаry = workerWeekSalаry;
        this.WorkingHoursPerDay = workingHoursPerDay;
    }

    public override string LastName
    {
        get
        {
            return base.LastName;
        }
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            base.LastName = value;
        }
    }

    public double WorkerWeekSalаry
    {
        get
        {
            return this.workerWeekSalаry;
        }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.workerWeekSalаry = value;
        }
    }

    public double WorkingHoursPerDay
    {
        get
        {
            return this.workingHoursPerDay;
        }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workingHoursPerDay = value;
        }
    }

    private double GetSalaryPerHour()
    {
        return this.WorkerWeekSalаry /(this.workingHoursPerDay * 5);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.LastName)
                .Append(Environment.NewLine)
                .Append(String.Format("Week Salary: {0:F2}", this.WorkerWeekSalаry))
                .Append(Environment.NewLine)
                .Append(String.Format("Hours per day: {0:F2}", this.WorkingHoursPerDay))
                .Append(Environment.NewLine)
                .Append(String.Format("Salary per hour: {0:F2}", this.GetSalaryPerHour()));

        return sb.ToString();
    }
}

