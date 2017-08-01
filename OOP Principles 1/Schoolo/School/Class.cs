using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolo.School
{
    class Class
    {
        private readonly string uniqueTextIdentifier;
        private List<Teacher> teachers;

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
        }
        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }
        }
        //TODO: set of Teacher class

        public Class(string uniqueTextIdentifier)
        {
            if (String.IsNullOrWhiteSpace(uniqueTextIdentifier))
            {
                throw new ArgumentNullException($"You must enter the unique text identifier of the class ");
            }
            this.uniqueTextIdentifier = uniqueTextIdentifier;
            this.teachers = new List<Teacher>();
        }

        public void AddTeacher(string name)
        {
            teachers.Add(new Teacher(name));
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public string GetClassId()
        {
            return $"ClassID: {this.UniqueTextIdentifier}";
        }
        public override string ToString()
        {
            string result = GetClassId();
            for (int i = 0; i < teachers.Count; i++)
            {
                result += "\n" + teachers[i].GetName();
            }
            return result; //TODO
        }
    }
}
