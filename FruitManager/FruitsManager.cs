using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitManager
{
    internal class FruitsManager
    {
        //List<string> fruits = new List<string>();
        List<string> fruits;
        public FruitsManager()
        {
            fruits = new List<string>();
        }

        //Addfruit
        public void Addfruit(string fruitN)
        {
            
            fruits.Add(fruitN);

            Console.WriteLine("fruit added successfuly");
        }
        //ViewAllFruit

        public void ViewAllFruit()
        {
            if (fruits.Count > 0)
            {
                Console.WriteLine("fruit list contains");
                foreach (string f in fruits)
                {
                    Console.WriteLine(f);
                }
            }
            else
            {
                Console.WriteLine("fruit list empty");
            }

        }
        //RemoveFruit
        public void RemoveFruit(string name)
        {
            if (fruits.Count > 0)
            {
                fruits.Remove(name);

                Console.WriteLine("fruit removed successfuly");
            }
            else
            {
                Console.WriteLine("fruit list empty");
            }
        }

    }
}
