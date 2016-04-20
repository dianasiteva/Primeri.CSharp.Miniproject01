using System;

namespace Calculations
{
	public class Formula02
	{
		Colors.ForCLI _cl = new Colors.ForCLI();   //CLI - command line interface

		//Формула за вдлъбнат ъгъл
		public Formula02 ()
		{
		}


		//Метод
		public void calc ( string _input )
		{
		try{
				
			string[] param = _input.Split(' ');

				if (_input.Length > 1 && _input.ToLower().Contains ( "-п" )) 
			{
				//Помощ за командата
				help();

			}

				if (_input.Length > 1  && !_input.ToLower().Contains ( "-п" ) && param.Length == 4) 
				{
				//Изчисления
						double result = 0;
					if ( runCalculate ( param, out result ) )
					{
						_cl.Default(); Console.Write ("Обемът на вдлъбнатият ъгъл е: ");
						_cl.Result();  Console.Write (result.ToString("N3"));
						_cl.Default(); Console.WriteLine ( " м3\n" );
					}else{
						_cl.Default(); Console.WriteLine("Има грешно въведени параметри. Можете да проверите синтаксиса с параметър '-п'.\n");
					}
				}

			}catch{
			}
		}

		//Метод
		private bool runCalculate ( string[] _param, out double _rezult )
		{
			try{
				double a = 0, b = 0, h = 0;
				//_param[0] == <ime na komandata>
				Double.TryParse ( _param[1], out a );
				Double.TryParse ( _param[2], out b );
				Double.TryParse ( _param[3], out h );

				if ( a>0 && b>0 && h>0 && _param.Length ==4)
				{
						_rezult = a*b*h/3;
						return true;
				}
			}catch{
			}

			_rezult=0;
			return false;

		}


		private void help()
		{
			_cl.Result (); Console.Write ("[въгъл]");
			_cl.Default(); Console.WriteLine ( " - команда за пресмятане на вдлъбнат ъгъл" );

			_cl.Command(); Console.Write ("параметри: ");
			_cl.Default(); Console.WriteLine ( "a b и h\n" );

			_cl.Command(); Console.Write ("параметри а и b: ");
			_cl.Default(); Console.WriteLine ( " - ширина и дължина на ъгъла" );

			_cl.Command(); Console.Write ("параметър h: ");
			_cl.Default(); Console.WriteLine ( " - височина на изкопа\n" );

			_cl.Command(); Console.Write ("Пример: ");
			_cl.Default(); Console.WriteLine ( "въгъл 1 1 3\n" );
		}

	}
}

