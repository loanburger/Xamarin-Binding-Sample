﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SLSNZ.Models
{
	public class Person
	{

		public string FirstName { get; set; }		

		public string LastName { get; set; }

		public string DisplayName { get { return $"{FirstName} {LastName}"; } }

	}
}

