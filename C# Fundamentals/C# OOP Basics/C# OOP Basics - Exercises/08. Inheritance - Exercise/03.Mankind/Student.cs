using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : Human
{
    private string studentFacultyNumber;

    public Student(string firstName, string lastName, string studentFacultyNumber)
        :base(firstName, lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.StudentFacultyNumber = studentFacultyNumber;
    }

    public override string FirstName
    {
        get
        {
            return base.FirstName;
        }
        protected set
        {
            if (value.Length < 4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            base.FirstName = value;
        }
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

    public string StudentFacultyNumber
    {
        get
        {
            return this.studentFacultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10 || !IsValidFacultyNumber(value))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.studentFacultyNumber = value;
        }
    }

    private bool IsValidFacultyNumber(string value)
    {
        bool isValidFacultyNumber = true;
        foreach (char ch in value)
        {
            if (!char.IsLetterOrDigit(ch))
            {
                isValidFacultyNumber = false;
            }
        }
        return isValidFacultyNumber;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.LastName)
                .Append(Environment.NewLine)
                .Append("Faculty number: ").Append(this.studentFacultyNumber);

        return sb.ToString();
    }
}

