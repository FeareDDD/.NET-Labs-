using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Person : IDateAndCopy
	{
		public DateTime date
		{
			get { return date; }
			set { date = value; }
		}
		protected string name;
		protected string surName;
		protected System.DateTime dat;


		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string SurName
		{
			get { return surName; }
			set { surName = value; }
		}

		public System.DateTime Dat
		{
			get { return dat; }
			set { dat = value; }
		}

		public int Year
		{
			get
			{
				return dat.Year;
			}

			private set
			{
				dat = new DateTime(value, dat.Month, dat.Day);
			}
		}

		public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Person(string name1, string surName1, System.DateTime date1)
		{
			name = name1;
			surName = surName1;
			dat = date1;

		}

		public Person()
		{
			name = "";
			surName = "";
			dat = new DateTime(1977, 1, 1);
		}

		public Person(Person person)
		{
			name = person.name;
			surName = person.surName;
			dat = person.dat;
		}


		public override string ToString()
		{
			return "SurName:" + SurName + '\n' + "Name: " + Name + '\n' + "Date: " + Dat + '\n';
		}

		public virtual string ToShortString()
		{
			return "SurName: " + SurName + '\n' + "Name: " + Name + '\n';
		}


		//2------------------------------------------------------------------------------------------------------------------------------------->
		// fix it
		public static bool operator ==(Person obj1, Person obj2)
		{
				return obj1.Name == obj2.Name && obj1.SurName == obj2.SurName && obj1.Dat == obj2.Dat;
		}

		public static bool operator !=(Person obj1, Person obj2)
	    {
			return obj1.Name != obj2.Name || obj1.SurName != obj2.SurName || obj1.Dat != obj2.Dat;
		}


		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();

		}

		public override bool Equals(object obj)
		{
			Person m = obj as Person;
			return this == m;
		}

		public virtual object DeepCopy()
		{
			Person CopiE = new Person();
			CopiE.name = this.name;
			CopiE.surName = this.surName;
			CopiE.dat = this.dat;
			return CopiE;
		}



	}

}
