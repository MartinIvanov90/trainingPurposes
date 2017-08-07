using System;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Tools;

namespace Academy.Models.Utils.Abstracts
{
    public abstract class LectureResources : ILectureResource
    {
        private string name;
        private string url;
        protected ResourceType type;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.ValidateMinAndMaxLength(value,3,15, "Resource name should be between 3 and 15 symbols long!");
                this.name = value;
            }
        }
        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                Validator.ValidateMinAndMaxLength(value,5,150, "Resource url should be between 5 and 150 symbols long!");
                this.url = value;
            }
        }
        public ResourceType Type
        {
            get
            {
                return this.type;
            }
        }

        public LectureResources(string name, string url)
        {
            this.Name = name;
            this.url = url;
        }

        public override string ToString()
        {
            var result =   $"* Resource:\n" +
                           $" - Name: {this.Name}\n" +
                           $" - Url: {this.Url}\n" +
                           $" - Type: {this.Type}\n";

            return result;
        }
    }
}
