using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class Journal
	{

		private List<JournalEnty> ListJournalEntri;
		public Journal()
		{
			ListJournalEntri = new List<JournalEnty>();
		}

		 public  void Stud_StudentCountChanged(object sours, StudentListHandlerEventArgs args)
		{
			JournalEnty res = new JournalEnty ();
			res.ObjectChang = args.ObjectChang;
			res.student = args.student;
			res.TypeChangeCollections = args.TypeChangeCollections;
			ListJournalEntri.Add(res);
		
		}
		public  void Stud_StudentReferenceChanged(object sours, StudentListHandlerEventArgs args)
		{
			JournalEnty res = new JournalEnty();
			res.ObjectChang = args.ObjectChang;
			res.student = args.student;
			res.TypeChangeCollections = args.TypeChangeCollections;
			ListJournalEntri.Add(res);

		}

		public override string ToString()
		{
			string res = "";
			foreach (var str in ListJournalEntri)
				res += "\n" + str.ToString();
			return res;
		}

		private static void Arg_StudentCountChanged(object sours, StudentListHandlerEventArgs args)
		{
			throw new NotImplementedException();
		}
	}
}
