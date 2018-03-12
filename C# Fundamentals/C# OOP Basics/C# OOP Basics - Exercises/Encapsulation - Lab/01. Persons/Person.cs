namespace _01.Persons
{
    public class Person
    {
        private string fisrtName;
        private string lastName;
        private int age;


        public Person(string fisrtName, string lastName, int age)
        {
            this.fisrtName = fisrtName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get { return this.fisrtName; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public override string ToString()
        {
            return $"{this.fisrtName} {this.lastName} is a {this.age} years old";
        }
    }
}