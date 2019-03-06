using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails.Models
{
	public class Student
	{
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public int StuID { get; set; }
		public string Email { get; set; }
		public int Id { get; internal set; }
	}
}
