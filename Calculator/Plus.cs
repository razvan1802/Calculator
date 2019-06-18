using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// implementeaza functia de adaugare
    /// </summary>
    public class Plus
	{
        /// <summary>
        /// expresie regulata pentru gasirea numerelor cu semne posibile + si - (de exemplu, 5, +6, -9)
        /// </summary>
        Regex number1 = new Regex(@"[+-]?\d+(\.\d)?\d*");

        /// <summary>
        /// expresia regulata este similara cu cea anterioara, dar fara semn -
		/// </summary>
		Regex number2 = new Regex(@"\+?\d+(\.\d)?\d*");

        /// <summary>
        /// rezultat suplimentar
		/// </summary>
		double res = 0;

        /// <summary>
        /// argument suplimentar
        /// </summary>
        double arg;
        /// <summary>
        /// expresie regulata pentru a afla daca un sir dat poate fi procesat
        /// </summary>
        Regex reg;

        /// <summary>
        /// adauga cele doua numere listate în linia de intrare separate prin virgule
        /// </summary>
        public double Plus1(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*,[+-]?\d+(\.\d)?\d*$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("intrare necorespunzatoare");
			
			foreach (Match m in number1.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}

        /// <summary>
        /// imbunatatire Plus1
        /// spre deosebire de Plus1, ia un numar arbitrar de argumente
        /// </summary>
        public double Plus2(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*(,[+-]?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("intrare necorespunzatoare");

			foreach (Match m in number1.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}

        /// <summary>
        /// imbunatatire Plus2
        /// spre deosebire de Plus2, intelege mai multe delimitatoare
        /// </summary>
        public double Plus3(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-][+-]?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("intrare necorespunzatoare");

			foreach (Match m in number1.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}

        /// <summary>
        /// imbunatatire Plus3
        /// spre deosebire de Plus3, accepta la numere negative
        /// </summary>
        public double Plus4(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-][+-]?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("intrare necorespunzatoare");

			reg = new Regex(@"^\+?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-]\+?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("scadere");

			foreach (Match m in number2.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}

        /// <summary
        /// imbunatatire Plus4
        /// spre deosebire de Plus4, puteti utiliza 1 pana la 3 delimitatori
        /// </summary>
        public double Plus5(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-]{1,3}[+-]?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("intrare necorespunzatoare");

			reg = new Regex(@"^\+?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-]{1,3}\+?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("scadere");

			foreach (Match m in number2.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}
	}
}
