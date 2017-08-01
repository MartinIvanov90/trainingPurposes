using System;
using System.IO;
using System.Linq;

namespace OopPartTwo
{
    public static class PathStorage
    {
        private static Path listOfItems = new Path();

        public static Path ListOfItems
        {
            get
            {
                return listOfItems;
            }
            set
            {
                listOfItems = value;
            }
        }
    
        public static void LoadFromFile()
        {
            using(StreamReader sReader = new StreamReader(@"C:\Users\Martin\Desktop\this.txt"))
            {
                
                    string line;

                    while ((line = sReader.ReadLine()) != null)
                    {
                        int[] pointHolder = line
                                            .Split(new char[] { ' ' })
                                            .Select(x => int.Parse(x))
                                            .ToArray();
                        ListOfItems.SequenceOfPoints.Add(new Point3D(pointHolder[0], pointHolder[1], pointHolder[2]));
                    }
               
            }
        }

        public static void SaveToFile()
        {
            using(StreamWriter sWriter = new StreamWriter(@"C:\Users\Martin\Desktop\this.txt"))
            {
                foreach(Point3D pointItem in ListOfItems.SequenceOfPoints)
                {
                    sWriter.WriteLine(pointItem); //pointItem вика ToString()
                }
            }
        }
    }
}
