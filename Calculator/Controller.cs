using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	/// <summary>
	/// практически вся работа программы здесь
	/// </summary>
	class Controller
	{
		/// <summary>
		/// печатает меню
		/// </summary>
		public void PrintMenu()
		{
			Console.WriteLine("Выберете запускаемую функцию:");

			Console.WriteLine("1.Plus1");
			Console.WriteLine("2.Plus2");
			Console.WriteLine("3.Plus3");
			Console.WriteLine("4.Plus4");
			Console.WriteLine("5.Plus5");
			Console.WriteLine("Esc для выхода");
		}

		/// <summary>
		/// производит основную работу с пользователем
		/// </summary>
		/// <returns>возвращает false для завершения работы программы</returns>
		public bool Menu()
		{
			PrintMenu();
			ConsoleKey ch = Console.ReadKey(true).Key;
			if (ch == ConsoleKey.Escape)
				return false;

			Console.Clear();

			try
			{
				Console.WriteLine("Результат: {0}\n\n", Switcher(ch));
			}
			catch (ArgumentException exc)
			{
				if (exc.Message == "плохой ввод")
					Console.WriteLine("Неподходящий способ ввода аргументов\n\n");
				else if (exc.Message == "вычитание")
					Console.WriteLine("нельзя вводить отрицательные числа в данной функции\n\n");
				else if (exc.Message == "нет пункта меню")
					Console.WriteLine("выбирать можно нажатием на клавиши с цифрами\n\n");
			}
			return true;
		}

		/// <summary>
		/// организуе оператор switch, вызывает функции Plus
		/// </summary>
		/// <param name="ch">нажатая пользователем клавиша</param>
		/// <returns>возвращает результат работы функции plus</returns>
		public double Switcher(ConsoleKey ch)
		{
			Plus a = new Plus();

			switch (ch)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					return a.Plus1(ReadArguments());
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					return a.Plus2(ReadArguments());
				case ConsoleKey.D3:
				case ConsoleKey.NumPad3:
					return a.Plus3(ReadArguments());
				case ConsoleKey.D4:
				case ConsoleKey.NumPad4:
					return a.Plus4(ReadArguments());
				case ConsoleKey.D5:
				case ConsoleKey.NumPad5:
					return a.Plus5(ReadArguments());
				default: throw new ArgumentException("нет пункта меню");
			}
		}

		/// <summary>
		/// запрашивает и считывает строку аргументов для функции Plus
		/// </summary>
		/// <returns></returns>
		public string ReadArguments()
		{
			Console.WriteLine("Введите строку аргументов: ");
			return Console.ReadLine();
		}

	}
}
