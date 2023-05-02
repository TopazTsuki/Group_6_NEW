namespace ConsoleApp1
{
      internal class Program
    {
    static void Main(string[] args)
        {
            Material m = new Material("beads", 1, "blue", "small", 30);
            Console.WriteLine(m.type);
        }
    }
}