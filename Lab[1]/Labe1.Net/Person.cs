using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab.Net
{
	class Person 
	{
		private string name;
		private string surname;
		private System.DateTime date;


		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string SurName
		{
			get { return surname; }
			set { surname = value; }
		}

		public System.DateTime Date
		{
			get { return date; }
			set { date = value; }
		}

		public int Year
		{
			get
			{
				return date.Year;
			}

			private set
			{
				date = new DateTime(value, date.Month, date.Day);
			}
		}

		public Person (string name, string surname, System.DateTime date)
		{
			Name = name;
			SurName = surname;
			Date = date;

		}

		public Person()
		{
			Name = string.Empty;
			SurName = string.Empty;
			Date = new DateTime(1977, 1, 1);
		}
         
		public Person (Person person)
		{
			Name = person.Name;
			SurName = person.SurName;
			Date = person.Date;
		}


		public override string ToString()
		{
			return  "surname:" + SurName + '\n' + "Name: " + Name + '\n'+ "Date: " + Date + '\n';
		}

		public virtual string ToShortString()
		{
			return "SurName: " + SurName + '\n' + "Name: " +  Name + '\n';
		}
		



	}

}
