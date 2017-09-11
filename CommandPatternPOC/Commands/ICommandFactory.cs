using CommandPatternPOC.Commands;

namespace CommandPatternPOC
{
	internal interface ICommandFactory
	{
		string CommandName { get; }

		ICommand MakeCommand(string arg);
	}
}