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
    public partial class PhoneReminders : Form, IPhoneRemindersGUI
    {
        private PhoneRemindersPresenter presenter;
        public PhoneReminders()
        {
            InitializeComponent();
        }
        private void PhoneReminders_Load(object sender, EventArgs e)
        {
            //presenter.getPhoneDetails();
        }
        
        public void setPhoneDetails(DataTable dt)
        {
            dgv_phoneReminders.DataSource = dt;
            dgv_phoneReminders.AllowUserToAddRows = false;
            dgv_phoneReminders.AllowUserToDeleteRows = false;
            int cols = dgv_phoneReminders.ColumnCount;
            for (int x = 0; x < cols; x++)
            {
                dgv_phoneReminders.Columns[x].ReadOnly = true;
            }
        }

        private void dgv_phoneReminders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.rowSelcted(Convert.ToInt32(dgv_phoneReminders.CurrentRow.Cells[0].Value.ToString()));
        }

        private void dgv_phoneReminders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.rowSelcted(Convert.ToInt32(dgv_phoneReminders.CurrentRow.Cells[0].Value.ToString()));
        }
        public void viewChosenReminder(int appointmentID)
        {
            ContactedByPhone contactedByPhone = new ContactedByPhone(appointmentID);
            ContactedByPhonePresenter CBPP = new ContactedByPhonePresenter(contactedByPhone);
            this.Hide();
            contactedByPhone.ShowDialog();
            presenter.getPhoneDetails();
            this.Show();
        }

        public void Register(PhoneRemindersPresenter PRP)
        {
            presenter = PRP;
        }
    }
}
