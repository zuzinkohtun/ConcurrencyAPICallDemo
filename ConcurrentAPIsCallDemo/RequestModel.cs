﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentAPIsCallDemo
{
	public class RequestModel
	{
		public string? From { get; set; }
		public required string To { get; set; }
		public required string Text { get; set; }
	}
}
