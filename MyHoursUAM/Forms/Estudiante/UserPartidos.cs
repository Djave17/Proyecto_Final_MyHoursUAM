﻿using MyHours_UAMApp.Estructuras.Metodos;
using System;
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
    public partial class UserPartidos : Form
    {
        public UserPartidos()
        {
            InitializeComponent();
            CargarPartidosEnListView();

        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
            UserEvento form = new UserEvento();
            form.Show();
            this.Close();
        }
        private void btnEditarAsitencia_Click(object sender, EventArgs e)
        {
            UserPartidos form = new UserPartidos();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UserMiPerfil form = new UserMiPerfil();
            form.Show();
            this.Close();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            UserCambiarContraseña form = new UserCambiarContraseña();
            form.Show();
            this.Close();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Rol form = new Rol();
            form.Show();
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            UserReporte form = new UserReporte();
            form.Show();
            this.Close();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            UserPartidos form = new UserPartidos();
            form.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CargarPartidosEnListView()
        {
            lvPartidos.Items.Clear();
            var partidos = Metodos.GetPartidosAsStringArray();

            foreach (var partido in partidos)
            {
                var listItem = new ListViewItem(partido);
                lvPartidos.Items.Add(listItem);
            }
        }
    }
}