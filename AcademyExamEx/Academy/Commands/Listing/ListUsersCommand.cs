using System;
using System.Collections.Generic;
using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System.Text;
using System.Linq;

namespace Academy.Commands.Listing
{
    class ListUsersCommand : ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            var builder = new StringBuilder();

            if (this.engine.Trainers.Any())
            {
                foreach (var trainer in this.engine.Trainers)
                {
                    builder.AppendLine(trainer.ToString());
                }
            }

            if (this.engine.Students.Any())
            {
                foreach (var student in this.engine.Students)
                {
                    builder.AppendLine(student.ToString());
                }
            }

            if (builder.ToString().Equals(""))
            {
                return $"There are no registered users!";
            }

            return builder.ToString().TrimEnd();

        }
    }
}
