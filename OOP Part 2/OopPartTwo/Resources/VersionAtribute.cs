using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPartTwo.Resources
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method , AllowMultiple = true)]
    class VersionAttribute : Attribute
    {
        public string versionNumber { get; set; }

    }
}
