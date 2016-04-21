using System;

namespace Calculations
{


	/// <summary>
	/// Клас за формула за страничен ъгъл. (Формула 4) </summary>

	public class Formula04
	{

		private Colors.ForCLI _cl = new Colors.ForCLI();

		public Formula04 ()
		{
		}


		/// <summary>
		/// Метод за пресмятане на Формула 4.
		/// </summary>
		/// <param name="_input">Въведено от потребителя.</param>

		public void calc ( string _input )
		{
			try{

				string[] param = _input.Split(' ');

				if (param.Length > 1 && _input.ToLower().Contains ( "-п" )) 
				{
					//Помощ за командата
					help();

				}

				if (param.Length > 1  && !_input.ToLower().Contains ( "-п" ) ) 
				{
					//Изчисления
					double result = 0;
					if ( runCalculate ( param, out result ) )
					{
						_cl.Default(); Console.Write ("Обемът на страничния ъгъл е: ");
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

		/// <summary>
		/// Вътрешен метод за формула 4 след парсване на командата от потребителя.
		/// </summary>
		/// <returns><c>true</c>, ако има изчислено, <c>false</c> грешка.</returns>
		/// <param name="_param">Въведеното разделено в масив.</param>
		/// <param name="_rezult">Изчисленият обем.</param>

		private bool runCalculate ( string[] _param, out double _rezult )
		{
			try{
				double a = 0, L = 0, h = 0;
				//_param[0] == <ime na komandata>
				Double.TryParse ( _param[1], out a );
				Double.TryParse ( _param[2], out h );
				Double.TryParse ( _param[3], out L );

				if ( a>0 && L>0 && h>0 && _param.Length ==4)
				{
					_rezult = a*L*h/2;
					return true;
				}
			}catch{
			}

			_rezult=0;
			return false;

		}

		/// <summary>
		/// Вътрешен метод, показващ синтаксиса на командата в командния ред. </summary>
		private void help()
		{
			_cl.Result (); Console.Write ("[съгъл]");
			_cl.Default(); Console.WriteLine ( " - команда за пресмятане на страничен ъгъл" );

			_cl.Command(); Console.Write ("параметри ( в метри ): ");
			_cl.Default(); Console.WriteLine ( "a h L\n" );

			_cl.Command(); Console.Write ("параметри а: ");
			_cl.Default(); Console.WriteLine ( " - ширина на профила" );

			_cl.Command(); Console.Write ("параметър h: ");
			_cl.Default(); Console.WriteLine ( " - височина на профила" );

			_cl.Command(); Console.Write ("параметър L: ");
			_cl.Default(); Console.WriteLine ( " - дължина на профила\n" );

			_cl.Command(); Console.Write ("Пример: ");
			_cl.Default(); Console.WriteLine ( "съгъл 1 1 3\n" );
		}






	}
}

