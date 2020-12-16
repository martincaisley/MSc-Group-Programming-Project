﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class PatientRegistrationPresenter
    {
        private PatientRegistrationModel model;
        private IPatientRegistrationGUI form;

        public PatientRegistrationPresenter(IPatientRegistrationGUI form)
        {
            this.form = form;
            form.Register(this);
            model = new PatientRegistrationModel();
            
        }

        public void BTN_medQuestionnaire_event()
        {
            MedicalQuestionnaireGUI med = new MedicalQuestionnaireGUI();
            med.Show();
        }

       

        public void ProcessNewPatient()
        {
            String firstName = form.GetFirstname();
            String surname = form.GetSurname();
            DateTime DoB = form.GetDoB();
            String address = form.GetAddress();
            String email = form.GetEmail();
            String phoneNum = form.GetPhoneNumber();
            String occupation = form.GetOccupation();
            String GPname = form.GetGPname();
            String GPaddress = form.GetGPaddress();
            
            if(form.GetPaymentType())
            {
                model.AddFreePatient(firstName, surname, DoB, address, email, phoneNum, occupation, GPname, GPaddress);
        
            }
            else if(!form.GetPaymentType())
            {
                model.AddPayingPatient(firstName, surname, DoB, address, email, phoneNum, occupation, GPname, GPaddress);
            }
            else
            {
                Console.WriteLine("An error has occured, please try again");
            }


        }

    }
}
