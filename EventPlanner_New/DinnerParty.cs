using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner_New
{
    class DinnerParty
    {
        private const int costOfFoodPerPerson = 25;
        private decimal costOfDecoration;
        private decimal costOfBeveragesPerPerson;
        public int NumberOfPeople {
            get;
            set;
        }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
            {
                costOfDecoration = ( NumberOfPeople * 15.00M) + 50.00M;
                return costOfDecoration;
            }
            else
            {
                costOfDecoration = (NumberOfPeople * 7.50M) + 30.00M;
                return costOfDecoration;
            }
        }
        private decimal CalculateCostOfBeveragePerPerson()
        {
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
                return costOfBeveragesPerPerson;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
                return costOfBeveragesPerPerson;
            }
        }
        public decimal finalcost;
        public decimal Cost
        {
            get {
                decimal totalCost = CalculateCostOfDecorations();
               totalCost += ((CalculateCostOfBeveragePerPerson() + costOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
              if(NumberOfPeople > 12)
                {
                    finalcost = totalCost + 100.00M;
                }
                return finalcost;
            }
        }
    }
}
