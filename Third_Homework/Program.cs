using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
1.	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
Программа должна сосчитать количество введенных пользователем пробелов.
2.	Ввести с клавиатуры номер трамвайного билета (6-значное число)
и про-верить является ли данный билет счастливым (если на билете напечатано шестизначное число,
и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений
символов верхнего регистра на величину 32. Используя эту информацию, написать программу,
которая считывает с клавиатуры и конвертирует все символы нижнего регистра
в символы верхнего регистра и наоборот.
4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа
от A до B включительно; каждое число должно выводиться на новой строке;
при этом каждое число должно выводиться количество раз, равное его значению.
Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево.
Например, если было введено число 345, то программа должна вывести число 543.
 */
namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//------------------magic numbers------------------
			int ten = 10,
				hundred = 100,
				thousand = 1000;

			//-----------------------1-------------------------

			Console.WriteLine("Введите любые символы и пробелы, а в конце поставьте точку: ");
			int symbol = 0;
			int count = 0;
			while (symbol != '.')
			{
				symbol = Console.Read();
				if (symbol == ' ')
				{
					count++;
				}
			}
			Console.ReadLine();
			string amountOfSpaces = $"Кол-во пробелов: {count}";
			Console.WriteLine(amountOfSpaces);

			////-----------------------2-------------------------
			
			Console.Write("\nВведите 6-значное число: ");
			int bilet = Convert.ToInt32(Console.ReadLine());

			if (bilet > 99999 && bilet < 1000000)
			{
				Console.WriteLine("Число 6-значное!");
				int sumOfFirstPart = ((bilet / thousand) % ten)
					+ ((bilet / (thousand * ten)) % ten)
					+ ((bilet / (thousand * hundred)) % ten);

				int sumOfSecondPart = (bilet % ten)
					+ ((bilet % hundred) / ten)
					+ (((bilet % thousand) / hundred));

				Console.Write("Сумма первой половины: ");
				Console.WriteLine(sumOfFirstPart);
				Console.Write("Сумма второй половины: ");
				Console.WriteLine(sumOfSecondPart);

				if (sumOfFirstPart == sumOfSecondPart)
				{
					Console.WriteLine("Билет счаслтивый!");
				}
				else { Console.WriteLine("Билет не счастливый!"); }
			}
			else { Console.WriteLine("Число не 6-значное!"); }
			////-----------------------3-------------------------
			Console.WriteLine("\nВведите символы для перевода регистра в верхний и нижний: ");
			string registr = Console.ReadLine();
			string lowRegistr = "Нижний регистр: " + registr.ToLower();
			Console.WriteLine(lowRegistr);
			string highRegistr = "Верхгий регистр: " + registr.ToUpper();
			Console.WriteLine(highRegistr);

			//-----------------------4-------------------------

			Console.Write("\nВведите первое число: ");
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число: ");
			int secondNumber = Convert.ToInt32(Console.ReadLine());

			if (firstNumber > secondNumber)
			{
				int temp = firstNumber;
				firstNumber = secondNumber;
				secondNumber = temp;
			}
			while (firstNumber <= secondNumber)
			{
				for (int i = 0; i <= firstNumber; i++)
				{
					Console.Write(firstNumber);
					Console.Write(' ');
				}
				firstNumber++;
				Console.Write("\n");
			}
			//-----------------------5-------------------------
			Console.WriteLine("\nВведите натруральное число для перевертывания: ");
			int number = Convert.ToInt32(Console.ReadLine());
			string reverseNumber = null;
			if (number > 0)
			{
				Console.Write("Перевернуть: ");
				while (number > 0)
				{
					reverseNumber += number % ten;
					number = number / ten;
				}
				Console.WriteLine(reverseNumber);
			}
			else { Console.WriteLine("Число не натуральное!"); }

			Console.ReadKey();
		}
	}
}