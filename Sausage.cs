using System;

namespace fall_2020_starter_code
{
    public class Sausage : PizzaDecorator
    {
        Pizza pizza;

        public Sausage(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string GetDescription()
        {
            return pizza.GetDescription() + " , add sausage";
        }

        public override string GetSize()
        {
            return this.pizza.GetSize();
        }

        public override void SetSize(string size)
        {
            this.pizza.SetSize(size);
        }

        public override double Cost()
        {
            double cost = pizza.Cost();

            switch(pizza.GetSize())
            {
                case "Small":
                    cost += 1.00;
                    break;
                case "Medium":
                    cost += 1.25;
                    break;
                case "Large":
                    cost += 1.75;
                    break;
            }
            return cost;
        }
    }
}