using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.J)
                monthCalendar1.SetDate(monthCalendar1.GetDisplayRange(true).Start.AddMonths(-1));
            else if (e.KeyCode == Keys.N || e.KeyCode == Keys.K)
                monthCalendar1.SetDate(monthCalendar1.GetDisplayRange(true).End.AddMonths(1));
            else if (e.KeyCode == Keys.T || e.KeyCode == Keys.H)
                monthCalendar1.SetDate(DateTime.Now.Date);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
