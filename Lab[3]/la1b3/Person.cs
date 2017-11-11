using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	class Person : IComparable, IComparer<Person>
	{
		public DateTime Date
		{
			get { return Date; }
			set { Date = value; }
		}
		protected string Name;
		protected string SurName;
		protected System.DateTime Dat;


		public string _Name
		{
			get { return Name; }
			set { Name = value; }
		}

		public string _SurName
		{
			get { return SurName; }
			set { SurName = value; }
		}

		public System.DateTime _Dat
		{
			get { return Dat; }
			set { Dat = value; }
		}

		public int Year
		{
			get
			{
				return Dat.Year;
			}

			private set
			{
				Dat = new DateTime(value, Dat.Month, Dat.Day);
			}
		}

		public int ConpareTo { get => ConpareTo; set => conpareTo = value; }
		public int conpareTo { get; private set; }

		public Person(string name, string surName, System.DateTime date)
		{
			Name = name;
			SurName = surName;
			Dat = date;

		}

		public Person()
		{
			Name = "";
			SurName = "";
			Dat = new DateTime(1977, 1, 1);
		}

		public Person(Person person)
		{
			Name = person.Name;
			SurName = person.SurName;
			Dat = person.Dat;
		}


		public override string ToString()
		{
			return "SurName:" + _SurName + '\n' + "Name: " + _Name + '\n' + "Date: " + _Dat + '\n';
		}

		public virtual string ToShortString()
		{
			return "SurName: " + _SurName + '\n' + "Name: " + _Name + '\n';
		}

		public static bool operator ==(Person obj1, Person obj2)
		{
			if (System.Object.ReferenceEquals(obj1, obj2))
				return true;
			return false;
		}

		public static bool operator !=(Person obj1, Person obj2)
		{

			if (System.Object.ReferenceEquals(obj1, obj2))
				return false;
			return true;
		}


		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();

		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			Person m = obj as Person;
			if (m as Person == null)
				return false;
			return this._Name == m._Name && this._SurName == m._SurName && this._Dat == m._Dat;

		}

		public virtual object DeepCopy()
		{
			Person CopiE = new Person();
			CopiE.Name = this.Name;
			CopiE.SurName = this.SurName;
			CopiE.Dat = this.Dat;
			return CopiE;
		}

		public int CompareTo(object obj)
		{
			Student m1 = this as Student;
			Student m2 = obj as Student;
			Console.WriteLine(m1._DateStudent._SurName.Count());
			Console.WriteLine(m2._DateStudent._SurName.Count());
			if (m1._DateStudent._SurName.Count() > m2._DateStudent._SurName.Count())
				return 1;
			if (m1._DateStudent._SurName.Count() < m2._DateStudent._SurName.Count())
				return -1;
			else return 0;

		}

		public int Compare(Person x1, Person y1)
		{
			Student x = x1 as Student;
			Student y = y1 as Student; 
			if (x._DateStudent._Dat < y._DateStudent._Dat)
				return 1;
			if (x._DateStudent._Dat > y._DateStudent._Dat)
				return -1;
			else return 0;
		}
	}
}
