﻿using System;
namespace BusinessLayer.Model.Models
{
	public class EmployeeInfo : EmployeeBaseInfo
	{
        public string EmployeeName { get; set; }
        public string Occupation { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public DateTime LastModified { get; set; }
    }
}

