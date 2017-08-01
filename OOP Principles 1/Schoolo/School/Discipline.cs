using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolo.School
{
    class Discipline
    {
        private readonly string name;
        private readonly int numberOfLectures;
        private readonly int numberOfExercises;

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
        }
        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
        }


        public Discipline(string name, int lecNum, int exNum)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException($"You must enter a name of the discipline");
            }
            this.name = name;
            if (lecNum<0)
            {
                throw new ArgumentException($"Number of lectures can't be negative number");
            }
            this.numberOfLectures = lecNum;
            if (exNum < 0)
            {
                throw new ArgumentException($"Number of exercises can't be negative number");
            }
            this.numberOfExercises = exNum;

        }
        public override string ToString()
        {
            return $"{this.Name} -  Lectures: {this.NumberOfLectures}; Exercises: {this.NumberOfExercises};";
        }
    }
}
