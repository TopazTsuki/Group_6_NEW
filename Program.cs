namespace ConsoleApp1
{
      internal class Program
    {
    static void Main(string[] args)
        {
            // Have customer input item specific details and store them as variables. 
            Console.WriteLine("Hello, please answer the following prompts to place your order.");
            Console.WriteLine("Please enter your desired item: ");
            string JewlType = Console.ReadLine();
            Console.WriteLine("Please enter a description of your desired item: ");
            string Description = Console.ReadLine();
            
            // Write back customer inputs. 
            Console.WriteLine("You have requested: ");
            Console.WriteLine($"Item: {JewlType}");
            Console.WriteLine($"Description: {Description}");
            

            // Take down customer information
            Console.WriteLine("Hello, please answer the following prompts to create your account.");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Please enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();

            // Have user login to confirm setup 


       
        }
    }
}