﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sport_and_Style_LTD.Data
{
    public class Sport
    {
        public int Id { get; set; }
        public string SportName { get; set; }
        public string Description{ get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
