﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobIn.Application.InputModels
{
    public class UpdateJobInputModel
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public double Salary { get; set; }
    }
}
