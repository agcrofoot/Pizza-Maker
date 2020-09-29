using System;

namespace fall_2020_starter_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = new StuffedCrust(){Size = "Large"};

            myPizza = new Cheese(myPizza);
            myPizza = new Cheese(myPizza);
            myPizza = new Pepperoni(myPizza);
            myPizza = new Sausage(myPizza);

            Console.WriteLine(myPizza.GetDescription() + " $" + myPizza.Cost());
        }
    }
}
