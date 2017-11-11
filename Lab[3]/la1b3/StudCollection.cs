using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	class StudentCollection : Student
	{
		private List<Student> Student;


		public StudentCollection()
		{
			Student = new List<Student>();
		}
		public void AddDefault()
		{
			Console.Write("Namber Student Default:");
			int namber = Convert.ToInt32(Console.ReadLine());
			Student stud1 = new Student();
			int i = 0;
			while (i < namber)
			{
				stud1._DateStudent = new Person("Default1", "Default1", DateTime.MinValue);
				stud1._Education = Education.Master;
				stud1._NamberGrup = 100;
				Examp Ex1 = new Examp("Examp1", 5, DateTime.MinValue);
				Examp Ex2 = new Examp("Examp2", 5, DateTime.MinValue);
				Test Ts1 = new Test("Test1", true);
				Test Ts2 = new Test("Test2", true);
				Test Ts3 = new Test("Test", true);
				stud1._InformatoinExamp.Add(Ex1);
				stud1._InformatoinExamp.Add(Ex2);
				Student.Add(stud1);
				i++;
			}

		}

		public void AddStudent(params Student[] Stud)
		{
			Console.WriteLine("Counting:{0}",Stud.Count());
			Console.ReadLine();
			foreach (Student stud in Stud)
			{
				Student.Add(stud);
			}
		}

		public override string ToString()
		{
			string res = "";
			foreach (Student stud in Student)
				res += stud.ToString() + "\n" +
				"---------------------" + "\n";
			return  res;
		}

		public override string ToShortString()
		{
			string res = "";
			foreach (Student stud in Student)
				res += stud.ToShortString() + "Count Examp:" + stud._InformatoinExamp.Count + "Count Test" + stud._InformationTest.Count + '\n';
			return res;
		}
		public void SortName()
		{
			Student.Sort();
		}

		public void SortEverage()
		{
		   Student.Sort(new Comparer());
		}

		public void SortDate()
		{
			Student.Sort( new Person());
		}



		public double ReadEvarageMax
		{
			get
			{
				if (Student == null)
					return 0;
				return Student.Max(Student => Student.Everage);
			}
		}
		public IEnumerable<Student> EducationMaster
		{
			get
			{
				var master = from student in Student
							 where student._Education == Education.Master
							 select student;
			
				return master.ToList();

			}
		}

		public List<Student> AverageMarkGroup(double value)
		{
			var stud = from student in Student
						 where student.Everage == value
					     select student;
			return stud.ToList();
		}
	}
}
