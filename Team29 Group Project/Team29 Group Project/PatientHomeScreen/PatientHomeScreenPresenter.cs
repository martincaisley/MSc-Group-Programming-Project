﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class PatientHomeScreenPresenter
    {
        private PatientHomeScreenModel patientModel;
        private IPatientHomeScreenGUI patientScreen;

        public PatientHomeScreenPresenter(IPatientHomeScreenGUI patientScreen)
        {
            this.patientScreen = patientScreen;
            patientScreen.Register(this);
            patientModel = new PatientHomeScreenModel();
            initialiseForm();
        }
        private void initialiseForm()
        {
            processPatientsList();
        }
        public void processPatientsList()
        {
            DataTable dt = patientModel.getPatientsDT();
            if (dt.Rows.Count != 0)
            {
                patientScreen.setDGV(dt);
            }
            else
            {
                patientScreen.noPatientsToShow();
            }
        }
        public void rowSelcted(int index)
        {
            patientScreen.viewPatient(index);
        }
        public void deleteRow(int appointmentID)
        {
            patientModel.deleteEntry(appointmentID);
            processPatientsList();
        }

    }
}
