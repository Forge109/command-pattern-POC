using System;
using System.Collections.Generic;

namespace CommandPatternPOC
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Please select one of the following options:");
			Console.Write("\n1: Alterations Risk. \n2: New Business Risk.\n\n");
			var context = Console.ReadLine();
			bool isAlterationsRisk = context.Equals("1");

			var availableCommands = GetAvailableCommands(isAlterationsRisk);
			var listOfCommandNames = new List<string>();
			foreach (var comm in availableCommands)
			{
				listOfCommandNames.Add(comm.CommandName);
			}
			var commandsToAdd = string.Join("\n", listOfCommandNames);
			Console.Write("\nPlease enter one of the following: \n" + commandsToAdd + "\n\n");
			var input = Console.ReadLine();

			var parser = new CommandParser(availableCommands);
			var command = parser.ParseCommand(input);

			command.Execute();
			Console.WriteLine("\n\n\nPress any key to continue...");
			Console.Read();
		}

		static IEnumerable<ICommandFactory> GetAvailableCommands(bool isAlterationsRisk)
		{
			return new ICommandFactory[]
			{
					new DisableAddBenefitsButtonCommand(isAlterationsRisk),
					new DisableEditPlanHolderButtonCommand()
			};
		}
	}
}
