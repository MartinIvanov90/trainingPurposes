using System;
using System.Collections.Generic;
using Academy.Models.Contracts;
using System.Linq;
using Academy.Models.Utils.Tools;

namespace Academy.Models
{
    public class Trainer : ITrainer
    {
        private IList<string> technologies;
        private string username;

        public IList<string> Technologies
        {
            get
            {
                return this.technologies;
            }
            set
            {
                this.technologies = value;
            }
        }
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                Validator.ValidateMinAndMaxLength(value, 3, 16, "User's username should be between 3 and 16 symbols long!");
                this.username = value;
            }
        }

        public Trainer(string username, string technologies)
        {
            this.Username = username;
            TechnologiesToList(technologies);
        }

        private void TechnologiesToList(string inputTechnologies)
        {
            this.Technologies = inputTechnologies.Split(',').ToList();
        }
        public override string ToString()
        {
            string technologiesSequence = String.Join("; ",Technologies);
            var result =   $"* Trainer:\n" +
                           $" - Username: {this.Username}\n" +
                           $" - Technologies: {technologiesSequence}";

            return result;
        }
    }
}
