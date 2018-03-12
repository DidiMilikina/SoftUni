namespace _12.Google
{
    public class Company
    {
        public string name;
        public string department;
        public decimal salary;

        public Company(string name, string department, decimal salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{this.name} {this.department} {this.salary:f2}";
        }
    }
}