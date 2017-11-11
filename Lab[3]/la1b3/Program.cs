using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			StudentCollection Stud = new StudentCollection();
			Student stud1 = new Student();

			stud1._DateStudent = new Person("Test", "Student", new DateTime(1997, 11, 11));
			stud1._Education = Education.SecondEducation;
			stud1._NamberGrup = 402;
			Examp Ex1 = new Examp("Math", 3, new DateTime(2017, 12, 11));
			Examp Ex2 = new Examp("Programing", 5, new DateTime(2017, 12, 24));
			Test Ts1 = new Test("Art", true);
			Test Ts2 = new Test("Music", true);
			Test Ts3 = new Test("Science", false);

			stud1._InformatoinExamp.Add(Ex1);
			stud1._InformatoinExamp.Add(Ex2);

			stud1._InformationTest.Add(Ts1);
			stud1._InformationTest.Add(Ts2);
			stud1._InformationTest.Add(Ts3);

			Stud.AddStudent(stud1);

			stud1 = new Student();
			stud1._DateStudent = new Person("Roma", "Baglay", new DateTime(2010, 6, 10));
			stud1._Education = Education.Baxhelor;
			stud1._NamberGrup = 402;
			 Ex1 = new Examp("Math", 5, new DateTime(2017, 12, 11));
			 Ex2 = new Examp("Programing", 5, new DateTime(2017, 12, 24));
			 Ts1 = new Test("Art", true);
			 Ts2 = new Test("Music", true);
			 Ts3 = new Test("Science", false);
			stud1._InformatoinExamp.Add(Ex1);
			stud1._InformatoinExamp.Add(Ex2);

			stud1._InformationTest.Add(Ts1);
			stud1._InformationTest.Add(Ts2);
			stud1._InformationTest.Add(Ts3);

			Stud.AddStudent(stud1);

			stud1 = new Student();
			stud1._DateStudent = new Person("Misha", "Fasolya", new DateTime(1996, 11, 27));
			stud1._Education = Education.Master;
			stud1._NamberGrup = 402;
			Ex1 = new Examp("Math", 3, new DateTime(2017, 12, 11));
			Ex2 = new Examp("Programing", 3, new DateTime(2017, 12, 24));
			Ts1 = new Test("Art", true);
			Ts2 = new Test("Music", true);
			Ts3 = new Test("Science", false);

			stud1._InformatoinExamp.Add(Ex1);
			stud1._InformatoinExamp.Add(Ex2);

			stud1._InformationTest.Add(Ts1);
			stud1._InformationTest.Add(Ts2);
			stud1._InformationTest.Add(Ts3);

		
			Console.WriteLine("------------------------------------------ StudentColections");
			Stud.AddStudent(stud1);
			Console.WriteLine(Stud.ToString());

			Console.WriteLine("------------------------------------------ SortName");
			Stud.SortName();
			Console.WriteLine(Stud.ToString());
			Console.WriteLine("------------------------------------------ SortDate");
			Stud.SortDate();
			Console.WriteLine(Stud.ToString());
			Console.WriteLine("------------------------------------------ SortEverage");
			Stud.SortEverage();
			Console.WriteLine(Stud.ToString());
			Console.WriteLine("------------------------------------------ LINQInquiries");
			Console.WriteLine("---------- MaxAverageStudent");
			Console.WriteLine("Max:{0}", Stud.ReadEvarageMax);
			Console.WriteLine("---------- Education.Master");
			foreach (var str in Stud.EducationMaster)
				Console.WriteLine(str+ "\n---------------------");
			Console.WriteLine("----------> GroupingStudentAverage");
			foreach (var str in Stud.AverageMarkGroup(5))
				Console.WriteLine(str+ "\n---------------------");
			Console.WriteLine("------------------------------------------ SearchCollections");

			Console.ReadLine();
		}
	}
}
