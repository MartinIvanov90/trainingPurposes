using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics.Models
{
    public abstract class Olympian : IOlympian
    {
        private string firstName;
        private string lastName;
        private string country;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            protected set
            {
                value.ValidateIfNull("First name cannot be null!");
                value.ValidateMinAndMaxLength(2, 20, "First name must be between 2 and 20 characters long!");
                this.firstName = value;

            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            protected set
            {
                value.ValidateIfNull("Last name cannot be null!");
                value.ValidateMinAndMaxLength(2, 20, "Last name must be between 2 and 20 characters long!");
                this.lastName = value;

            }
        }
        public string Country
        {
            get
            {
                return this.country;
            }
            protected set
            {
                value.ValidateIfNull("Country cannot be null!");
                value.ValidateMinAndMaxLength(3, 25, "Country must be between 3 and 25 characters long!");
                this.country = value;

            }
        }

        public Olympian(string firstName, string lastName, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
        }
    }
}
