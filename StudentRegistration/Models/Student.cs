using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
	public class Student
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int CellPh { get; set; }
		public int age { get; set; }


		public static string SetPhoneNumberWithDashes(string CellPh)
		{
			if (string.IsNullOrWhiteSpace(CellPh) || !Regex.IsMatch(CellPh, @"^\d+$"))
			{
				return string.Empty;
			}

			if (CellPh.Length == 12 && CellPh.Substring(3, 1) == "-" && CellPh.Substring(7, 1) == "-")
			{
				return CellPh;
			}

			if (CellPh.Length == 10)
			{
				return string.Format("{0:###-###-####}", CellPh);
			}

			return string.Empty;
		}
	}
}
