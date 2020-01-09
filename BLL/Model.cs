using System;
using System.Collections.Generic;

namespace BLL
{
	public class Employee
	{
		public Guid ID { get; set; }
		public string Name { get; set; }
		public Genders Gender { get; set; }
		public string Adderss { get; set; }
		public Guid DepartmentID { get; set; }
		public virtual Department Department { get; set; }
	}

	public enum Genders
	{
		Male,
		Female
	}

	public class Department
	{
		public Guid ID { get; set; }
		public string Name { get; set; }
	}

}
