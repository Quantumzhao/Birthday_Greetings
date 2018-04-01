using System;
using SupplementaryClassLibraryForStringManipulation;
using System.Threading;

namespace Birthday_Greetings
{
	class Program
	{
		const string test = "SEKAI-DE-ICHIPAN O-HIME-SAMA ";

		const string greeting = "HAPPY BIRTHDAY";

		public static void Main(string[] args)
		{
			initialization();

			if (Convert.ToDateTime(DateTime.Now.ToShortDateString()) < Convert.ToDateTime("2018/8/31"))
			{
				Console.WriteLine("还没有到查看的时间哦\n");			
			}
			else
			{
				Thread.Sleep(9000);
				for (int i = 1; i <= StringManipulation.Len(test); i++)
				{
					WriteLetter(StringManipulation.Mid(test, i, 1));
				}

				WriteLetter(" ");

				Console.WriteLine("生日快乐哦\n");
			}

			for (int i = 0; i < 3; i++)
			{
				Console.Write(".");

				Thread.Sleep(5000);
			}

			Console.WriteLine("\n");

			Console.WriteLine("按Enter键退出");

			Console.ReadKey();
		}

		private static void initialization()
		{
			Console.CursorVisible = false;
			Console.WindowHeight = Console.LargestWindowHeight;
			Console.WindowWidth = Console.LargestWindowWidth;
			Console.WindowTop = 0;
			Console.WindowLeft = 0;
		}

		private static void WriteLetter(string letter)
		{
			switch (letter)
			{
				#region A

				case "A":

					Cursor.YCoord++;

					for (int i = 0; i < 4; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord++;
					}

					Cursor.YCoord--;

					Cursor.YCoord -= 4;

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;

					for (int i = 0; i < 4; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord++;
					}

					Cursor.YCoord--;

					Cursor.YCoord -= 2;
					Cursor.XCoord -= 4;

					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 6;
					Cursor.YCoord -= 2;

					break;

				#endregion

				#region B

				case "B":

					WriteVertical();

					Cursor.YCoord -= 4;
					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);
					Cursor.XCoord -= 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 4;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord -= 2;
					Console.Write("■");
					Thread.Sleep(150);
					Cursor.XCoord -= 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 8;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region C

				case "C":

					Cursor.XCoord += 6;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord -= 2;
					}

					Cursor.YCoord++;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord++;
					}

