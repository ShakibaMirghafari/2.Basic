﻿namespace جلسه_دوم
{
	class Program
	{
		//---- از کاربر میپرسد میخواهید کلمه ی Hello World چندبار نمایش داده شود.
		static void Main(string[] args)
		{
			//System.Console.Write("How Many Times Do You Want To See Hello World! ");
			//string countString = System.Console.ReadLine();
			//int Count = System.Convert.ToInt32(countString);

			////int indext = 1;
			////while (indext<=Count)
			////{
			////	System.Console.WriteLine("Hello, World!");
			////	indext++;
			////}

			////for (int index = 1; index <= Count; index++)
			////{
			////	System.Console.WriteLine(" Hello, World! ");
			////}

			//for (int index = 1; index <=Count; index++)
			//{
			//	string message = $"[{index}] : Hello World! ";
			//	System.Console.WriteLine(message);
			//}
			//System.Console.ReadLine();

			//------- از کاربر میپرسد میخواهید چندتا عدد وارد کنید؟ سپس کاربر اعداد  خود را وارد میکند و در نهایت اعداد با هم جمع میشوند و در متغیر SUM نمایش داده میشوند
			//System.Console.Write("How Many Number Do You Have: ");
			//string numstring = System.Console.ReadLine();
			//int num = System.Convert.ToInt32(numstring);

			//int sum = 0;
			//for (int index = 1; index <= num; index++)
			//{
			//	string message = $"[{index}]:";
			//	System.Console.Write(message);

			//	string numberstr = System.Console.ReadLine();
			//	int number = System.Convert.ToInt32(numberstr);

			//	sum = sum + number;
			//}

			//string result =
			//	$"The Sum of These Numbers is {sum}";
			//System.Console.WriteLine(result);
			//System.Console.ReadLine();

			//----------------;کد زیر اعداد بین 1 تا 20 را نمایش میدهد.
			//	int x = 1;

			//	loop1:

			//	if (x<20)
			//	{
			//		System.Console.WriteLine(x);

			//		x++;

			//		goto loop1;
			//	}
			//	System.Console.WriteLine("Done");
			//	System.Console.ReadLine();

			//------------از کاربر میپرسیم چندتا عدد دارد بعد ار ینکه اعلام کرد اعداد ر از او میپرسیم و در آرایه ذخیره یکنیم

			System.Console.Write("How Many Number Do You Have Number? ");

			string numberstring = System.Console.ReadLine();
			int numberint = System.Convert.ToInt32(numberstring);

			int[] numbers = new int [numberint];

			for (int index = 0; index <= numberint-1; index++)
			{
				string message = $"[{index +1}]: ";
				System.Console.Write(message);

				string numstr = System.Console.ReadLine();
				int numint = System.Convert.ToInt32(numstr);

				numbers[index] = numint;
			}

			for (int index = 0; index <= numberint-1; index++)
			{
				string message = $"[{index + 1}] = {numbers[index]}";
				System.Console.WriteLine(message);
			}

			System.Console.ReadLine();
		}
	}
}
 