using System;
using System.Collections.Generic;
using Academy.Models.Contracts;
using Academy.Models.Utils.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Tools;
using System.Text.RegularExpressions;
using System.Linq;

namespace Academy.Models
{
    public class Student : IStudent
    {
        private Track track;
        private IList<ICourseResult> courseResults;
        private string username;

        public Track Track
        {
            get
            {
                return this.track;
            }
            set
            {
                this.track = value;
            }
        }
        public IList<ICourseResult> CourseResults
        {
            get
            {
                return this.courseResults;
            }
            set
            {
                this.courseResults = value;
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

        public Student(string username, string track)
        {
            this.Username = username;
            StringTrackToEnum(track);
            this.CourseResults = new List<ICourseResult>();
        }

        private void StringTrackToEnum(string inputTrack)
        {
            if(!Enum.TryParse(inputTrack, out track))
            {
                throw new ArgumentException("The provided track is not valid!");
            }
        }
        public override string ToString()
        {
            string courseSequence = this.courseResults.Count == 0 ?
                                    "* User has no course results!" : String.Join("\n", this.courseResults);
            courseSequence = String.Join("\n", courseSequence.Split('\n').Select(x => "  " + x));
            var result =   $"* Student:\n" +
                           $" - Username: {this.Username}\n" +
                           $" - Track: {this.Track}\n" +
                           $" - Course results:\n"+
                           $"{courseSequence}";

            return result;
        }
    }
}
