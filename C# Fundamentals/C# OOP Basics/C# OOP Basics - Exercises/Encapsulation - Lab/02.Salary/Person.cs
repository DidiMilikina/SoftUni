namespace _02.Salary
{
    public class Person
    {
        private string fisrtName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string fisrtName, string lastName, int age, double salary)
        {
            this.fisrtName = fisrtName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get { return this.fisrtName; }
        }

        public int Age
        {
            get { return this.age; }
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