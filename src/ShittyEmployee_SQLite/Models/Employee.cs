﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShittyEmployee_SQLite.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public string Supervisor { get; set; }
        public int Employed { get; set; }
    }
}
