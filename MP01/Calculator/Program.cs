using System;

namespace Calculator
{
	class MainClass
	{
		//Дефиниране на библиотеки
		public UserInput.UInput uInput=new UserInput.UInput();  //не е static




		public static void Main (string[] args)              //static
		{
			MainClass _program = new MainClass ();          //предефинира се за заделяне на памет, защото е static,  а вика не static
			_program.uInput.getUserCommands ();

		}
	}
}
