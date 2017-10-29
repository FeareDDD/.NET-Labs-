using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab.Net
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Student Stud = new Student ();
			Console.WriteLine(Stud.ToShortString());
			Console.WriteLine(Stud[Education.Master]);
			Console.WriteLine(Stud[Education.Bachelor]);
			Console.WriteLine(Stud[Education.SecondEducation]);
			Console.WriteLine("----------------- \n");
			Stud.DateStudent = new Person("Test", "Student", new DateTime(1987,8,8));
			Stud.Education = Education.Master;
			Stud.NamberGrup = 5;
			Console.WriteLine(Stud);
			Console.WriteLine("----------------- \n");
          

			Stud.AddExamp(new Example
		    {
		        subject = "Version Control",
				rating = 5,
				exampDate = new DateTime(1910,11,11)
		    }
				         );

			Stud.AddExamp(new Example
			{
				subject = "Programing",
				rating = 4,
				exampDate = new DateTime(2000, 11, 21)
			}
						 );
			Console.WriteLine(Stud);

			Console.WriteLine("Rows and Columbs <,> ");

			string[] nRnC = Console.ReadLine().Split(',');
			int nRows =  Convert.ToInt32(nRnC[0]);
			int nColumns = Convert.ToInt32(nRnC[1]);


			Person[] NameOne = new Person[nRows*nColumns];
			int i = 0;
			int j = 0;
			while (i < NameOne.Length)
			{
				NameOne[i] = new Person();
				i++;
			}
		    i = 0;
			j = 0;

			Person[,] NameTwo = new Person[nRows, nColumns];

		   while (i < nRows)
			{
				while (j < nColumns)
				{
					NameTwo[i,j] = new Person();
					j++;
				}
				j = 0;
				i++;
			}
			int sum = 0;
			 i = 0;
			int dobutok = nRows * nColumns;
			Random rand = new Random();
			int ran = rand.Next(nRows / 2, nRows);
			int ran1 = ran;

			Person[][] Namethree = new Person[ran+1][];
			int R  = rand.Next(1, dobutok - ran);
			int R1 = R;
			j = 0;
			while (i < ran)
			{
				ran1--;
				R1 += R = rand.Next(1, (dobutok - R1)-ran1);
				Namethree[i] = new Person[R];
				while (j < R)
				{
					Namethree[i][j] = new Person();
					j++;
					sum++;
				}
				i++;
				j = 0;
			}
			j = 0;
			Namethree[ran] = new Person[dobutok - sum];
			while (j < dobutok - sum)
			{
				Namethree[ran][j] = new Person();
				j++;
			}


			double start = Environment.TickCount;
			foreach (Person Name1 in NameOne)
				Name1.Name = "AndreOne";
			double stop = Environment.TickCount;
			Console.WriteLine("Time One :{0} second", (stop-start));

			 start = Environment.TickCount;
		for (int ii = 0; ii <  nRows; ii++)
			{
				for (int jj = 0; jj < nColumns; jj++)
				{
					NameTwo[ii, jj].Name = "AndreTwo";
				}
			}
			 stop = Environment.TickCount;
			Console.WriteLine("Time Two:{0} second", (stop - start));

			 start = Environment.TickCount;
			foreach (var Name1 in Namethree)
			{

				foreach (Person Name3 in Name1)
					Name3.Name = "Andrethree";
			}
			 stop = Environment.TickCount;
			Console.WriteLine("time Three:{0} second", (stop - start));

			Console.ReadLine();
		}
	}
}
