﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_CabinetMedical
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbOra.Text = DateTime.Now.ToString("hh:mm");
        }
    }
}
