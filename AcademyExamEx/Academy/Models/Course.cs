using System;
using System.Collections.Generic;
using Academy.Models.Contracts;
using Academy.Models.Utils.Tools;
using System.Text.RegularExpressions;
using System.Linq;

namespace Academy.Models
{
    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        private DateTime startingDate;
        private DateTime endingDate;
        private IList<IStudent> onsiteStudents;
        private IList<IStudent> onlineStudents;
        private IList<ILecture> lectures;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.ValidateMinAndMaxLength(value, 3, 45, "The name of the course must be between 3 and 45 symbols!");
                this.name = value;
            }
        }
        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }
            set
            {
                Validator.ValidateMinAndMaxNumber(value, 1, 7, "The number of lectures per week must be between 1 and 7!");
                this.lecturesPerWeek = value;
            }
        }
        public DateTime StartingDate
        {
            get
            {
                return this.startingDate;
            }
            set
            {
                this.startingDate = value;
            }
        }
        public DateTime EndingDate
        {
            get
            {
                return this.endingDate;
            }
            set
            {
                this.endingDate = value;
            }
        }
        public IList<IStudent> OnsiteStudents
        {
            get
            {
                return this.onsiteStudents;
            }
        }
        public IList<IStudent> OnlineStudents
        {
            get
            {
                return this.onlineStudents;
            }
        }
        public IList<ILecture> Lectures
        {
            get
            {
                return this.lectures;
            }
        }

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.StartingDate = DateTime.Parse(startingDate);
            this.EndingDate = CalculateEndingDate();
            this.onsiteStudents = new List<IStudent>();
            this.onlineStudents = new List<IStudent>();
            this.lectures = new List<ILecture>();
        }

        private DateTime CalculateEndingDate()
        {
            return StartingDate.AddDays(30);
        }
        //TODO: Redo once Lectures class is done!
        public override string ToString()
        {
            var lecturesResult = "";
            foreach(ILecture lecture in Lectures)
            {
                lecturesResult += lecture.ToString();
            }

            if (String.IsNullOrEmpty(lecturesResult))
            {
                lecturesResult = $"* There are no lectures in this course!";
            }
            lecturesResult = String.Join("\n", lecturesResult.Split('\n').Select(x => "  " + x));
            var result = $"* Course:\n" +
                    $" - Name: {this.Name}\n" +
                    $" - Lectures per week: {this.LecturesPerWeek.ToString()}\n" +
                    $" - Starting date: {this.StartingDate.ToString()}\n" +
                    $" - Ending date: {this.EndingDate.ToString()}\n" +
                    $" - Onsite students: {this.OnsiteStudents.Count.ToString()}\n" +
                    $" - Online students: {this.onlineStudents.Count.ToString()}\n" +
                    $" - Lectures:\n" +
                    lecturesResult;
                    
            return result;
        }
    }
}
