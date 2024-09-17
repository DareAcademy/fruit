using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata;

namespace FruitManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FruitsManager manager = new FruitsManager();

            while (true)
            {
                
                Console.WriteLine("Fruit Manager");
                Console.WriteLine("1. Add Fruit");
                Console.WriteLine("2. View All Fruits");
                Console.WriteLine("3. Remove Fruit");
                Console.WriteLine("4. Exit");

                Console.Write("Please select an option (1-4) ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (option == Convert.ToInt32( MenuItem.add))
                {
                    Console.Write("Please enter the name of fruit for adding ");
                    string fruitName = Console.ReadLine();

                    
                    manager.Addfruit(fruitName);
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (option == Convert.ToInt32(MenuItem.viewAll))
                {

                    manager.ViewAllFruit();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == Convert.ToInt32(MenuItem.remove))
                {
                    Console.Write("Please enter the name of fruit for remove ");
                    string fruitName = Console.ReadLine();
                    manager.RemoveFruit(fruitName);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == Convert.ToInt32(MenuItem.exit))
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
        }
    }
}