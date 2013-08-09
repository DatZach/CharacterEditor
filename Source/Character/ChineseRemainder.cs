using System;
using System.Data;

namespace CharacterEditor.Character
{
	/// <summary>
	/// Solve Chinese Remainder Problem
	/// Original source: http://www.codeproject.com/Articles/29610/Chinese-Remainder-Problem
	/// </summary>
	class ChineseRemainder
	{
		/// <summary>
		/// Get Greatest Common Divisor
		/// </summary>
		public static int Gcd(int a, int b)
		{
			if (a > b)
			{
				int t = b;
				b = a;
				a = t;
			}

			int r = b % a;
			while (r != 0)
			{
				b = a;
				a = r;
				r = b % a;
			}

			return a;
		}

		/// <summary>
		/// Get Least Common Multiple
		/// </summary>
		public static int Lcm(int a, int b)
		{
			int gcd = Gcd(a, b);
			return a * b / gcd;
		}

		/// <summary>
		/// Solve ax=by+1
		/// </summary>
		public static void Solve(int a, int b, out int x, out int y)
		{
			if (b == 1)
			{
				x = 1;
				y = a - 1;
			}
			else if (a == 1)
			{
				y = 1;
				x = b + 1;
			}
			else if (b > a)
			{
				int subx;
				Solve(a, b - a, out subx, out y);
				x = y + subx;
			}
			else if (a > b)
			{
				int suby;
				Solve(a - b, b, out x, out suby);
				y = x + suby;
			}
			else
				throw new DataException(String.Format("The equation {0}x={1}y+1 has no integer solution.", a, b));
		}

		/// <summary>
		/// Solve ax = by + c
		/// </summary>
		public static void Solve(int a, int b, int c, out int x1, out int y1)
		{
			/* if 
					a * x0 = b * y0 + 1
				then
					x = b * t + c * x0
					y = a * t + c * y0
				satisfies
					a * x  = b * y  + c
				so
					x1 = (c * x0) mod b
					y1 = (c * y0) mod a
				*/
			int d = Gcd(a, b);
			if (d > 1)
			{
				if (c % d != 0)
					throw new DataException(String.Format("The equation {0}x={1}y+{2} has no integer solution.", a, b, c));

				a = a / d;
				b = b / d;
				c = c / d;
			}

			int x0, y0;
			Solve(a, b, out x0, out y0);
			x1 = (c * x0) % b;
			y1 = (c * y0) % a;
		}

		/// <summary>
		/// Solve a * x + r1 = b * y + r2
		/// </summary>
		public static void Solve(int a, int b, int r1, int r2, out int x1, out int y1)
		{
			if (r2 > r1)
				Solve(a, b, r2 - r1, out x1, out y1);
			else if (r1 > r2)
				Solve(b, a, r1 - r2, out y1, out x1);
			else
			{
				x1 = b;
				y1 = a;
			}
		}

		/// <summary>
		/// Solve a * x + r1 = b * y + r2 = c * z + r3 = n
		/// n0 = n mod t
		/// </summary>
		public static void Solve(int a, int b, int c, int r1,
				int r2, int r3, out int n0, out int t)
		{
			int x1, y1;

			Solve(a, b, r1, r2, out x1, out y1);

			// let r4 = a * x1 + r1 = b * y1 + r2
			// to satisfy n = a * x + r1 = b * y + r2
			// we can see n = a * b * u + r4

			int r4 = a * x1 + r1;
			int x2, y2;

			Solve(a * b, c, r4, r3, out x2, out y2);
			n0 = c * y2 + r3;
			t = Lcm(Lcm(a, b), c);
			//n0 = n % t;
		}
	}
}
