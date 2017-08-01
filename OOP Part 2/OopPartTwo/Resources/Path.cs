using System;
using System.Collections.Generic;

namespace OopPartTwo
{
    public class Path
    {

        private List<Point3D> sequenceOfPoints;

        public List<Point3D> SequenceOfPoints
        {
            get
            {
                return this.sequenceOfPoints;
            }
            set
            {
                this.SequenceOfPoints = value;
            }
        }

        public Path()
        {
            this.sequenceOfPoints = new List<Point3D>();
        }
        public void AddPoint(Point3D singlePoint)
        {
            this.sequenceOfPoints.Add(singlePoint);
        }
        public void RemovePoint(Point3D singlePoint)
        {
            this.sequenceOfPoints.Remove(singlePoint);
        }
    }
}
