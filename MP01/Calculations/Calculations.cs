using System;

namespace Calculations
{
	public class MainLibrary   //Главен клас
	{
		//Дефиниции
		public Formula01 F01 = new Formula01();
		public Formula02 F02 = new Formula02();
		public Formula03 F03 = new Formula03(); 

		//Библиотеки
		private Colors.ForCLI _cl = new Colors.ForCLI ();

		//Конструктор
		public MainLibrary ()
		{
		}

		//Методи
		public void commands()
		{
			_cl.Default (); Console.WriteLine ("Налични команди ( въвеждат се без квадратните скоби )\n");
			_cl.Command (); Console.Write ("[яма]");
			_cl.Default (); Console.WriteLine (" - пресмятане на строителна яма");
			_cl.Command (); Console.Write ("[въъл]");
			_cl.Default (); Console.WriteLine (" - пресмятане на вдлъбнат ъгъл");
			_cl.Command (); Console.Write ("[иъгъл]");
			_cl.Default (); Console.WriteLine (" - пресмятане на изпъкнал ъгъл\n");
			_cl.Command (); Console.Write ("[помощ] или [п]");
			_cl.Default (); Console.WriteLine (" - показва наличните команди\n");
			_cl.Command (); Console.Write ("[изчисти] или [и]");
			_cl.Default (); Console.WriteLine (" - изчиства екрана\n");
			_cl.Command (); Console.Write ("[изход]");
			_cl.Default (); Console.WriteLine (" - изход от конзолата\n");

		}

	}
}

