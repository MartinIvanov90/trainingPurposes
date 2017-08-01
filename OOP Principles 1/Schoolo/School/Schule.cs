using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolo.School
{
    class Schule
    {
        private List<Class> classes;

        public Schule()
        {
            this.classes = new List<Class>();
        }

        public void AddClass(string classId)
        {
            classes.Add(new Class(classId));
        }
        public void AddClass(Class classe)
        {
            classes.Add(classe);
        }

        public override string ToString()
        {
            string result = "School ";
            for(int i = 0; i< classes.Count; i++)
            {
                result += "\n" + classes[i].ToString();
            }
            return result;
        }
    }
}
