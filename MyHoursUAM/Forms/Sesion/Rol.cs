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
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
        }

        private void Rol_Load(object sender, EventArgs e)
        {






















































































        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSesion form = new IniciarSesion();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IniciarSesion form = new IniciarSesion();
            form.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnStudent.FlatAppearance.MouseOverBackColor = Color.Transparent;
            IniciarSesion form = new IniciarSesion();
            form.Show();
            this.Close();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatAppearance.MouseDownBackColor = Color.Teal; 
            btnStudent.FlatAppearance.MouseOverBackColor = Color.Transparent;

            // Lógica del evento
            IniciarSesion form = new IniciarSesion();
            form.Show();
            this.Close();
        }

    }
}
