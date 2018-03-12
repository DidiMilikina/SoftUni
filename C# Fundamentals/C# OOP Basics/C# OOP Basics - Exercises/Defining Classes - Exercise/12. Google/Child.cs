namespace _12.Google
{
    public class Child
    {
        public string name;
        public string birthday;

        public Child(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public override string ToString()
        {
            return this.name + " " + this.birthday;
        }
    }
}