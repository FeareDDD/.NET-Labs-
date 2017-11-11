using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class StudentListHandlerEventArgs : EventArgs
	{
		public string student { get; set; }
		public string TypeChangeCollections { get; set; }
		public Student ObjectChang { get; set; }

		public StudentListHandlerEventArgs()
		{
			student = null;
			TypeChangeCollections = null;
			ObjectChang = null;
		}

		public override string ToString()
		{
			return "Student: " + student + "\n" + "TypeChangeCollectios:" + TypeChangeCollections + "\n" + "ObjectChang" + ObjectChang;
		}

		public static implicit operator List<object>(StudentListHandlerEventArgs v)
		{
			throw new NotImplementedException();
		}
	}
}
