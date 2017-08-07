using System;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;
using System.Linq;

namespace OlympicGames.Olympics.Models
{
    public class Boxer : Olympian, IBoxer
    {
        private BoxingCategory boxingCategory;
        private int wins;
        private int losses;

        public BoxingCategory Category
        {
            get
            {
                return this.boxingCategory;
            }
            private set
            {
                this.boxingCategory = value;
            }
        }
        public int Wins
        {
            get
            {
                return this.wins;
            }
            private set
            {
                //this.wins.ValidateIfNull();
                value.ValidateMinAndMaxNumber(0, 100, "Wins must be between 0 and 100!");
                this.wins = value;
            }
        }
        public int Losses
        {
            get
            {
                return this.losses;
            }
            private set
            {
                value.ValidateMinAndMaxNumber(0, 100, "Losses must be between 0 and 100!");
                this.losses = value;
            }
        }

        public Boxer(string firstName, string lastName, string country, string category, int wins = 0, int losses = 0)
            : base(firstName, lastName, country)
        {
            this.Wins = wins;
            this.Losses = losses;
            this.Category = ConvertStringToBoxingCategory(category);
        }

        private BoxingCategory ConvertStringToBoxingCategory(string boxingCategory)
        {
            BoxingCategory myCategory;
            if (Enum.TryParse(boxingCategory,true, out myCategory))
            {
                switch (myCategory)
                {
                    case BoxingCategory.Featherweight:
                        return BoxingCategory.Featherweight;
                        break;
                    case BoxingCategory.Flyweight:
                        return BoxingCategory.Flyweight;
                        break;
                    case BoxingCategory.Heavyweight:
                        return BoxingCategory.Heavyweight;
                        break;
                    case BoxingCategory.Lightweight:
                        return BoxingCategory.Lightweight;
                        break;
                    case BoxingCategory.Middleweight:
                        return BoxingCategory.Middleweight;
                        break;
                }
                
            }
            return BoxingCategory.Flyweight;
        }
        public override string ToString()
        {
            return $"BOXER: {base.FirstName} {base.LastName} from {base.Country}\n" +
                   $"Category: {this.Category.ToString()}\n" +
                   $"Wins: {this.Wins.ToString()}\n" +
                   $"Losses: {this.Losses.ToString()}";
        }
    }
}
