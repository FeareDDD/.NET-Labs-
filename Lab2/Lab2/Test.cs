using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Test
	{
		public string subject { get; set; }
		public bool testYesNo { get; set; }

		public Test (string subject1, bool test1)
		{
			subject = subject1;
			testYesNo = test1;
		}

		public Test()
		{
			subject = "----";
			testYesNo = false;
		}

		public override string ToString()
		{
			return "Subject: " + subject + '\n' + "Test(Yes/No): " + testYesNo + '\n';
		}
	}
}
