using System;
using System.Collections.Generic;
using System.Globalization;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using System.Linq;
using OlympicGames.Olympics.Models;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : Command
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;
        private readonly IOlympian sprinter;

        public CreateSprinterCommand(IList<string> commandLine) : base(commandLine)
        {
            if (commandLine.Count < 3)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }
            commandLine.ValidateIfNull();
            records = new Dictionary<string, double>();
            records = commandLine.Skip(3).Select(x => x.Split('/')).ToDictionary(x => x.First(),x => double.Parse(x.Last(),CultureInfo.InvariantCulture));
            sprinter = base.Factory.CreateSprinter(commandLine[0], commandLine[1], commandLine[2], records);

            base.Committee.Olympians.Add(this.sprinter);
        }

        public override string Execute()
        {
            return $"Created Sprinter\n" + 
                   sprinter.ToString();
        }

    }
}
