using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.	Объявить одномерный (5 элементов ) массив с именем A
 * и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B.
 * Заполнить одномерный массив А числами, введенными с клавиатуры пользователем,
 * а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов:
 * массива А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный элемент,
 * минимальный элемент, общую сумму всех элементов, общее произведение всех элементов,
 * сумму четных элементов массива А, сумму нечетных столбцов массива В.
2.	Даны 2 массива размерности M и N соответственно. Необходимо переписать
в третий массив общие элементы первых двух массивов без повторений. 
3.	Пользователь вводит строку. Проверить, является ли эта строка палиндромом.
Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
4.	Подсчитать количество слов во введенном предложении.
5.	Дан двумерный массив размерностью 5?5, заполненный случайными числами из диапазона от –100 до 100.
Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.

 */
namespace practical_work2
{
	class Program
	{
		static void Main(string[] args)
		{
			//--------------------------------magic numbers----------------------------------------
			int one = 1,
				two = 2,
				three = 3,
				four = 4,
				five = 5,
				ten = 10,
				hundred = 100;
			//-----------------------------------------1-----------------------------------------------
			Console.WriteLine("\n------------------------1-----------------------\n");
			int[] array = new int[five];

			//-----Первый способ инициализации массива, числа вводятся через ENTER--------------
			Console.Write("Введите 5 элементов массива чисел через ENTER: \n");
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			//-------Второй способ инициализации массива, числа вводятся подряд------------------
			//int ArrayInit = 0;
			//for (int i = 0; i < array.Length; i++)
			//{
			//	ArrayInit = (Console.Read());
			//	array[i] = Convert.ToInt32(((char)ArrayInit).ToString());
			//}

			Console.Write("\nПервый массив: ");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i]);
				Console.Write(" ");
			}

			double[,] arraySecond = new double[three, four];
			Random random = new Random();

			Console.WriteLine("\n\nВторой массив: ");
			for (int i = 0; i < arraySecond.GetUpperBound(0) + one; i++)//(0)-первое измерение массива
			{
				for (int j = 0; j < arraySecond.GetUpperBound(1) + one; j++)//(1)-второе измерение массива
				{
					arraySecond[i, j] = random.Next(ten) + (double)random.Next(ten) / ten;
					Console.Write(arraySecond[i, j]);
					Console.Write(" ");
				}
				Console.Write("\n");
			}
			//Нахождение общих мин и макс, общие сумма и произведение, сумма четных элементов массива А,
			//и сумма нечетных столбцов массива В:

			int min = array[0], max = array[0], mult = 1, sum = 0,
				sumEvenElementsOfFirstArray = 0;

			double secondMin = arraySecond[0, 0], secondMax = arraySecond[0, 0],
				secondMult = 1, secondSum = 0,
				sumOddColumnsOfSecondArray = 0;

			//1 массив
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < min) { min = array[i]; }//мин
				if (array[i] > max) { max = array[i]; }//макс
				sum += array[i];                       //сумма
				mult *= array[i];                      //произведение
				if (array[i] % 2 == 0) { sumEvenElementsOfFirstArray += array[i]; }//сумма чётных

			}
			//2 массив
			for (int i = 0; i < arraySecond.GetUpperBound(0) + one; i++)
			{
				for (int j = 0; j < arraySecond.GetUpperBound(1) + one; j++)
				{
					if (arraySecond[i, j] < secondMin) { secondMin = arraySecond[i, j]; }//мин
					if (arraySecond[i, j] > secondMax) { secondMax = arraySecond[i, j]; }//макс
					secondSum += arraySecond[i, j];                                      //сумма
					secondMult *= arraySecond[i, j];                                     //произведение
					if (arraySecond[i, j] % 2 != 0 && arraySecond[i, j] == (int)arraySecond[i, j])//сумма нечётных
					{//сделаем arraySecond[i, j] == (int)arraySecond[i, j]
					 //так как чётность и нечётность есть только и целых чисел
						sumOddColumnsOfSecondArray += arraySecond[i, j];
					}
				}
			}
			Console.Write("\nОбщий минимальный элемент = ");
			if (min < secondMin)
			{
				Console.WriteLine(min);
			}
			else { Console.WriteLine(secondMin); }

			Console.Write("Общий максимальный элемент = ");
			if (max > secondMax)
			{
				Console.WriteLine(max);
			}
			else { Console.WriteLine(secondMax); }

			string resultOfMassives = $"Общая Сумма = {sum + secondSum}\n" +
				$"Общее Произведение = {mult * secondMult}\n" +
				$"сумма чётных элементов 1 массива = { sumEvenElementsOfFirstArray}\n" +
				$"сумма нечётных элементов 2 массива = { sumOddColumnsOfSecondArray}\n";
			Console.WriteLine(resultOfMassives);

			//-----------------------------------------2-----------------------------------------
			Console.WriteLine("\n------------------------2-----------------------\n");

			int[] ArrayOne = { 1, 2, 3, 4, 5 };
			int[] ArrayTwo = { 7, 2, 1, 8, 3, 15, 2 };
			int sizeOfThree = 0;
			
			Console.Write("Первый массив: ");
			for (int i = 0; i < ArrayOne.Length; i++)
			{
				Console.Write(ArrayOne[i]);
				Console.Write(" ");
			}
			Console.Write("\n\nВторой массив: ");
			for (int i = 0; i < ArrayOne.Length; i++)
			{
				Console.Write(ArrayTwo[i]);
				Console.Write(" ");
			}

			Console.Write("\n\n3 массив с общими элементами 1-ого и 2-ого массива: ");
			for (int i = 0; i < ArrayOne.Length; i++)
			{
				for (int j = 0; j < ArrayOne.Length; j++)
				{
					if (ArrayOne[i] == ArrayTwo[j])
					{
						sizeOfThree++;
					}
				}
			}

			int[] ArrayThree = new int[sizeOfThree];
			int k = 0;
			for (int i = 0; i < ArrayOne.Length; i++)
			{
				for (int j = 0; j < ArrayOne.Length; j++)
				{
					if (ArrayOne[i] == ArrayTwo[j])
					{
						ArrayThree[k] = ArrayOne[i];
						k++;
					}
				}
			}
			for (int i = 0; i < sizeOfThree; i++)
			{
				Console.Write(ArrayThree[i]);
				Console.Write(" ");
			}

			//-----------------------------------------3-----------------------------------------
			Console.WriteLine("\n------------------------3-----------------------\n");

			Console.WriteLine("\nВведите палиндром: ");
			string palindrom = (Console.ReadLine()).ToLower();//в нижний регистр
			palindrom = palindrom.Replace(" ", String.Empty);//удаляем пробелы
			Console.WriteLine(palindrom);

			int palindromCounter = 0;
			for (int i = 0, j = palindrom.Length - one;
				i < j && i < palindrom.Length / two && j >= palindrom.Length / two;
				i++, j--)
			{
				if (palindrom[i] == palindrom[j]) { palindromCounter++; }
			}
			if (palindromCounter == palindrom.Length / two && string.IsNullOrEmpty(palindrom) == false)
			{ Console.WriteLine("Текст является палиндромом!"); }
			else if (string.IsNullOrEmpty(palindrom) == true) { Console.WriteLine("Текст пустой!"); }
			else { Console.WriteLine("Текст не является палиндромом!"); }

			//-----------------------------------------4-----------------------------------------
			Console.WriteLine("\n------------------------4------------------------\n");
			
			Console.WriteLine("\nВведите целое предложение: ");
			string sentence = (Console.ReadLine()).Trim();
			int count = 0;
			for (int i = 0; i < sentence.Length; i++)
			{
				if (sentence[i] == ' ' && sentence[i + 1] == ' ') { continue; }//проверка на несколько и более пробелов подряд
				if (sentence[i] == ' ') { count++; }
			}
			if (string.IsNullOrEmpty(sentence) == true) { Console.WriteLine("Предложение пустое!"); }
			else
			{
				Console.Write("Кол-во слов: ");
				Console.Write(count + 1);
			}

			//-----------------------------------------5-----------------------------------------
			Console.WriteLine("\n------------------------5--------------------------\n");
			Console.WriteLine("Массив 5x5: \n");

			int[,] arrayFinal = new int[5, 5];
			Random randomFinal = new Random();

			//инициализация массива
			for (int i = 0; i < arrayFinal.GetUpperBound(0) + one; i++)
			{
				for (int j = 0; j < arrayFinal.GetUpperBound(1) + one; j++)
				{
					arrayFinal[i, j] = randomFinal.Next(-hundred,hundred);// делаем рандом(-100,100)
					Console.Write(arrayFinal[i, j]);
					Console.Write(" ");
				}
				Console.WriteLine();
			}

			//нахождение макс и мин
			int sumFinal = 0;
			int minFinal = arrayFinal[0, 0];
			int maxFinal = arrayFinal[0, 0];

			int imin = 0, jmin = 0;
			int imax = 0, jmax = 0;

			for (int i = 0; i < arrayFinal.GetUpperBound(0) + one; i++)
			{
				for (int j = 0; j < arrayFinal.GetUpperBound(1) + one; j++)
				{
					if (arrayFinal[i, j] < minFinal)//находим мин
					{
						minFinal = arrayFinal[i, j];
						imin = i;
						jmin = j;
					}
					if (arrayFinal[i, j] > maxFinal)//находим макс
					{
						maxFinal = arrayFinal[i, j];
						imax = i;
						jmax = j;
					};
				}
			}

			//Создадим одномерный массив копируя и вставляя элементы с двумерного,
			//для того чтобы узнать сумму между мин и макс элементом

			int[] arrayTemp = new int[(arrayFinal.GetUpperBound(0) + one) * (arrayFinal.GetUpperBound(1) + one)];
			int elementTemp = 0;

			for (int i = 0; i < arrayFinal.GetUpperBound(0) + one; i++)
			{
				for (int j = 0; j < arrayFinal.GetUpperBound(1) + one; j++)
				{
					arrayTemp[elementTemp] = arrayFinal[i, j];
					elementTemp++;
				}
			}

			//нахождение мин и макс у одномерного
			int minTemp = 0, maxTemp = 0;
			Console.WriteLine("\nЭлементы между мин и макс: ");
			for (int i = 0; i < (arrayFinal.GetUpperBound(0) + one) * (arrayFinal.GetUpperBound(1) + one); i++)
			{
				if (arrayTemp[i] == minFinal) { minTemp = i; }
				if (arrayTemp[i] == maxFinal) { maxTemp = i; }
			}
			//нахождение суммы между мин и макс
			for (int i = 0; i < (arrayFinal.GetUpperBound(0) + one) * (arrayFinal.GetUpperBound(1) + one); i++)
			{
				if (minTemp <=maxTemp && i>=minTemp && i<=maxTemp)
				{
					sumFinal += arrayTemp[i];
					Console.Write(arrayTemp[i]);
					Console.Write(" ");
				}
				if (minTemp >= maxTemp && i <= minTemp && i >= maxTemp)
				{
					sumFinal += arrayTemp[i];
					Console.Write(arrayTemp[i]);
					Console.Write(" ");
				}
			}

			string finaResult = $"\n\nминимум = {minFinal}, координаты (x,y) = ({jmin},{imin})" +
				$"\nмаксимум = {maxFinal}, координаты (x,y) = ({jmax},{imax})" +
				$"\nсумма между ними = {sumFinal}";
			Console.Write(finaResult);

			Console.ReadKey();
		}
	}
}
