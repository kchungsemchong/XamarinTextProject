﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class ToDoItem
	{
		public string TaskName { get; set; }
		public string Priority { get; set; }
		public DateTime DueDate { get; set; }
		public bool IsDeleted { get; set; }


		public ToDoItem(string taskName, string priority, DateTime dueDate, bool isDeleted)
		{
			TaskName = taskName;
			Priority = priority;
			DueDate = dueDate;
			IsDeleted = isDeleted;
		}
	}
}
