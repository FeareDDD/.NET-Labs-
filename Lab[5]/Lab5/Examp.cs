using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	[Serializable]
	class Examp
	{
		public string Subject { get; set; }
		public int? Rating { get; set; }
		public System.DateTime? ExampDate { get; set; }
		public DateTime Date
		{
			get { return Date; }
			set { Date = value; }
		}

		public Examp(string subject, int rating, System.DateTime exampDate)
		{
			Subject = subject;
			Rating = rating;
			ExampDate = exampDate;
		}

		public Examp()
		{
			Subject = null;
			Rating = null;
			ExampDate = null;

		}

		public override string ToString()
		{
			return '\n' + "Name Subject: " + Subject + '\n' + "Rating: " + Rating + '\n' + "Date: " + ExampDate + '\n';
		}


		//2------------------------------------------------------------------------------------------------------------------------------------->

		public virtual object DeepCopy()
		{
			Examp Ex = new Examp();
			Ex.Subject = this.Subject;
			Ex.Rating = this.Rating;
			Ex.ExampDate = this.ExampDate;

			return Ex;
		}
	}
}
