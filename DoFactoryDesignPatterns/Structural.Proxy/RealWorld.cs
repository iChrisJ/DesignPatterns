﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy
{
	class RealWorld
	{
		static void Main()
		{
			MathProxy proxy = new MathProxy();
			Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
			Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
			Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
			Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

			Console.ReadKey();
		}
	}

	/// <summary>
	/// The 'Subject' interface.
	/// </summary>
	public interface IMath
	{
		double Add(double x, double y);
		double Sub(double x, double y);
		double Mul(double x, double y);
		double Div(double x, double y);
	}

	/// <summary>
	/// The 'RealSubject' class.
	/// </summary>
	public class Math : IMath
	{
		public double Add(double x, double y)
		{
			return x + y;
		}

		public double Sub(double x, double y)
		{
			return x - y;
		}

		public double Mul(double x, double y)
		{
			return x * y;
		}

		public double Div(double x, double y)
		{
			return x / y;
		}
	}

	/// <summary>
	/// The 'Proxy Object' class.
	/// </summary>
	public class MathProxy : IMath
	{
		private Math _math = new Math();
		public double Add(double x, double y)
		{
			return _math.Add(x, y);
		}

		public double Sub(double x, double y)
		{
			return _math.Sub(x, y);
		}

		public double Mul(double x, double y)
		{
			return _math.Mul(x, y);
		}

		public double Div(double x, double y)
		{
			return _math.Div(x, y);
		}
	}
}
