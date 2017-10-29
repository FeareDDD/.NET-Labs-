using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab.Net
{
	class Example
	{

		public string subject { get; set;}
		public int? rating { get; set; }
		public System.DateTime? exampDate { get; set; }
		public Example (string subjectt, int ratingg, System.DateTime exampDatee)
		{
			subject = subjectt;
			rating = ratingg;
			exampDate = exampDatee;
		}

		public Example()
		{
			subject = null;
			rating = null;
			exampDate = null;
		}

		public override string ToString()
		{
			return '\n' + "Name Subject: " + subject + '\n' + "Rating: " + rating + '\n' + "Date: " + exampDate + '\n';
		}



	}
}