					Cursor.XCoord += 2;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord += 2;
					}

					Cursor.XCoord += 2;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region D

				case "D":

					WriteVertical();

					Cursor.YCoord -= 4;
					Cursor.XCoord += 2;

					Console.Write("■");
					Thread.Sleep(150);
					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord++;
					}

					Cursor.XCoord -= 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord -= 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 8;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region E

				case "E":

					WriteLetter("F");

					Cursor.XCoord -= 8;
					Cursor.YCoord += 4;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord += 2;
					}

					Cursor.YCoord -= 4;
					Cursor.XCoord += 2;

					break;

				#endregion

				#region F

				case "F":

					WriteVertical();

					Cursor.XCoord += 2;
					Cursor.YCoord -= 4;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord += 2;
					}

					Cursor.XCoord -= 6;
					Cursor.YCoord += 2;

					Console.Write("■");
					Thread.Sleep(150);
					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 6;
					Cursor.YCoord -= 2;

					break;

				#endregion

				#region G

				case "G":

					Cursor.XCoord += 6;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord -= 2;
					}

					Cursor.YCoord++;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord++;
					}

					Cursor.XCoord += 2;

					for (int i = 0; i < 2; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord += 2;
					}

					Cursor.YCoord--;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 4;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region H

				case "H":

					WriteVertical();

					Cursor.XCoord += 2;
					Cursor.YCoord -= 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord -= 2;

					WriteVertical();

					Cursor.XCoord += 4;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region I

				case "I":

					WriteVertical();

					Cursor.XCoord += 4;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region J

				case "J":

					Cursor.XCoord += 2;

					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					for (int i = 0; i < 4; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord++;
					}

					Cursor.XCoord -= 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 6;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region K

				case "K":

					WriteVertical();

					Cursor.XCoord += 6;
					Cursor.YCoord -= 4;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord -= 2;
						Cursor.YCoord++;						
					}

					Cursor.XCoord += 4;
					Console.Write("■");
					Thread.Sleep(150);
					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 4;
					Cursor.YCoord -= 4;
					
					break;

				#endregion

				#region L

				case "L":

					WriteVertical();

					Cursor.XCoord += 2;
					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord += 2;
					}

					Cursor.XCoord += 2;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region M

				case "M":

					WriteVertical();

					Cursor.XCoord += 2;
					Cursor.YCoord -= 3;

					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord--;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord--;
					WriteVertical();

					Cursor.XCoord += 4;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region N

				case "N":

					WriteVertical();

					Cursor.YCoord -= 4;
					for (int i = 0; i < 3; i++)
					{
						Cursor.XCoord += 2;
						Cursor.YCoord++;

						Console.Write("■");
						Thread.Sleep(150);
					}

					Cursor.XCoord += 2;
					Cursor.YCoord += 2;

					for (int i = 0; i < 5; i++)
					{
						Cursor.YCoord--;

						Console.Write("■");

						Thread.Sleep(150);												
					}

					Cursor.XCoord += 4;

					break;

				#endregion

				#region O

				case "O":

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.YCoord++;
					Cursor.XCoord -= 2;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord++;
					}

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);
					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord--;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord--;
					}

					Cursor.XCoord -= 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 6;

					break;

				#endregion

				#region P

				case "P":

					WriteVertical();

					Cursor.YCoord -= 4;

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord -= 2;
					Cursor.YCoord++;

					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord -= 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 8;
					Cursor.YCoord -= 2;

					break;

				#endregion

				#region Q

				case "Q":

					WriteLetter("O");

					Cursor.XCoord -= 4;
					Cursor.YCoord += 4;

					Console.Write("■");
					Thread.Sleep(150);
					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 4;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region R

				case "R":

					WriteLetter("P");

					Cursor.XCoord -= 6;
					Cursor.YCoord += 3;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 4;
					Cursor.YCoord -= 4;

					break;

				#endregion
					
				#region S

				case "S":

					Cursor.XCoord += 6;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord -= 2;
					}

					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.YCoord++;
					for (int i = 0; i < 3; i++)
					{
						Cursor.XCoord -= 2;

						Console.Write("■");

						Thread.Sleep(150);
					}

					Cursor.XCoord += 10;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region T

				case "T":

					for (int i = 0; i < 5; i++)
					{
						Console.Write("■");
						Thread.Sleep(150);
						Cursor.XCoord += 2;
					}

					Cursor.XCoord -= 6;
					Cursor.YCoord++;

					for (int i = 0; i < 4; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord++;
					}

					Cursor.YCoord--;

					Cursor.XCoord += 8;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region U

				case "U":

					for (int i = 0; i < 4; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.YCoord++;
					}

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);
					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					for (int i = 0; i < 5; i++)
					{
						Cursor.YCoord--;

						Console.Write("■");

						Thread.Sleep(150);
					}

					Cursor.XCoord += 4;

					break;

				#endregion

				#region V

				case "V":

					WriteVertical();

					Cursor.XCoord += 2;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord--;
					Console.Write("■");
					Thread.Sleep(150);
					Cursor.YCoord--;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord--;
					Console.Write("■");
					Thread.Sleep(150);
					Cursor.YCoord--;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 4;

					break;

				#endregion

				#region W

				case "W":

					WriteVertical();

					Cursor.XCoord += 2;
					Cursor.YCoord--;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord--;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord += 2;
					for (int i = 0; i < 5; i++)
					{
						Cursor.YCoord--;

						Console.Write("■");

						Thread.Sleep(150);
					}

					Cursor.XCoord += 4;

					break;

				#endregion

				#region X

				case "X":

					Console.Write("■");
					Thread.Sleep(150);

					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 4;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.YCoord -= 4;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord -= 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord -= 4;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 12;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region Y

				case "Y":

					Console.Write("■");
					Thread.Sleep(150);
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 4;
					Cursor.YCoord -= 2;

					Console.Write("■");
					Thread.Sleep(150);
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord -= 2;
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord -= 2;
					Cursor.YCoord++;

					Console.Write("■");
					Thread.Sleep(150);
					Cursor.YCoord++;
					Console.Write("■");
					Thread.Sleep(150);

					Cursor.XCoord += 8;
					Cursor.YCoord -= 4;

					break;

				#endregion

				#region Z

				case "Z":

					for (int i = 0; i < 4; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);
						
						Cursor.XCoord += 2;
					}
					Cursor.XCoord -= 2;
					Cursor.YCoord++;

					for (int i = 0; i < 3; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord -= 2;
						Cursor.YCoord++;
					}

					for (int i = 0; i < 4; i++)
					{
						Console.Write("■");

						Thread.Sleep(150);

						Cursor.XCoord += 2;
					}

					Cursor.XCoord += 2;
					Cursor.YCoord -= 4;

					break;

				#endregion
					
				#region " "

				case " ":

					Cursor.XCoord = 0;
					Cursor.YCoord += 7;

					break;

				#endregion

				default:

					Cursor.XCoord += 12;

					break;
			}
		}

		private static void WriteVertical()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Write("■");

				Thread.Sleep(150);

				Cursor.YCoord++;
			}

			Cursor.YCoord--;
		}
	}

	class Cursor
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
}
