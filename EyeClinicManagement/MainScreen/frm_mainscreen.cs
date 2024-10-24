﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeClinicManagement.MainScreen
{
    public partial class frm_mainscreen : Form
    {
        public frm_mainscreen()
        {
            InitializeComponent();
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            Doctor.frm_doctortable form = new Doctor.frm_doctortable();
            form.ShowDialog();
        }

        private void btn_opd_Click(object sender, EventArgs e)
        {
            OPD.frm_opdtable form = new OPD.frm_opdtable();
            form.ShowDialog();
        }
    }
}
