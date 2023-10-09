﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.DbSet
{
    public class Driver :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

    }
}
