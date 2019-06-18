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
	/// реализует функции сложения из задания
	/// </summary>
	public class Plus
	{
		/// <summary>
		/// регулярное выражение для нахождения числа с возможными знаками + и - (например, 5, +6, -9)
		/// </summary>
		Regex number1 = new Regex(@"[+-]?\d+(\.\d)?\d*");

		/// <summary>
		/// регулярное выражение аналогичное предыдущему, но без знака -
		/// </summary>
		Regex number2 = new Regex(@"\+?\d+(\.\d)?\d*");

		/// <summary>
		/// результата сложения
		/// </summary>
		double res = 0;

		/// <summary>
		/// оаргумент сложения
		/// </summary>
		double arg;
		/// <summary>
		/// регулярное выражение для выяснения, можно ли данную строку обработать
		/// </summary>
		Regex reg;

		/// <summary>
		/// складывает два числа, перечисленные во входной строке через запятую
		/// </summary>
		public double Plus1(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*,[+-]?\d+(\.\d)?\d*$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("плохой ввод");
			
			foreach (Match m in number1.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}

		/// <summary>
		/// улучшение Plus1
		/// в отличие от Plus1, принимает произвольное число аргументов
		/// </summary>
		public double Plus2(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*(,[+-]?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("плохой ввод");

			foreach (Match m in number1.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}

		/// <summary>
		/// улучшение Plus2
		/// в отличие от Plus2, понимает большее число разделителей
		/// </summary>
		public double Plus3(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-][+-]?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("плохой ввод");

			foreach (Match m in number1.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}

		/// <summary>
		/// улучшение Plus3
		/// в отличие от Plus3, ругается на отрицательные числа
		/// </summary>
		public double Plus4(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-][+-]?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("плохой ввод");

			reg = new Regex(@"^\+?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-]\+?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("вычитание");

			foreach (Match m in number2.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}

		/// <summary
		/// улучшение Plus4
		/// в отличие от Plus4, можно ставить от 1 до 3 разделителей
		/// </summary>
		public double Plus5(string argStr)
		{
			reg = new Regex(@"^[+-]?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-]{1,3}[+-]?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("плохой ввод");

			reg = new Regex(@"^\+?\d+(\.\d)?\d*([	, ~!@#$%^&*()_+-]{1,3}\+?\d+(\.\d)?\d*)+$");

			if (!reg.IsMatch(argStr))
				throw new ArgumentException("вычитание");

			foreach (Match m in number2.Matches(argStr))
			{
				if (Double.TryParse(m.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out arg))
					res += arg;
			}

			return res;
		}
	}
}
