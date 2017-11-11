using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	class TestCollections
	{
		private List<Person> Key;
		private List<string> NameList;
		private Dictionary<Person, Student> NameDictionariP;
		private Dictionary<string, Student> NameDictionariS;

		public Student Force (int t)
		{

			Student stud = new Student();
			return stud;
		}

	 public TestCollections (int t)
		{
			for (int i = 0; i< t; i++)
			{
				Key.Add(new Person { });
				NameList.Add("");
				NameDictionariP.Add(new Person { }, new Student { });
				NameDictionariS.Add("", new Student { });
			}

		}


	}
}
