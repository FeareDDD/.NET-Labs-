using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class Program
	{
		static void Main(string[] args)
		{
			StudentCollection stud_ob1 = new StudentCollection();
			StudentCollection stud_ob2 = new StudentCollection();
			Journal ob1 = new Journal();
			Journal ob2 = new Journal();

			
			stud_ob1.StudentCountChanged += ob1.Stud_StudentCountChanged;
			stud_ob1.StudentReferenceChanged += ob1.Stud_StudentReferenceChanged;

			stud_ob1.StudentCountChanged += ob2.Stud_StudentCountChanged;
			stud_ob1.StudentReferenceChanged += ob2.Stud_StudentReferenceChanged;

			stud_ob2.StudentCountChanged += ob2.Stud_StudentCountChanged;
			stud_ob2.StudentReferenceChanged += ob2.Stud_StudentReferenceChanged;

			 Student stud1 = new Student();
			 stud1._DateStudent = new Person("CCCC", "uuu", new DateTime(1997, 5, 21));
			 stud1._Education = Education.SecondEducation;
			 stud1._NamberGrup = 402;
			 Examp Ex1 = new Examp("Matan", 3, new DateTime(2017, 12, 11));
			 Examp Ex2 = new Examp("Programing", 5, new DateTime(2017, 12, 24));
			 Test Ts1 = new Test("DiscritLogic", true);
			 Test Ts2 = new Test("MatLogic", true);
			 Test Ts3 = new Test("Algebra", false);

			 stud1._InformatoinExamp.Add(Ex1);
			 stud1._InformatoinExamp.Add(Ex2);

			 stud1._InformationTest.Add(Ts1);
			 stud1._InformationTest.Add(Ts2);
			 stud1._InformationTest.Add(Ts3);

			stud_ob1.AddStudent(stud1);

			stud_ob1.AddDefault(10);

			stud_ob1.Remove(1);
			stud_ob1.Remove(3);

			stud_ob1[1] = stud1 ;


			stud1 = new Student();
			stud1._DateStudent = new Person("CCCC", "uuu", new DateTime(1997, 5, 21));
			stud1._Education = Education.SecondEducation;
			stud1._NamberGrup = 402;
			 Ex1 = new Examp("Matan", 3, new DateTime(2017, 12, 11));
			 Ex2 = new Examp("Programing", 5, new DateTime(2017, 12, 24));
			 Ts1 = new Test("DiscritLogic", true);
			 Ts2 = new Test("MatLogic", true);
			 Ts3 = new Test("Algebra", false);

			stud1._InformatoinExamp.Add(Ex1);
			stud1._InformatoinExamp.Add(Ex2);

			stud1._InformationTest.Add(Ts1);
			stud1._InformationTest.Add(Ts2);
			stud1._InformationTest.Add(Ts3);

			stud_ob2.AddStudent(stud1);

			stud_ob2.AddDefault(7);

			stud_ob2.Remove(2);
			stud_ob2.Remove(5);

			stud_ob2[2] = stud1;

			Console.WriteLine("----------------------------------1");
			Console.WriteLine(ob1.ToString());
			Console.WriteLine("----------------------------------2");
			Console.WriteLine(ob2.ToString());


			Console.ReadLine();

		}


	}
}
