namespace ConsoleApp1
{
      internal class Program
    {
    static void Main(string[] args)
        {
            // Have customer input item specific details and store them as variables. 
            Console.WriteLine("Hello, please answer the following prompts to place your order.");
            Console.WriteLine("Please enter your desired item: ");
            string item = console.ReadLine();
            Console.WriteLine("Please enter your desired material: ");
            string material = console.ReadLine();
            Console.WriteLine("Please enter your desired color: ");
            string color = console.readline();
            Console.WriteLine("Please enter your desired quantity: ");
            double quantity = console.readline();
            Console.WriteLine("Please enter your desired size (S,M,L): ");
            char size = console.readline();

            // Write back customer inputs. 
            Console.WriteLine("You have requested: ");
            Console.WriteLine($"Item: {item}");
            Console.WriteLine($"Material: {material}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Size: {size}");

            // Take down customer information
            Console.WriteLine("Hello, please answer the following prompts to create your account.");
            Console.WriteLine("Please enter your name: ");
            string name = console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            string address = console.ReadLine();
            Console.WriteLine("Please enter your username: ");
            string username = console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string password = console.readline();

            // Have user login to confirm setup 




            Material m = new Material("beads", 1, "blue", "small", 30);
            Console.WriteLine(m.type);
        }
    }
}