using System;

namespace fall_2020_starter_code
{
    public class StuffedCrust : Pizza
    {
        public StuffedCrust()
        {
            Description = "Stuffed Crust";
        }
        public override double Cost()
        {
            double cost = 0;
            switch(Size)
            {
                case "Small":
                    cost += 10.00;
                    break;
                case "Medium":
                    cost += 12.00;
                    break;
                case "Large":
                    cost += 14.00;
                    break;
            }
            return cost;
        }
    }
}