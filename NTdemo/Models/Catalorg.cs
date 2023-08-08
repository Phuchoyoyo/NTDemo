﻿using System;
using System.ComponentModel.DataAnnotations;

namespace NTdemo.Models
{
	public class Catalorg
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public int DisplayOrder { get; set; }

	}
}
