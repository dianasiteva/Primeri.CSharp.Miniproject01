using System;

namespace Calculations
{


	/// <summary>
	/// Клас за формула за канален изкоп. (Формула 5) </summary>

	public class Formula05
	{

		private Colors.ForCLI _cl = new Colors.ForCLI();

		public Formula05 ()
		{
		}



		/// <summary>
		/// Метод за пресмятане на Формула 5.
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
						_cl.Default(); Console.Write ("Обемът на каналния изкоп е: ");
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
		/// Вътрешен метод за формула 5 след парсване на командата от потребителя.
		/// </summary>
		/// <returns><c>true</c>, ако има изчислено, <c>false</c> грешка.</returns>
		/// <param name="_param">Въведеното разделено в масив.</param>
		/// <param name="_rezult">Изчисленият обем.</param>

		private bool runCalculate ( string[] _param, out double _rezult )
		{
			try{
				double a = 0, b = 0, h = 0, L = 0;
				//_param[0] == <ime na komandata>
				Double.TryParse ( _param[1], out a );
				Double.TryParse ( _param[2], out b );
				Double.TryParse ( _param[3], out h );
				Double.TryParse ( _param[4], out L );

				if ( a>0 && b>0 && h>0 && L>0 && _param.Length ==5)
				{
					_rezult = (a + b) / 2 * h * L;
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
			_cl.Result (); Console.Write ("[канал]");
			_cl.Default(); Console.WriteLine ( " - команда за пресмятане на канален изкоп" );

			_cl.Command(); Console.Write ("параметри ( в метри ): ");
			_cl.Default(); Console.WriteLine ( "a b h L\n" );

			_cl.Command(); Console.Write ("параметри а и b: ");
			_cl.Default(); Console.WriteLine ( " - горна и долна ширина на профила" );

			_cl.Command(); Console.Write ("параметър h: ");
			_cl.Default(); Console.WriteLine ( " - височина на профила" );

			_cl.Command(); Console.Write ("параметър L: ");
			_cl.Default(); Console.WriteLine ( " - дължина на профила\n" );

			_cl.Command(); Console.Write ("Пример: ");
			_cl.Default(); Console.WriteLine ( "канал 3 1 2 100\n" );
		}








	}
}

