using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Program
	{
		static void Main(string[] args)
		{
			Student Stud = new Student();
			Person Person1 = new Person("1","1", new DateTime(1,1,1));
			Person SameAsPerson1 = new Person("1", "1", new DateTime(1, 1, 1));
			Person Person2 = new Person("2", "2", new DateTime(1, 1, 1));
			Console.WriteLine("Eguals: {0}", Person1.Equals(Person2));
			Console.WriteLine("GetHachCod1: {0} \nGetHachCod2: {1}", Person1.GetHashCode(), Person2.GetHashCode());
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Student Stud = new Student();
			Stud.DateStudent = new Person("Andre","Jitarju", new DateTime (1997,5,21));
			Stud.Education = Education.Master;
			Stud.NamberGrup = 402;
			Examp Ex1 = new Examp("Matan", 3, new DateTime(2017,12,11));
			Examp Ex2 = new Examp("Programing", 5, new DateTime(2017, 12, 24));
			Test Ts1 = new Test("DiscritLogic",  true);
			Test Ts2 = new Test("MatLogic", true);
			Test Ts3 = new Test("Algebra", false);
			Console.WriteLine("----------------------------------------------------------------------->");
//----------------------------------------------------------------------------------------------------------->

			Console.WriteLine(Person1 == SameAsPerson1);

			Stud.InformatoinExamp.Add(Ex1);
			Stud.InformatoinExamp.Add(Ex2);

			Stud.InformationTest.Add(Ts1);
			Stud.InformationTest.Add(Ts2);
			Stud.InformationTest.Add(Ts3);

			Console.WriteLine(Stud);
			Console.WriteLine(Stud.DateStudent);
			
			Student StudCopi = new Student();
			StudCopi = Stud.DeepCopy() as Student;
			Stud.NamberGrup = 302;
			Console.WriteLine("Original-------->");
			Console.WriteLine(Stud);
			Console.WriteLine("Copi-------->");
			Console.WriteLine(StudCopi);


			try
			{
				Stud.NamberGrup = 99;
			}catch(Exception ex)
			{
				Console.WriteLine("Помилка");
			}


			foreach (Examp param in Stud.GetExampParams(3))
				Console.WriteLine(param);

			Console.ReadLine();
		

		}
	}
}
