using System;

namespace _03.Validation
{
    public class Person
    {
        private string fisrtName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string fisrtName, string lastName, int age, double salary)
        {
            this.FirstName = fisrtName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get { return this.fisrtName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }

                this.fisrtName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }

                this.age = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }

                this.salary = value;
            }
        }

        public void IncreaseSalary(double bonus)
        {
            if (this.Age < 30)
            {
                this.salary += this.salary * bonus / 200;
            }
            else
            {
                this.salary += this.salary * bonus / 100;
            }
        }

        public override string ToString()
        {
            return $"{this.fisrtName} {this.lastName} get {this.salary:f2} leva";
        }
    }
}