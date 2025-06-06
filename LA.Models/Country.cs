﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<State> states { get; set; } = new HashSet<State>();
    }
}
