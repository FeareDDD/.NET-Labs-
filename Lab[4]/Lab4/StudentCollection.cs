using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class StudentCollection : Student
	{
		public delegate void StudentListHandler(object sours, StudentListHandlerEventArgs args);
		public string student { get; set; }

		public event StudentListHandler StudentCountChanged;
		public event StudentListHandler StudentReferenceChanged;

		private List<Student> Student;

		public bool Remove(int j)
		{
			StudentListHandlerEventArgs arg = new StudentListHandlerEventArgs();
			if (j>0  && j <= Student.Count)
			{
				arg.student = "Student";
				arg.TypeChangeCollections = "Remove";
				arg.ObjectChang = Student[j-1];
			   if (StudentCountChanged != null)
				StudentCountChanged(this, arg);
				Student.RemoveAt(j-1);
				return true;
			}
			else
				return false;
		}

		public Student this[int i]
		{
			get
			{
				return Student[i];
			}
			set
			{
				if (i > 0 && i <= Student.Count)
				{
					StudentListHandlerEventArgs arg = new StudentListHandlerEventArgs();
					arg.student = "Student";
					arg.TypeChangeCollections = "Substitute";
					arg.ObjectChang = Student[i];
				  if (StudentReferenceChanged != null)
					StudentReferenceChanged(this, arg);
				}
				Student[i] = value;
			}
		}

		public StudentCollection()
		{
			Student = new List<Student>();
		}
		public void AddDefault( int namber)
		{
			StudentListHandlerEventArgs arg = new StudentListHandlerEventArgs();
			Student stud1 = new Student();
			int i = 0;
			int count = Student.Count();
			while (i < namber)
			{
				stud1 = new Student();
				stud1._DateStudent = new Person("Default" + i, "Default" + i, DateTime.MinValue);
				stud1._Education = Education.Master;
				stud1._NamberGrup = 101 + i;
				Examp Ex1 = new Examp("Examp"+  i, 5, DateTime.MinValue);
				Examp Ex2 = new Examp("Examp" +i*2, 5, DateTime.MinValue);
				Test Ts1 = new Test("Test"+ i, true);
				Test Ts2 = new Test("Test"+ i*2, true);
				Test Ts3 = new Test("Test"+ i*3, true);
				stud1._InformatoinExamp.Add(Ex1);
				stud1._InformatoinExamp.Add(Ex2);

				stud1._InformationTest.Add(Ts1);
				stud1._InformationTest.Add(Ts2);
				stud1._InformationTest.Add(Ts3);

				Student.Add(stud1);
				i++;

				arg.student = "Student";
				arg.TypeChangeCollections = "AddDefault";
				arg.ObjectChang = Student[Student.Count-1];
			  if (StudentCountChanged != null)
				StudentCountChanged(this, arg);
			}

		}

		public void AddStudent(params Student[] Stud)
		{

			StudentListHandlerEventArgs arg = new StudentListHandlerEventArgs();
			foreach (Student stud in Stud)
			{
				Student.Add(stud);
				arg.student = "Student";
				arg.TypeChangeCollections = "Add";
				arg.ObjectChang = Student[Student.Count-1];
				StudentCountChanged(this, arg);

			}
		}

		public override string ToString()
		{
			string res = "";
			foreach (Student stud in Student)
				res += stud.ToString() + "\n" +
				"---------------------" + "\n";
			return res;
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
			Student.Sort(new Person());
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
