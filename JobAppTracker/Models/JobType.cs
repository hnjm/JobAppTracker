﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models
{
    public class JobType
    {
        public int TypeID { get; set; }
        public Type Type { get; set; }
    
        public int? ApplicationID { get; set; }
        public Application Application { get; set; }
    }
}
