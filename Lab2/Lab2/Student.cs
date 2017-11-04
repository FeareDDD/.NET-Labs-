using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab2
{
	class Student : Person, IDateAndCopy
	{
		private Person dateStudent;
		private Education teachingStudent;
		private int? namberGrup;

		private ArrayList   informationTest;
		private ArrayList  informatoinExamp; 
		public DateTime Date
		{
			get { return Date; }
			set { Date = value; }
		}
		public Person DateStudent
		{
			get { return dateStudent; }
			set { dateStudent = value; }
		}

	 public Student (Person Date, Education TeaStud, int NamGrup)
		{
			dateStudent = Date;
			teachingStudent = TeaStud;
			namberGrup = NamGrup;
			informationTest = new ArrayList();
			informatoinExamp = new ArrayList();

		}

		public Student()
		{
			dateStudent = null;
			teachingStudent = 0;
			namberGrup = null;
			informatoinExamp = new ArrayList();
			informationTest = new ArrayList();

		}
		public Education Education
		{
			get { return teachingStudent; }
			set { teachingStudent = value; }
		}

		public int? NamberGrup
		{
			get { return namberGrup; }
			set { if (value <= 100 || value >= 699) throw new Exception("Пмилка! \n Діапазон значень (100-699) ");
				else namberGrup = value;
			}
		}


		public double AverageArithmetic
		{
			get
			{
				double sum = 0;
				foreach (ArrayList arr in informatoinExamp)
				{
					sum += Convert.ToDouble( arr);
				}
				return sum / informatoinExamp.Count;
			}
		}

		public ArrayList InformatoinExamp
		{
			get { return informatoinExamp; }
			set { informatoinExamp = value ; }
		}

		public ArrayList InformationTest
		{
			get { return informationTest; }
			set { informationTest = value; }
		}

		public ArrayList InformationSubject
		{
			get { return informatoinExamp; }
			set { informatoinExamp = value; }
		}



		private double Everage
		{
			get
			{
				double sum = 0;
				int count = 0;
				foreach (Examp Inf in informatoinExamp)
				{
					sum += Convert.ToInt32(Inf);
					count++;
				}

				return sum / count;
			}
		}

		public bool this[Education index]
		{
			get
			{
				if (teachingStudent == index)
					return true;
				return false;
			}
		}

		public void AddExamp(params Examp[] Student)
		{
				informatoinExamp.Add(Student);
		}

		public override string ToString()
		{
			string resExamp = "";
			string resTest = "";
			foreach (Examp arr in informatoinExamp)
					resExamp += arr + "\n" ;

			foreach (Test arr in informationTest)
				resTest += arr + "\n";
			

			return DateStudent.ToString() + '\n' + "Education: " + Education + '\n' + "NamberGrup: " + NamberGrup + '\n' + "Examp" + '\n' + resExamp  + '\n' + "Test" + '\n' + resTest + '\n';
		}


		public virtual string ToShortString()
		{

			return DateStudent.ToString() + '\n' + "Education: " + Education + '\n' + "NamberGrup: " + NamberGrup + '\n' + "Examp" + '\n' + "Everage" + Everage + '\n' ;
		}




		//--------------------------------------------------------------------------------------------------------------------------------->
		public virtual object DeepCopy()
		{
			Student Stud = new Student();
			Stud.dateStudent = this.DateStudent;
			Stud.teachingStudent = this.teachingStudent;
			Stud.namberGrup = this.NamberGrup;
			Stud.informationTest = this.InformationTest;
			Stud.informatoinExamp = this.InformatoinExamp;
			return Stud;
		}

		public IEnumerable GetExampTest()
		{
			for (int i = 0; i < InformatoinExamp.Count; i++)
				yield return "Examen" + InformatoinExamp[i];
			for (int i = 0; i < InformationTest.Count; i++)
				yield return "Zalik" + InformationTest[i];
		}

		public IEnumerable GetExampParams (int count)
		{
			foreach(Examp stud in InformatoinExamp)
				if (stud.rating > count)
					yield return stud;
		}
	
	}
}
