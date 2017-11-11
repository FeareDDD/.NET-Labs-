using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class Test
	{
		public string Subject { get; set; }
		public bool TestYesNo { get; set; }

		public Test(string subect, bool test)
		{
			Subject = subect;
			TestYesNo = test;
		}

		public Test()
		{
			Subject = "----";
			TestYesNo = false;
		}

		public override string ToString()
		{
			return "Subject: " + Subject + '\n' + "Test(Yes/No): " + TestYesNo + '\n';
		}
	}
}
