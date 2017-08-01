using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolo.School
{
    class Student : IHuman
    {
        private readonly string name;
        private readonly Class classId; 

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public Student(string name, Class classId)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException($"You must enter a name of the discipline");
            }
            this.name = name;
            this.classId = classId;
        }

        public string GetName()
        {
            return $"Student name: {this.Name}";
        }
        public override string ToString()
        {
            string result = GetName() + "student of" + classId.UniqueTextIdentifier;
            
            for (int i = 0; i < classId.Teachers.Count; i++)
            {
                result += "\n" + classId.Teachers[i].ToString();
            }
            return result; //TODO
        }
    }
}
