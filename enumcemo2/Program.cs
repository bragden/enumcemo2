namespace enumcemo2
{
    enum Beverage
    {
        Coffee,
        Tea,
        Water,
        Soda,
        Juice
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the awesome vending machine");
            Console.WriteLine("Which beverage do you prefer? (Coffee, Tea, Water, Soda, Juice)");
            String userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "coffee":
                    respond (Beverage.Coffee);
                    break;
                case "tea":
                    respond (Beverage.Tea);
                    break;
                case "water":
                    respond (Beverage.Water);
                    break;
                case "soda":
                    respond (Beverage.Soda);
                    break;
                case "juice":
                    respond (Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;


            }
        }
        static void respond(Beverage drink) 
        { 
            switch (drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine("You ordered Coffee");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("You ordered Tea");
                    break;
                case Beverage.Water:
                    Console.WriteLine("You ordered Water");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("You ordered Soda");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("You ordered Juice");
                    break;

            }
        }
    }
}