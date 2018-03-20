using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Birthday_Greetings
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLetter(Letters.H);

			Console.ReadKey();
		}

		static void WriteLetter(Letters letter)
		{
			switch (letter)
			{
				case Letters.H:

					WriteVertical();

					

					break;
				case Letters.A:
					break;
				case Letters.P:
					break;
				case Letters.Y:
					break;
				case Letters.B:
					break;
				case Letters.I:
					break;
				case Letters.R:
					break;
				case Letters.T:
					break;
				case Letters.D:
					break;
			}
		}

		static void WriteVertical()
		{
			for (int i = 0; i < 5; i++)
			{
				Pointer.YCoord = i;

				Console.Write("█");

				Thread.Sleep(150);

			}
		}
	}

	class Pointer
	{
		private static int xCoord = 0;

		private static int yCoord = 0;

		internal static int XCoord
		{
			get
			{
				return xCoord;
			}

			set
			{
				xCoord = value;

				Console.SetCursorPosition(xCoord, YCoord);
			}
		}

		internal static int YCoord
		{
			get
			{
				return yCoord;
			}
			set
			{
				yCoord = value;

				Console.SetCursorPosition(xCoord, YCoord);
			}
		}
	}
	
	enum Letters
	{
		H, A, P, Y, 
		B, I, R, T, D
	}
}
