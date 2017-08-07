using System;
using Academy.Models.Enums;
using Academy.Models.Utils.Abstracts;

namespace Academy.Models.Utils
{
    public class VideoResource : LectureResources
    {
        private DateTime uploadedOn;

        public DateTime UploadedOn
        {
            get
            {
                return this.uploadedOn;
            }
            private set
            {
                this.uploadedOn = value;
            }
        }

        public VideoResource(string name, string url, DateTime uploadedOn) : base(name, url)
        {
            base.type = ResourceType.Video;
            this.UploadedOn = uploadedOn;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n - Uploaded on: {this.UploadedOn.ToString()}\n"; ;
        }
    }
}