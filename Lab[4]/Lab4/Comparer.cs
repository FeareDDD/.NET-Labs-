using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class Comparer: IComparer<Student>
	{
		public int Compare(Student x, Student y)
		{
			if (x.Everage < y.Everage)
				return 1;
			if (x.Everage > y.Everage)
				return -1;
			else return 0;
		}
	}
}
