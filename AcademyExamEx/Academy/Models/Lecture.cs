using Academy.Models.Contracts;
using Academy.Models.Utils.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Lecture : ILecture
    {
        private string name;
        private DateTime date;
        public ITrainer trainer;
        private IList<ILectureResource> resources;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.ValidateMinAndMaxLength(value,5,30,"Lecture's name should be between 5 and 30 symbols long!");
                this.name = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public ITrainer Trainer
        {
            get
            {
                return this.trainer;
            }
            set
            {
                this.trainer = value;
            }
        }
        public IList<ILectureResource> Resources
        {
            get
            {
                return this.resources;
            }
        }

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.Trainer = trainer;
            this.resources = new List<ILectureResource>();
        }

        public override string ToString()
        {   
            var lecturesResourcesResult = this.Resources.Count == 0 ?
                                    "* There are no resources in this lecture.\n" : String.Join("\n", this.Resources)+"\n";
            lecturesResourcesResult = String.Join("\n", lecturesResourcesResult.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => "  " + x));
            var result   =  $"* Lecture:\n" +
                            $" - Name: {this.Name}\n" +
                            $" - Date: {this.Date.ToString()}\n" +
                            $" - Trainer username: {this.Trainer.Username}\n" +
                            $" - Resources:\n" +
                            lecturesResourcesResult+"\n";

            return result;
        }
    }
}
