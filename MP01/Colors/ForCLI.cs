using System;

namespace Colors
{

	/// <summary>
	/// For CLI. Определяне на цветовата гама. </summary>

	public class ForCLI
	{
		public ForCLI ()
		{
		}

		public void Default ()
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}

		public void Prompt ()
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
		}

		public void Command ()
		{
			Console.ForegroundColor = ConsoleColor.Magenta;
		}

		public void Result ()
		{
			Console.ForegroundColor = ConsoleColor.White;
		}

	}
}

