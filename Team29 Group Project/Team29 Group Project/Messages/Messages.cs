﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team29_Group_Project
{
    public partial class Messages : Form, IMessagesGUI
    {
        int patientID;
        int appointmentID;

        private MessagesPresenter presenter;
        public Messages(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }
        private void Messages_Load(object sender, EventArgs e)
        {
            presenter.getDetaisl(patientID);
        }
        
        public void setAppID(int appID)
        {
            appointmentID = appID;
        }

        public void setName(string name)
        {
            txt_patientName.Text = name;
            txt_patientName.ReadOnly = true;
        }

        public void setAppDate(DateTime date)
        {
            txt_appointmentDate.Text = date.ToString();
            txt_appointmentDate.ReadOnly = true;
        }

        public void setAppTime(TimeSpan time)
        {
            txt_appointmentTime.Text = time.ToString();
            txt_appointmentTime.ReadOnly = true;
        }

        private void btn_invalid_Click(object sender, EventArgs e)
        {
            string value = "Invalid";
            presenter.updateTable(appointmentID, value);
            bool repeatOffence = presenter.checkForRepeatOffence(patientID);
            if (repeatOffence == true)
            {
                MessageBox.Show("Patient needs to be removed");
            }
            else
            {
                this.Close();
            }

        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            string value = "Valid";
            presenter.updateTable(appointmentID, value);
            this.Close();
        }

        

        public void Register(MessagesPresenter MP)
        {
            presenter = MP;
        }
    }
}