using System;

namespace Calculations
{
	public class MainLibrary   //Главен клас
	{
		//Дефиниции
		public Formula01 F01 = new Formula01();
		public Formula02 F02 = new Formula02();
		public Formula03 F03 = new Formula03(); 
		public Formula04 F04 = new Formula04(); 
		public Formula05 F05 = new Formula05(); 

		//Библиотеки
		private Colors.ForCLI _cl = new Colors.ForCLI ();

		//Конструктор
		public MainLibrary ()
		{
		}

		//Методи
		public void commands()
		{
			_cl.Default (); Console.WriteLine ("Налични команди ( въвеждат се без квадратните скоби и параметрите - в метри;");
			_cl.Default (); Console.WriteLine ("                  параметър -п за помощ )\n");
			_cl.Command (); Console.Write ("[яма]");
			_cl.Default (); Console.WriteLine (" - пресмятане на строителна яма");
			_cl.Command (); Console.Write ("[въгъл]");
			_cl.Default (); Console.WriteLine (" - пресмятане на вдлъбнат ъгъл");
			_cl.Command (); Console.Write ("[иъгъл]");
			_cl.Default (); Console.WriteLine (" - пресмятане на изпъкнал ъгъл");
			_cl.Command (); Console.Write ("[съгъл]");
			_cl.Default (); Console.WriteLine (" - пресмятане на страничен ъгъл");
			_cl.Command (); Console.Write ("[канал]");
			_cl.Default (); Console.WriteLine (" - пресмятане на канален изкоп");
			_cl.Command (); Console.Write ("[помощ] или [п]");
			_cl.Default (); Console.WriteLine (" - показва наличните команди");
			_cl.Command (); Console.Write ("[изчисти] или [и]");
			_cl.Default (); Console.WriteLine (" - изчиства екрана");
			_cl.Command (); Console.Write ("[изход]");
			_cl.Default (); Console.WriteLine (" - изход от конзолата\n");

		}

	}
}

