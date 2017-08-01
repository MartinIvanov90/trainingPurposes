using System;
using System.Collections.Generic;

namespace Schoolo.School
{
    class Teacher : IHuman
    {
        private readonly string name;
        private List<Discipline> disciplines;

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public Teacher(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException($"name cannot be empty");
            }
            this.name = name;
            this.disciplines = new List<Discipline>();
        }

        public void AddDiscipline(string name, int lecNum, int exNum)
        {
            disciplines.Add(new Discipline(name, lecNum, exNum));
        }
        public string GetName()
        {
            return $"Teacher name: {this.Name}";
        }
        public override string ToString()
        {
            string result = GetName();
            for (int i = 0; i < disciplines.Count; i++)
            {
                result += "\n" + disciplines[i].ToString();
            }
            return result; //TODO
        }
    }
}
