﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    public interface IPatientDetailsGUI
    {
        void setLabel(string patientName);
        void Register(PatientDetailsPresenter PDP);
        void setDGV(DataTable dt);
    }
}