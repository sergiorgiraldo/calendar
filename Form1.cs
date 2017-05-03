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
            monthCalendar1.SetDate(DateTime.Today);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.P || e.KeyCode == Keys.J)
                monthCalendar1.SetDate(monthCalendar1.GetDisplayRange(true).Start.AddMonths(-1));
            else if (e.KeyCode == Keys.N || e.KeyCode == Keys.K)
                monthCalendar1.SetDate(monthCalendar1.GetDisplayRange(true).End.AddMonths(1));
            else if (e.KeyCode == Keys.T || e.KeyCode == Keys.H)
                monthCalendar1.SetDate(DateTime.Now.Date);
            else if (e.KeyCode == Keys.X)
                Close();
            else if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show(@"
KeyCode == Keys.P || Keys.J)\n
    SetDate AddMonths(-1))\n
KeyCode == Keys.N || Keys.K)\n
	SetDate AddMonths(1))\n
KeyCode == Keys.T || Keys.H)\n
	SetDate DateTime.Now.Date\n
KeyCode == Keys.X)\n
	Close()\n
");
            }
            //else if (e.KeyCode == Keys.Right)
            //    monthCalendar1.SetDate(monthCalendar1.SelectionRange.Start.AddDays(1));
            //else if (e.KeyCode == Keys.Left)
            //    monthCalendar1.SetDate(monthCalendar1.SelectionRange.Start.AddDays(-1));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
