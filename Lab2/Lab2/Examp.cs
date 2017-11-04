using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{



	class Examp : IDateAndCopy
	{

		public string subject { get; set; }
		public int? rating { get; set; }
		public System.DateTime? exampDate { get; set; }
		public DateTime date
		{
			get { return date; }
			set { date = value; }
		}

		public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Examp(string subject1, int rating1, System.DateTime exampDate1)
		{
			subject = subject1;
			rating = rating1;
			exampDate = exampDate1;
		}

		public Examp()
		{
			subject = null;
			rating = null;
			exampDate = null;

		}

		public override string ToString()
		{
			return '\n' + "Name Subject: " + subject + '\n' + "Rating: " + rating + '\n' + "Date: " + exampDate + '\n';
		}


		//2------------------------------------------------------------------------------------------------------------------------------------->

		public virtual object DeepCopy()
		{
			Examp Ex = new Examp();
			Ex.subject = this.subject;
			Ex.rating = this.rating;
			Ex.exampDate = this.exampDate;

			return Ex;
		}
	}
}
