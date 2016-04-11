using System;

namespace Calculator
{
	class MainClass
	{
		//Дефиниране на библиотеки
		public UserInput.UInput uInput=new UserInput.UInput();  //не е static
		public About.Me about=new About.Me ();




		public static void Main (string[] args)              //static
		{
			MainClass _program = new MainClass ();          //предефинира се за заделяне на памет, защото е static,  а вика не static

			//Форматиране на програмата
			Console.Title = _program.about.shortname + ", " + _program.about.version;

			//Стартиране на програмата
			_program.uInput.sejHello ();
			_program.uInput.getUserCommands ();

		}
	}
}
