using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class JournalEnty
	{
		public string student { get; set; }
		public string TypeChangeCollections { get; set; }
		public Student ObjectChang { get; set; }

		public JournalEnty()
		{
			student = null;
			TypeChangeCollections = null;
			ObjectChang = null;
		}
		public override string ToString()
		{
			return "TypeChangeCollectios:" + TypeChangeCollections ;
		}
	}
}
