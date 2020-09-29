using System;

namespace fall_2020_starter_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = new DeepDish(){Size = "Large"};

            myPizza = new Cheese(myPizza);
            myPizza = new Cheese(myPizza);

            Console.WriteLine(myPizza.GetDescription() + " $" + myPizza.Cost());


            Pizza yourPizza = new Original(){Size = "Small"};

            yourPizza = new Cheese(yourPizza);
            yourPizza = new Pepperoni(yourPizza);
            yourPizza = new Sausage(yourPizza);

            Console.WriteLine(yourPizza.GetDescription() + " $" + yourPizza.Cost());

        }
    }
}
