﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class FreePatient : Patient, IPatientType
    {
        public static double treatmentCost { get; set; } = 0;
        public void GetDetails()
        {

        }
    }
}