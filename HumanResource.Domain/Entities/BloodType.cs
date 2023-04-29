﻿using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities
{
	public class BloodType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		

		//Navigation Property
		public List<AppUser> Users { get; set; }

		public BloodType()
		{
			Users= new List<AppUser>();
		}
	}
}