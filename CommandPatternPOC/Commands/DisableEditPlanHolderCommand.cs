using System;
using CommandPatternPOC.Commands;

namespace CommandPatternPOC
{
	public class DisableEditPlanHolderButtonCommand : ICommand, ICommandFactory
	{
		public string CommandName => "DisableEditPlanHolderButton";

		public void Execute()
		{
			Console.WriteLine("\n{0} Command Executed.", CommandName);
		}

		public ICommand MakeCommand(string arg)
		{
			return new DisableEditPlanHolderButtonCommand { };
		}
	}
}