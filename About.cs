﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtMoS3
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeLog myNewForm = new ChangeLog();
            myNewForm.Show();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
