using System;

namespace app
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Console Calculator By AlphaTech");
			Console.WriteLine("-------------------------------");

			bool endApp = false;
			string option;

			while (endApp == false)
			{
				Console.WriteLine("\nOptions:\n");

				//Nota

				Console.WriteLine("To exit press other key and then press enter.");

				//Se muestran opciones
				Console.WriteLine("\nA - Add");
				Console.WriteLine("B - Substract");
				Console.WriteLine("C - Multiply");
				Console.WriteLine("D - Divide\n");

				Console.Write("Your option: ");
				option = Console.ReadLine();

				//Viendo cual es la opción seleccionada
				if (option == "A" || option == "a")
				{
					//El usuario quiere sumar
					string num1,
						num2;

					Console.Write("\nWrite one number: ");
					num1 = Console.ReadLine();

					Console.Write("Write other number: ");
					num2 = Console.ReadLine();

					double ConvertedNum1 = Convert.ToDouble(num1),
						ConvertedNum2 = Convert.ToDouble(num2),
						Result = ConvertedNum1 + ConvertedNum2;

					Console.WriteLine("\n" + num1 + " + " + num2 + " = " + Result);
				}
				else if (option == "B" || option == "b")
				{
					//El usuario quiere restar
					string num1,
						num2;

					Console.Write("\nWrite one number: ");
					num1 = Console.ReadLine();

					Console.Write("Write other number: ");
					num2 = Console.ReadLine();

					double ConvertedNum1 = Convert.ToDouble(num1),
						ConvertedNum2 = Convert.ToDouble(num2),
						Result = ConvertedNum1 - ConvertedNum2;

					Console.WriteLine("\n" + num1 + " - " + num2 + " = " + Result);
				}
				else if (option == "C" || option == "c")
				{
					//El usuario quiere multiplicar
					string num1,
						num2;

					Console.Write("\nWrite one number: ");
					num1 = Console.ReadLine();

					Console.Write("Write other number: ");
					num2 = Console.ReadLine();

					double ConvertedNum1 = Convert.ToDouble(num1),
						ConvertedNum2 = Convert.ToDouble(num2),
						Result = ConvertedNum1 * ConvertedNum2;

					Console.WriteLine("\n" + num1 + " X " + num2 + " = " + Result);
				}
				else if (option == "D" || option == "d")
				{
					//El usuario quiere dividir
					string num1,
						num2;

					Console.Write("\nWrite one number: ");
					num1 = Console.ReadLine();

					Console.Write("Write other number: ");
					num2 = Console.ReadLine();

					double ConvertedNum1 = Convert.ToDouble(num1),
						ConvertedNum2 = Convert.ToDouble(num2),
						Result = ConvertedNum1 / ConvertedNum2;

					while (ConvertedNum1 == 0 || ConvertedNum2 == 0)
					{
						//El usuario ingresó valores no válidos
						Console.Write("\nWrite one valid number: ");
						num1 = Console.ReadLine();

						Console.Write("Write other valid number: ");
						num2 = Console.ReadLine();

						ConvertedNum1 = Convert.ToDouble(num1);
						ConvertedNum2 = Convert.ToDouble(num2);

						Result = ConvertedNum1 / ConvertedNum2;
					}

					//El usuario ingresó valores válidos
					Console.WriteLine("\n" + num1 + " / " + num2 + " = " + Result);
				}

				string key;

				Console.Write("\nTo exit write 'exit' or 'Exit' and then press enter, to continue press other key and then press enter: ");
				key = Console.ReadLine();

				if (key == "Exit" ||key == "exit")
				{
					//El usuario quiere salir
					endApp = true;
				}
			}
		}
	}
}