using Academy.Models.Enums;
using Academy.Models.Utils.Abstracts;

namespace Academy.Models.Utils
{
    public class DemoResource : LectureResources
    {
        public DemoResource(string name, string url) : base(name, url)
        {
            base.type = ResourceType.Demo;
        }
    }
}
