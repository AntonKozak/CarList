namespace Cars;

  public class Car 
    {
        public string Make {get; set;}
        public string Model {get; set;}

        public double Price {get; set;}
    

    public Car ()
    {
        Make = "";
        Model = "";
        Price = 0.00;
    }

    public Car (string a, string b, double c)
    {
        Make = a;
        Model = b;
        Price = c;
    }

    override public string ToString()
    {
        return "Make:" + Make + " Model:"+ Model + " Price sek:" + Price;
    }
}