namespace _10.Car_Salesman
{
    public class Engine
    {
        public string engineModel;
        public string enginePower;
        public int engineDisplacement;
        public string engineEfficiency;

        public Engine(string engineModel, string enginePower)
        {
            this.engineModel = engineModel;
            this.enginePower = enginePower;
            this.engineDisplacement = 0;
            this.engineEfficiency = "n/a";
        }

        public Engine(string engineModel, string enginePower, int engineDisplacement)
            : this(engineModel, enginePower)
        {
            this.engineDisplacement = engineDisplacement;
        }

        public Engine(string engineModel, string enginePower, string engineEfficiency)
            : this(engineModel, enginePower)
        {
            this.engineEfficiency = engineEfficiency;
        }

        public Engine(string engineModel, string enginePower, int engineDisplacement, string engineEfficiency)
            : this(engineModel, enginePower)
        {
            this.engineDisplacement = engineDisplacement;
            this.engineEfficiency = engineEfficiency;
        }
    }
}