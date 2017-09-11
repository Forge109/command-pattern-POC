using System;
using CommandPatternPOC.Commands;

namespace CommandPatternPOC
{
	internal class DisableAddBenefitsButtonForALTCommand : ICommand, ICommandFactory
	{
		public string CommandName => "DisableAddBenefitsButtonForALT";

		public void Execute()
		{
			Console.WriteLine("\n{0} Command Executed.", CommandName);

			// Implement Child Commands here.
		}

		public ICommand MakeCommand(string arg)
		{
			return new DisableAddBenefitsButtonForALTCommand();
		}
	}
}