using Academy.Models.Enums;
using Academy.Models.Utils.Abstracts;

namespace Academy.Models.Utils
{
    public class PresentationResource : LectureResources
    {
        public PresentationResource(string name, string url) : base(name, url)
        {
            base.type = ResourceType.Presentation;
        }
    }
}
