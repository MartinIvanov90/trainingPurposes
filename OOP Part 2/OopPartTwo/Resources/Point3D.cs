using System;
namespace OopPartTwo
{
    public struct Point3D
    {
        //Fields
        private int x;
        private int y;
        private int z;
        //initialize
        private static readonly Point3D coordSysStart;
        //Properties
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }
        public static Point3D CoordSysStart
        {
            get
            {
                return coordSysStart;
            }
        }

        static Point3D()
        {
            coordSysStart = new Point3D(0, 0, 0);
        }
        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        
        public override string ToString()
        {
            return $"{X} {Y} {Z}";
        }
    }
}

