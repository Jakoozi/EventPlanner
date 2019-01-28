using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner_New
{
    class BirthdayParty
    {
        private decimal costOfDecoration;
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        //private string cakeWriting;
        public string CakeWriting;
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
        public bool CakeWritingTooLong
        {
            get
            {
                if(CakeWriting.Length > MaxWritingLength())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return MaxWritingLength();
                }
                else { return CakeWriting.Length; }
            }
            set { }
        }
        private decimal CalculateCostOfDecorations()
        {
            if(FancyDecorations)
            {
                costOfDecoration = (15.00M * NumberOfPeople) + 50.00M;
            }
            else
            {
                costOfDecoration = (7.50M * NumberOfPeople) + 30.00M;
            }
            return costOfDecoration;
        }
        private int  CakeSize()
        {
            if(NumberOfPeople <= 4)
            {
                return 8;
            }
            else { return 16; }
        }
        public int MaxWritingLength()
        {
            if(CakeSize() == 8)
            {
                return 16;
            }
            else
            {
                return 40;
            }
        }
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if(CakeSize() == 8)
                {
                    cakeCost = 40.00M + ActualLength * .25M;
                }
                else
                {
                    cakeCost = 75.00M + ActualLength * .25M;
                }
                decimal finalCost;
                finalCost = totalCost + cakeCost;
                return finalCost;
            }
        }

    }
}
