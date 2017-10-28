using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab.Net
{
	class Student
	{
		private Person datestudent;
		private Education teachingStudent;
		private int? namberGrup;
		private Example[] informationStudent;


		public Person DateStudent
		{
			get { return datestudent; }
			set { datestudent = value; }
		}

		public Education Education
		{
			get { return teachingStudent; }
			set { teachingStudent = value; }
		}

		public int? NamberGrup
		{
			get { return namberGrup; }
			set { namberGrup = value; }
		}

		public Example[] InformationStudent
		{
			get { return informationStudent; }
			set { informationStudent = value; }
		}


		private double Everage
		{
			get
			{
				double sum = 0;
				int count = 0;
				foreach (Example Inf in InformationStudent)
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
				return teachingStudent == index;
			}
		}

		public void AddExamp(params Example[] Student)
		{
			if (InformationStudent == null)
			{
				InformationStudent = Student;
			}
			else
			{
				Example[] InSt = new Example[InformationStudent.Length + Student.Length];
				int i = 0;
				while (i < InformationStudent.Length)
				{
					InSt[i] = InformationStudent[i];
					i++;
				}
				int j = 0;
				while (j < Student.Length)
				{
					InSt[i] = Student[j];
					i++;
					j++;
				}
				InformationStudent = InSt;
			}
		}

		public override string ToString()
		{
			string res = "";
			int i = 0;
			if (InformationStudent != null)
			{
				while (i < InformationStudent.Length)
				{
					res += InformationStudent[i].ToString() + "\n";
					i++;
				}
			}
			return DateStudent.ToString() + '\n' + "Education: " + Education + '\n' + "Group numb: " + NamberGrup + '\n' + res + '\n';
		}

		public virtual string ToShortString()
		{
			string result = "Student date" + DateStudent + "\n" + "Student teach" + teachingStudent + "\n" + "Group numb" + NamberGrup + "\n" +
				"Student info" + InformationStudent + "\n";

			return result;
		}

		public Student(Person dateStudent, Education teachingStudent, int nameGrup)
		{
			DateStudent = dateStudent;
			teachingStudent = teachingStudent;
			namberGrup = nameGrup;
		}

		public Student()
		{
			DateStudent = null;
			teachingStudent = 0;
			namberGrup = null;
			InformationStudent = null;
		}

	}
}
