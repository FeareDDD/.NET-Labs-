using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Lab4;

namespace lab4
{
	class Student : Person, IDateAndCopy
	{
		private Person DateStudent;
		private Education TeachingStudent;
		private int? NamberGrup;

		private List<Test> InformationTest;
		private List<Examp> InformatoinExamp;
		public DateTime Date
		{
			get { return Date; }
			set { Date = value; }
		}
		public Person _DateStudent
		{
			get { return DateStudent; }
			set { DateStudent = value; }
		}

		public Student(Person Date, Education TeaStud, int NamGrup)
		{
			DateStudent = Date;
			TeachingStudent = TeaStud;
			NamberGrup = NamGrup;
			InformationTest = new List<Test>();
			InformatoinExamp = new List<Examp>();

		}

		public Student()
		{
			DateStudent = null;
			TeachingStudent = 0;
			NamberGrup = null;
			InformationTest = new List<Test>();
			InformatoinExamp = new List<Examp>();
		}
		public Education _Education
		{
			get { return TeachingStudent; }
			set { TeachingStudent = value; }
		}

		public int? _NamberGrup
		{
			get { return NamberGrup; }
			set
			{
				if (value <= 100 || value >= 699) throw new Exception("Пмилка! \n Діапазон значень (100-699) ");
				else NamberGrup = value;
			}
		}


		public List<Examp> _InformatoinExamp
		{
			get { return InformatoinExamp; }
			set { InformatoinExamp = value; }
		}

		public List<Test> _InformationTest
		{
			get { return InformationTest; }
			set { InformationTest = value; }
		}

		public double AverageArithmetic
		{
			get
			{
				double sum = 0;
				foreach (Examp arr in InformatoinExamp)
				{
					sum += Convert.ToDouble(arr);
				}
				return sum / InformatoinExamp.Count;
			}
		}


		public double Everage
		{
			get
			{
				double sum = 0;
				int count = 0;
				foreach (Examp Inf in InformatoinExamp)
				{
					sum += Convert.ToInt32(Inf.Rating);
					count++;
				}

				return sum / count;
			}
		}

		public bool this[Education index]
		{
			get
			{
				if (TeachingStudent == index)
					return true;
				return false;
			}
		}

		public void AddExamp(params Examp[] Student)
		{
			foreach (Examp res in Student)
			{
				InformatoinExamp.Add(res);
			}
		}

		public override string ToString()
		{
			string resExamp = "";
			string resTest = "";
			foreach (Examp arr in InformatoinExamp)
				resExamp += arr + "\n";

			foreach (Test arr in InformationTest)
				resTest += arr + "\n";


			return _DateStudent.ToString() + '\n' + "Education: " + _Education + '\n' + "NamberGrup: " + _NamberGrup + '\n' + "Examp" + '\n' + resExamp + '\n' + "Test" + '\n' + resTest + '\n';
		}


		public virtual string ToShortString()
		{

			return _DateStudent.ToString() + '\n' + "Education: " + _Education + '\n' + "NamberGrup: " + _NamberGrup + '\n' + "Examp" + '\n' + "Everage" + Everage + '\n';
		}


		public virtual object DeepCopy()
		{
			Student Stud = new Student();
			Stud.DateStudent = this.DateStudent;
			Stud.TeachingStudent = this.TeachingStudent;
			Stud.NamberGrup = this.NamberGrup;
			Stud.InformationTest = this.InformationTest;
			Stud.InformatoinExamp = this.InformatoinExamp;
			return Stud;
		}

		public IEnumerable GetExampTest()
		{
			for (int i = 0; i < InformatoinExamp.Count; i++)
				yield return "Examen" + InformatoinExamp[i];
			for (int i = 0; i < InformationTest.Count; i++)
				yield return "Zalik" + InformationTest[i];
		}

		public IEnumerable GetExampParams(int count)
		{
			foreach (Examp stud in InformatoinExamp)
				if (stud.Rating > count)
					yield return stud;
		}
	}
}
