using System;

namespace fall_2020_starter_code
{
    public class Original : Pizza
    {   //Concrete Component
        public Original()
        {
            Description = "Original";
        }
        public override double Cost()
        {
            double cost = 0.00;
            switch(Size)
            {
                case "Small":
                    cost += 5.00;
                    break;
                case "Medium":
                    cost += 7.50;
                    break;
                case "Large":
                    cost += 10.00;
                    break;
            }
            return cost;
        }
    }
}