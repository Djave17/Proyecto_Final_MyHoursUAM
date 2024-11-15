using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyHours_UAMApp
{
    public partial class SplashScreenAdmin : Form
    {
        public SplashScreenAdmin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar.Increment(2);
            if (progressBar.Value == 100)
            {
                timer1.Enabled = false;
                AdminAdd form = new AdminAdd();
                form.Show();
                this.Hide();

            }
}

        private void SplashScreenAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
