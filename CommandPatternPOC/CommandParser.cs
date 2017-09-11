using CommandPatternPOC.Commands;
using System.Collections.Generic;
using System.Linq;

namespace CommandPatternPOC
{
	internal class CommandParser
	{
		readonly IEnumerable<ICommandFactory> availableCommands;

		public CommandParser(IEnumerable<ICommandFactory> availableCommands)
		{
			this.availableCommands = availableCommands;
		}

		internal ICommand ParseCommand(string arg)
		{
			var requestedCommandName = arg;

			var command = FindRequestedCommand(requestedCommandName);

			return command.MakeCommand(arg);
		}

		ICommandFactory FindRequestedCommand(string commandName)
		{
			return availableCommands
				.FirstOrDefault(cmd => cmd.CommandName == commandName);
		}
	}
}