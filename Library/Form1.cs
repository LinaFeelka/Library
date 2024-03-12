using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DateDifference;
using LeapYear;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateDifference.Form1 form = new DateDifference.Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeapYear.Form1 form = new LeapYear.Form1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datetimes.Form1 dat = new Datetimes.Form1();
            dat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Timeofday2.Form1 dat = new Timeofday2.Form1();
            dat.Show();
        }
    }
}
