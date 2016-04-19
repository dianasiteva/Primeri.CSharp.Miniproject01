﻿using System;

namespace Calculations
{
	public class Formula01
	{
		public Formula01 ()    //Формула за обикновена строителна яма
		{
		}
			public void calc ( string _userInput )
			{
				try{
					string[] param = _userInput.Split(' ');
				if (_userInput.Length > 1 && _userInput.Contains ( "-п" )) 
				{
					//Помощ за командата
				}
				if (_userInput.Length > 1 && !_userInput.Contains ( "-п" )) 
				{
					//Изчисления
					double _result = 0;
					if ( runCalculation ( param, out _result ) )
					{
						Console.Write ("Обемът на строителната яма е:");
						Console.WriteLine (_result.ToString("N2"));
					}else{
						Console.WriteLine("Има грешно въведени параметри. Можете да проверите синтаксиса с параметър '-п'.");
					}

				}


				}catch{

						}

			}
			//Парсване

			//Изчисление и изписване
		private bool runCalculation ( string[] _param, out double _result )
		{
			try{
				double _a1 = 0, _b1 = 0, _a2 = 0, _b2 = 0, _h = 0;
				//_param[0] == <ime na komandata>
				Double.TryParse ( _param[1], out _a1 );
				Double.TryParse ( _param[2], out _b1 );
				Double.TryParse ( _param[3], out _a2 );
				Double.TryParse ( _param[4], out _b2 );
				Double.TryParse ( _param[5], out _h );

				double F1 = _a1*_b1, F2 = _a2*_b2;
				_result = _h*( F1 + F2 )/2;
				return true;
			}catch{

			}
			_result = 0;
			return false;
		}

			//Помощ за командата

	}
}

