using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;

namespace Lab5
{
	[Serializable]
     class T : Person, IDateAndCopy
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

		public T(Person Date, Education TeaStud, int NamGrup)
		{
			DateStudent = Date;
			TeachingStudent = TeaStud;
			NamberGrup = NamGrup;
			InformationTest = new List<Test>();
			InformatoinExamp = new List<Examp>();

		}

		public T()
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



		/*	public Person _Person
			{
				get { if (DateStudent == ) }

			}
			*/



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




		//--------------------------------------------------------------------------------------------------------------------------------->


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
		public virtual T DeepCopy()
		{
			T Stud = new T();
			Stud.DateStudent = this.DateStudent;
			Stud.TeachingStudent = this.TeachingStudent;
			Stud.NamberGrup = this.NamberGrup;
			Stud.InformationTest = this.InformationTest;
			Stud.InformatoinExamp = this.InformatoinExamp;
			return Stud;
		}


		// 5 lab
		public bool Save(string filename)
		{
			T Deser = new T();
			BinaryFormatter serealizabl = new BinaryFormatter();
				FileStream fileSerealize = File.Open(filename, FileMode.Open);
				try
				{
					serealizabl.Serialize(fileSerealize, this);
				}
				catch
				{
					Console.WriteLine("Помилка сереалізації !!!!!!");
				}
				fileSerealize.Close();
			FileStream fileDeserealize = File.Open(filename, FileMode.Open);
			try
			{
				Deser = serealizabl.Deserialize(fileDeserealize) as T;
			}
			catch (Exception ex)
			{
				fileDeserealize.Close();
				return false;
			}
			fileDeserealize.Close();
			return true;
		}

		public bool Load(string filename)
		{
			BinaryFormatter Deserializable = new BinaryFormatter();
			FileStream fileDeserializable = File.OpenRead(filename);
			T DateStudent1; ;
			try
			{
				DateStudent1 = Deserializable.Deserialize(fileDeserializable) as T;
				Load(filename, DateStudent1);       //  ДУРНЯ
			}
			catch (Exception ex)
			{
				fileDeserializable.Close();
				return false;
			}
			fileDeserializable.Close();
			return true;
		}

		public static bool Save (string filename, T Object)
		{
			BinaryFormatter serializer = new BinaryFormatter();
			FileStream fileSerealizer = File.Create(filename);
			try
			{
				serializer.Serialize(fileSerealizer, Object);
			}
			catch
			{
				Console.WriteLine("Помилка сереалізації !!!!!!");
			}
			fileSerealizer.Close();
			FileStream fileDeserealizer = File.OpenRead(filename);
			T Object1;
			try
			{
				Object1 = serializer.Deserialize(fileDeserealizer) as T;
			}
			catch
			{
				fileDeserealizer.Close();
				return false;
			}
			fileDeserealizer.Close();
			return true;
		}


		public static bool Load(string filename, T Object)
		{
			BinaryFormatter serializer = new BinaryFormatter();
			FileStream fileDeserialize = File.OpenRead(filename);
			T Object1;
			try
			{
				Object1 = serializer.Deserialize(fileDeserialize) as T;
			}
			catch
			{
				fileDeserialize.Close();
				return false;
			}
			fileDeserialize.Close();
			Object = Object1;
			return true;
		}

		public bool AddFromConsole()
		{
			Console.WriteLine("Введіть дані в один рядок через <,>(Subject,Rating,Year,Month,Day)");
			string str = Console.ReadLine();
			string[] pars;
			try
			{
				 pars = str.Split(',');
				string subject = pars[0];
				int rating = Convert.ToInt32(pars[1].Trim());
				int year = Convert.ToInt32(pars[2].Trim());
				int month = Convert.ToInt32(pars[3].Trim());
				int day = Convert.ToInt32(pars[4].Trim());
				this._InformatoinExamp.Add(new Examp(subject, rating, new DateTime(year, month, day)));
			}
			catch
			{
				Console.WriteLine("Дані введено не коректно !!!!!");
				return false;
			}
			return true;

		}



	}
}
