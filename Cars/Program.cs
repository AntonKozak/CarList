namespace Cars;

class Program
{
    static void Main(string[] args)
    {
        Store s = new Store();
        
        Console.WriteLine("Hello, World! Make your own car !");
        int action = chooseAction();

        while (action != 0)
        {
            Console.WriteLine("Your chose " + action);

            switch(action)
            {
                // Add to inventory
                case 1:

                Console.WriteLine("You choose to add a new car to the inventory");

                string carMake = "";
                string carModel = "";
                double carPrice = 0;

                Console.WriteLine("what is the car make ? ford, fiat , volvo");
                carMake = Console.ReadLine();

                Console.WriteLine("What is the car model? corvette, dodge, xc60, etc");
                 carModel = Console.ReadLine();

                Console.WriteLine("What is the car price?");
                carPrice = int.Parse(Console.ReadLine());

                var newCar = new Car(carMake, carModel, carPrice);

                s.CarList.Add(newCar);

                printInventory(s);
                break;

                case 2:

                Console.WriteLine("You chooose to add a car to your shopping cart");
                printInventory(s);
                Console.WriteLine("Which car woud you like to buy? (number)");
                int carChosen = int.Parse(Console.ReadLine());

                s.ShoppingList.Add(s.CarList[carChosen]);

                printShoppingCart(s);
                break;

                case 3:
                    printShoppingCart(s);
                    Console.WriteLine("the total cost your items is: " + s.Checkout());
                break;

                default:
                break;

            }

            action = chooseAction();
        }
    }

    private static void printShoppingCart(Store s)
    {
        Console.WriteLine("Cars you have choose:");
        for(int i = 0; i<s.ShoppingList.Count; i++)
        {
            Console.WriteLine("Car #:" + i +" "+ s.ShoppingList[i]);
        }
    }

    private static void printInventory(Store s)
    {
        for(int i = 0; i<s.CarList.Count; i++)
        {
            Console.WriteLine("Car #:" + i +" "+ s.CarList[i]);
        }
    }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add car to car (3) checkout");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
}





        // Car c = new Car("Ford", "Dodge", 7603);
        // Car d = new Car("Fiat", "Doblo", 8900.34);
        // Console.WriteLine( c.Make +" "+ c.Model +" "+ c.Price  );

        // Store s = new Store();

        // s.ShoppingList.Add (c);
        // s.ShoppingList.Add (d);

        // double total = s.Checkout();
        // Console.WriteLine("Store value is " + total);

        // Console.ReadLine();