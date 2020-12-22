﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IAppointmentStatusModel
    {
        string setName(int appointmentID);
        TimeSpan setTime(int appointmentID);
        double setCost(int appointmentID);
        void updateTable(int appointmentID, string appointmentStatus);

    }
}