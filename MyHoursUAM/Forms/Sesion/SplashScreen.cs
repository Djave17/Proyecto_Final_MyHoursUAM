﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHours_UAMApp
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           timer1.Enabled = true;
           progressBar.Increment(20);
           if (progressBar.Value == 100 ) {
                timer1.Enabled = false;
                IniciarSesion form = new IniciarSesion();
                form.Show();
                this.Hide();
        }
    }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}

