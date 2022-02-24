namespace Zad2
{
    public class Employ
    {
        public string FirstName { get; set; } = "Undefined";
        public string Vacetion { get; set; } = "Undefined";
        public double Oklad { get; set; } = 0;

        public Employ()
        {
        }

        public Employ(string firstName, string vacetion, double oklad)
        {
            FirstName = firstName;
            Vacetion = vacetion;
            Oklad = oklad;
        }

        public void AddOklad()
        {
            Oklad = 1.15 * Oklad;
        }

        public void ToIngener()
        {
            if (FirstName.StartsWith("Иван")) Vacetion = "Инженер";
        }

        public string Print()
        {
            return $"Фамилия:{FirstName}, должность:{Vacetion}," +
                   $" оклад:{Oklad:F2}";
        }
    }
}