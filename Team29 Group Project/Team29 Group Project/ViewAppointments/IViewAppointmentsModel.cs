﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    public interface IViewAppointmentsModel
    {
        DataTable getAppointmentsList(DateTime date);
        void generateCSVFile();
    }
}