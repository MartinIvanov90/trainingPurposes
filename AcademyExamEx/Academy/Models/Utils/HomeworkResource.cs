using System;
using Academy.Models.Enums;
using Academy.Models.Utils.Abstracts;

namespace Academy.Models.Utils
{
    public class HomeworkResource : LectureResources
    {
        private DateTime dueDate;

        public DateTime DueDate
        {
            get
            {
                return this.dueDate;
            }
            private set
            {
                this.dueDate = value;
            }
        }

        public HomeworkResource(string name, string url, DateTime dueDate) : base(name, url)
        {
            base.type = ResourceType.Homework;
            this.DueDate = dueDate.AddDays(7);
        }

        public override string ToString()
        {
            return base.ToString()+ $"\n - Due date: {this.DueDate.ToString()}\n"; ;
        }
    }
}