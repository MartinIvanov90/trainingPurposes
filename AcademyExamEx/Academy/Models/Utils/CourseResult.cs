using System;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;
using Academy.Models.Utils.Tools;

namespace Academy.Models.Utils
{
    public class CourseResult : ICourseResult
    {
        private ICourse course;
        private float examPoints;
        private float coursePoints;
        private Grade grade;

        public ICourse Course
        {
            get
            {
                return this.course;
            }
        }
        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }
        }
        public float CoursePoints
        {
            get
            {
                return this.coursePoints;
            }
        }
        public Grade Grade
        {
            get
            {
                return this.grade;
            }
        }

        public CourseResult(ICourse course, string examPoints, string coursePoints )
        {
            Validator.ValidateMinAndMaxLength(examPoints, 0, 100, "Course result's exam points should be between 0 and 100!");
            Validator.ValidateMinAndMaxLength(coursePoints, 0, 125, "Course result's course points should be between 0 and 125!");
            this.course = course;
            this.examPoints = float.Parse(examPoints);
            this.coursePoints = float.Parse(coursePoints);
            CalculateGrade();
        }

        private void CalculateGrade()
        {
            if (this.ExamPoints >= 65 || this.CoursePoints >= 75)
            {
                this.grade = Grade.Excellent;
            }
            else if ((this.ExamPoints < 65 && this.ExamPoints >= 30) || (this.CoursePoints < 75 && this.CoursePoints >= 45))
            {
                this.grade = Grade.Passed;
            }
            else
            {
                this.grade = Grade.Failed;
            }
        }
        public override string ToString()
        {
            return $"* {this.Course.Name}: Points - {this.CoursePoints}, Grade - {this.grade}";
        }
    }
}
