﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentsAccounting.models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
