using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	
	class Controller
	{
		/// <summary>
		/// imprima un meniu
		/// </summary>
		public void PrintMenu()
		{
			Console.WriteLine("Selectati functia de rulat:");

			Console.WriteLine("1.Plus1");
			Console.WriteLine("2.Plus2");
			Console.WriteLine("3.Plus3");
			Console.WriteLine("4.Plus4");
			Console.WriteLine("5.Plus5");
			Console.WriteLine("Esc pentru a iesi");
		}

        /// <summary>
        /// efectueaza lucrul principal cu utilizatorul
        /// </summary>
        /// <returns>returneaza false pentru a termina programul</returns>
        public bool Menu()
		{
			PrintMenu();
			ConsoleKey ch = Console.ReadKey(true).Key;
			if (ch == ConsoleKey.Escape)
				return false;

			Console.Clear();

			try
			{
				Console.WriteLine("Rezultatul: {0}\n\n", Switcher(ch));
			}
			catch (ArgumentException exc)
			{
				if (exc.Message == "Intrare necorespunzatoare")
					Console.WriteLine("Metoda gresita de a introduce argumente\n\n");
				else if (exc.Message == "Scadere")
					Console.WriteLine("Nu puteti introduce numere negative in aceasta functie\n\n");
				else if (exc.Message == "Niciun element de meniu")
					Console.WriteLine("Puteti alege prin apasarea tastelor numerice\n\n");
			}
			return true;
		}

        /// <summary>
        /// organizarea instructiunilor de comutare, functiile de apel Plus
        /// </summary>
        /// <param name="ch">cheie apasata de utilizator</param>
        /// <returns>returneaza rezultatul functiei plus</returns>
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
				default: throw new ArgumentException("niciun element de meniu");
			}
		}

        /// <summary>
        /// interogari si citeste sirul de argumente pentru functia Plus
        /// </summary>
        /// <returns></returns>
        public string ReadArguments()
		{
			Console.WriteLine("Introduceti un sir de argumente: ");
			return Console.ReadLine();
		}

	}
}
