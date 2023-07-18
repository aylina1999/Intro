using System.Data.SqlTypes;

namespace Intro
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.Title = "Привет Дотнет";
			Console.WriteLine("\t\t\tHello World");
			#region CONSOLE

			/*Console.BackgroundColor = ConsoleColor.Blue;
			Console.CursorLeft = 22;
			Console.CursorTop = 12;
			Console.Write("Привет дотнет))\n");


			Console.BackgroundColor = System.ConsoleColor.Green;
			Console.CursorLeft = 32;
			Console.CursorTop = 5;
			Console.Write("Привет дотнет))\n");
			Console.BackgroundColor = ConsoleColor.Black;*/
			#endregion CONSOLE

			#region STRING_OPERATIONS
			/*
			Console.Write("Введите Ваше имя: ");
			string first_name = Console.ReadLine();

			Console.Write("Введите Вашу фамилию: ");
			string last_name = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			string s_age = Console.ReadLine();
			int age = Convert.ToInt32(s_age);

			Console.WriteLine("Имя " + first_name + " " + "Фамилия " + last_name + " " + "Возраст " + age); //Конкатенация строк
			Console.WriteLine(String.Format("Имя {0}, Фамилия {1}, Возраст {2} лет.", first_name, last_name, age));  //Форматирование строк
			Console.WriteLine($"Имя {first_name} Фамилия {last_name} Возраст {age} ");  //интерполяция строк
			*/
			#endregion SRING_OPERATIONS


			#region DATA_TYPES
			/*Console.WriteLine(Boolean.FalseString);
			Console.WriteLine(Boolean.TrueString);
			Console.WriteLine(false);
			Console.WriteLine(true);

            Console.WriteLine("BOOL: ");
			Console.WriteLine(sizeof(bool));

            Console.WriteLine("CHAR: ");
			Console.WriteLine(sizeof(char));
			Console.WriteLine(Convert.ToInt32(Char.MinValue));
			Console.WriteLine(Convert.ToInt32(Char.MaxValue));
			Console.WriteLine(" ----------------- NUMERIC TYPES -------------- ");
			Console.WriteLine("SHORT: ");
			short a = 2;
			ushort b = 3;
			Console.WriteLine(short.MinValue +  "..." + short.MaxValue);

			Console.WriteLine(sizeof(short));
			Console.WriteLine($"Переменная типа short занимает {sizeof(short)} Байт памяти, и принимает значения в диапазоне от {short.MinValue} до {short.MaxValue}");

			Console.WriteLine("INT: ");
			Console.WriteLine(sizeof(int));
			Console.WriteLine($"Переменная типа int занимает {sizeof(int)} Байт памяти, и принимает значения в диапазоне от {int.MinValue} до {int.MaxValue}");

			Console.WriteLine("LONG: ");
			Console.WriteLine(sizeof(long));
			Console.WriteLine($"Переменная типа long занимает {sizeof(long)} Байт памяти, и принимает значения в диапазоне от {long.MinValue} до {long.MaxValue}");

			Console.WriteLine("FLOAT: ");
			Console.WriteLine(sizeof(float));
			Console.WriteLine($"Переменная типа float занимает {sizeof(float)} Байт памяти, и принимает значения в диапазоне от {float.MinValue} до {float.MaxValue}");

			Console.WriteLine("DOUBLE: ");
			Console.WriteLine(sizeof(double));
			Console.WriteLine($"Переменная типа double занимает {sizeof(double)} Байт памяти, и принимает значения в диапазоне от {double.MinValue} до {double.MaxValue}");

			Console.WriteLine("DECIMAL: ");
			Console.WriteLine(sizeof(decimal));
			Console.WriteLine($"Переменная типа decimal занимает {sizeof(decimal)} Байт памяти, и принимает диапазон значений от {decimal.MinValue} до {decimal.MaxValue}");
			*/
			#endregion DATA_TYPES

			#region TYPE_CONVERTIONS
			/*
			int a = 2;
			uint b = 3;
			a = (int)b;

			double c = 5.2;
			a = (int)c;

			bool day = true;
			Console.WriteLine(Convert.ToInt32(day));
			double d = a;
			*/
			#endregion TYPE_CONVERTIONS

			#region LITERALS
			/*
			Console.WriteLine(((Object)5).GetType()); //узнать тип значения, номер 1
			Console.WriteLine((5).GetType()); //узнать тип значения, номер два
			Console.WriteLine((5.0f).GetType()); 
			Console.WriteLine((5.0m).GetType());
			Console.WriteLine(3e-3);

			decimal dividend = Decimal.One;
			decimal divisor = 3;
			// the following displays 0.99999999999999999999999
			Console.WriteLine(Math.Round(dividend / divisor * divisor));
			*/
			#endregion LITERALS

			int i = 3;
			i = ++i + ++i;
			Console.WriteLine(i);
		}
	}
}