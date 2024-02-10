namespace OOP1lb
{
    public class Zheck
    {
        string Region;
        int Number;
        string Name;
        double NumberHabitians;
        double NumberPayments;
        double NumberOfBuildings;
        string ContactEmail;
        float ServiceArea;
        public static int counter = 0;

        public string Region1 { get => Region; set => Region = value; }
        public int Number1 { get => Number; set => Number = value; }
        public string Name1 { get => Name; set => Name = value; }
        public double NumberHabitians1 { get => NumberHabitians; set => NumberHabitians = value; }
        public double NumberPayments1 { get => NumberPayments; set => NumberPayments = value; }
        public double NumberOfBuildings1 { get => NumberOfBuildings; set => NumberOfBuildings = value; }
        public string ContactEmail1 { get => ContactEmail; set => ContactEmail = value; }
        public float ServiceArea1 { get => ServiceArea; set => ServiceArea = value; }

        public Zheck() {
            counter++;
            this.Region = "";
            this.Number = counter;
            this.NumberHabitians = 0;
            this.NumberPayments = 0;
            this.NumberOfBuildings = 0;
            this.ContactEmail = "";
            this.ServiceArea = 0;
            this.Name = ""; 
        }

      public Zheck(string region, string name, double numberHabitians, double numberPayments, double numberOfBuildings,  string contactEmail, float serviceArea)
        {   
            counter++;
            this.Region = region;
            this.Number = counter;
            this.NumberHabitians = numberHabitians;
            this.NumberPayments = numberPayments;
            this.NumberOfBuildings = numberOfBuildings;
            this.ContactEmail = contactEmail;
            this.ServiceArea = serviceArea;
            this.Name = name;   
        }

        public Zheck(string region, string name)
        {
            counter++;
            this.Region = region;
            this.Number = counter;
            this.NumberHabitians = 0;
            this.NumberPayments = 0;
            this.NumberOfBuildings = 0;
            this.ContactEmail = "";
            this.ServiceArea = 0;
            this.Name = name;
        }


       public string GetNumberInHex()
        {
            return Convert.ToString(Number1, 16);
        }

        public override string ToString()
        {
            return Number + "\n" + Region+"\n"+ Name+"\n"+
                 NumberHabitians + "\n" + NumberPayments + "\n" + NumberOfBuildings + "\n" + ContactEmail + "\n" + ServiceArea;
        }
    }
}
