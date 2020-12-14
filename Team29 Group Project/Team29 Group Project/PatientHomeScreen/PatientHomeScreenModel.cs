﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class PatientHomeScreenModel
    {
        public DataTable getDT()
        {

            DataTable dt = new DataTable();
            try
            {
                using (var context = new MyDBEntities())
                {
                    var patients = context.Patients.ToList();

                    dt.Columns.Add("Patient Name", typeof(string));
                    dt.Columns.Add("Patient Phone Number", typeof(string));


                    var patientQuery = from p in patients.AsEnumerable()
                                       select dt.LoadDataRow(new object[]
                                       {
                                p.firstName + " " + p.lastName,
                                p.PhoneNum
                                       }, false);

                    patientQuery.CopyToDataTable();


                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Home Screen Exception: " + e.Message);
                //add in exception here
            }
            return dt;
        }
        public int getPatientID(int index)
        {
            using (var context = new MyDBEntities())
            {
                var patients = context.Patients.ToList();
                int NewPatientID = patients[index].PatientID;
                return NewPatientID;
            }
        }
    }
}