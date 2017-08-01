using System;
using BlueVsWhiteColar.Bussines;
using BlueVsWhiteColar.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace BlueVsWhiteColar
{
    class MainCl
    {
        static void Main()
        {
            IEnumerable<Student> students = new List<Student>()
            {
            new Student("Some", "Guy", 4),
            new Student("Some1", "Guy", 5),
            new Student("Some2", "Guy", 3),
            new Student("Some3", "Guy", 4),
            new Student("Some4", "Guy", 6),
            new Student("Some5", "Guy", 2),
            new Student("Some6", "Guy", 5),
            new Student("Some7", "Guy", 5),
            new Student("Some8", "Guy", 6),
            new Student("Some9", "Guy", 4)
            };
            IEnumerable<Worker> workers = new List<Worker>()
            {
            new Worker("Some", "Worker",100, 4),
            new Worker("Some1", "Worker",100, 5),
            new Worker("Some2", "Worker",100, 3),
            new Worker("Some3", "Worker", 100, 4),
            new Worker("Some4", "Worker", 100, 6),
            new Worker("Some5", "Worker", 100, 2),
            new Worker("Some6", "Worker", 100, 5),
            new Worker("Some7", "Worker", 100, 5),
            new Worker("Some8", "Worker", 100, 6),
            new Worker("Some9", "Worker", 100, 4)
            };
            workers = workers.OrderByDescending(worker => worker.MoneyPerHourProp);

            List<Human> concat = new List<Human>();
            concat.AddRange(students);
            concat.AddRange(workers);
            concat = concat
                        .OrderBy(x => x.FirstName)
                        .ThenBy(y => y.LastName)
                        .ToList();
            for(int i = 0; i < concat.Count; i++)
            {
                Console.WriteLine(concat[i].FirstName + " " + concat[i].LastName);
            }




        }
    }
}
