using System;

namespace UserInput
{

	/// <summary>
	/// Вход за потребителя. </summary>

	public class UInput
	{
		About.Me about = new About.Me();
		Colors.ForCLI _c = new Colors.ForCLI();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary();

		/// <summary>
		/// Конструктор на потребителския вход
		/// </summary>

		public UInput ()
		{
		}


		/// <summary>
		/// Метод за поздрав в началото
		/// </summary>
		public void sayHello ()
		{
			_c.Default ();
			Console.WriteLine ("Добре дошли в "  + about.shortname + "\n" + about.version  + "\n");

			_calc.commands ();

		}


		/// <summary>
		/// Метод за вземане на потребителската команда
		/// </summary>
		public void getUserCommands()
		{
			string _command="";

			do
			{     
				//Вземане на команда
				_c.Prompt(); Console.Write ("$ ");
				_c.Command(); _command = Console.ReadLine ();

				//Проверка за налични команди
				if ( _command.ToLower().Contains ("яма") ) _calc.F01.calc (_command);
				{
//					_c.Default();  Console.Write ("Стартирана е ");
//					_c.Result();   Console.WriteLine ("Команда 1.\n");
				}
				if ( _command.ToLower().Contains ("въгъл") ) _calc.F02.calc (_command);
//				{
//					_c.Default();  Console.Write ("Стартирана е ");
//					_c.Result();   Console.WriteLine ("Команда 2.\n");
//				}
//
				if ( _command.ToLower().Contains ("иъгъл") ) _calc.F03.calc (_command);
//				{
//					_c.Default();  Console.Write ("Стартирана е ");
//					_c.Result();   Console.WriteLine ("Команда 3.\n");
//				}
				if ( _command.ToLower().Contains ("съгъл") ) _calc.F04.calc (_command);
				if ( _command.ToLower().Contains ("канал") ) _calc.F05.calc (_command);

				if ( _command.ToLower().Contains ("помощ") || _command.ToLower() == "п" )      _calc.commands ();

				if ( _command.ToLower().Contains ("изчисти") || _command.ToLower() == "и" )      
				{
					Console.Clear();
					_c.Default ();
					Console.WriteLine ("Добре дошли в "  + about.shortname + "\n" + about.version  + "\n");

				}


			}while (_command.ToLower () != "изход" );
		}

		/// <summary>
		/// Тест метод за стартиране
		/// </summary>
		public void justTesting()     //примерна функция
		{
			Console.WriteLine ( "Стартиране на UserInput.UInput.justTesting ()" );
		}
	}
}

