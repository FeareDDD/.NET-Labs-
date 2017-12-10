using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5
{
	class Program
	{
		static void Main(string[] args)
		{
			T stud1 = new T();
			stud1._DateStudent = new Person("Test", "Subject", new DateTime(1997, 5, 21));
			stud1._Education = Education.SecondEducation;
			stud1._NamberGrup = 402;
			Examp Ex1 = new Examp("Math", 3, new DateTime(2017, 12, 11));
			Examp Ex2 = new Examp("Programing", 5, new DateTime(2017, 12, 24));
			Test Ts1 = new Test("History", true);
			Test Ts2 = new Test("Logic", true);
			Test Ts3 = new Test("Biology", false);

			stud1._InformatoinExamp.Add(Ex1);
			stud1._InformatoinExamp.Add(Ex2);

			stud1._InformationTest.Add(Ts1);
			stud1._InformationTest.Add(Ts2);
			stud1._InformationTest.Add(Ts3);

		 	T StudCopy = stud1.DeepCopy();
			//1
			Console.WriteLine("---------------->1");
			Console.WriteLine("------------------------------------->Original");
			Console.WriteLine(stud1.ToString());
			Console.WriteLine("------------------------------------->Copy");
			Console.WriteLine(StudCopy.ToString());

			Console.WriteLine("file:");
			string filename =  Console.ReadLine()+ ".dat";
			//2
			try
			{
				FileStream fileOpen = new FileStream(filename, FileMode.Open, FileAccess.Write, FileShare.Write);
				fileOpen.Close();
			   Console.WriteLine(stud1.Load(filename));
			}
			catch
			{
				Console.WriteLine("No File");
				FileStream file = new FileStream(filename, FileMode.Create);
				file.Close();
			}
			//3
			Console.WriteLine("---------------->3");
			Console.WriteLine(stud1.ToString());
			//4
			Console.WriteLine("---------------->4");
		    Console.WriteLine(stud1.AddFromConsole());
			Console.WriteLine(stud1.Save(filename));
			Console.WriteLine(stud1.ToString());
			//5
			T test = new T();
			Console.WriteLine("---------------->5");
			Console.WriteLine(T.Load(filename,stud1));
			Console.WriteLine(stud1.AddFromConsole());
			Console.WriteLine(T.Save(filename,stud1));
			//6
			Console.WriteLine("---------------->6");
			Console.WriteLine(stud1.ToString());

			Console.ReadLine();



		}
	}
}
