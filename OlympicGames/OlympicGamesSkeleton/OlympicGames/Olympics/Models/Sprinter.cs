using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics.Models
{
    public class Sprinter : Olympian, ISprinter
    {
        private IDictionary<string, double> personalRecords;

        public IDictionary<string, double> PersonalRecords
        {
            get
            {
                return this.personalRecords;
            }
            private set
            {
                this.personalRecords = value;
            }
        }
 
        public Sprinter(string firstName, string lastName, string country, IDictionary<string, double> records)
            : base(firstName, lastName, country)
        {
            this.PersonalRecords = records;
        }

        private string RecordsPrint()
        {
            string result = String.Empty;
            foreach(var item in PersonalRecords.Keys)
            {
                double time;
                PersonalRecords.TryGetValue(item, out time);
                result += "\n" + item + "m: " + time + "s";
            }

            return result;
        }
        public override string ToString()
        {
            string records = RecordsPrint();
            return $"SPRINTER: {base.FirstName} {base.LastName} from {base.Country}\n" +
                   (records == string.Empty ? $"NO PERSONAL RECORDS SET" : GlobalConstants.PersonalRecords +
                   RecordsPrint());
        }
    }
}
