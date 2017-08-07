using System;
using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Providers;
using OlympicGames.Olympics.Models;
using OlympicGames.Core.Factories;
using System.Linq;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command
    {
        private readonly IOlympian boxer;

        public CreateBoxerCommand(IList<string> commandLine) : base(commandLine)
        {
            if (commandLine.Count < 6)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }

            int wins = 0;
            int losses = 0;
            if(int.TryParse(commandLine[4],out wins)&& int.TryParse(commandLine[5], out losses))
            {
                this.boxer = base.Factory.CreateBoxer(commandLine[0],
                            commandLine[1],
                            commandLine[2],
                            commandLine[3],
                            wins,
                            losses);
                base.Committee.Olympians.Add(this.boxer);

            }
            else
            {
                throw new ArgumentException(GlobalConstants.WinsLossesMustBeNumbers);
            }

            
        }

        public override string Execute()
        {
            return $"Created Boxer\n" +
                   boxer.ToString();
        }

    }
}
