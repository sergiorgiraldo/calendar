using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WindowsFormsCalendar;

namespace TestHarness
{
    public partial class Form1 : Form
    {
        #region Fields

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void calendar1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.J || e.KeyCode == Keys.Left)
                calendar1.ViewStart = calendar1.ViewStart.AddMonths(-1);
            else if (e.KeyCode == Keys.N || e.KeyCode == Keys.K || e.KeyCode == Keys.Right)
                calendar1.ViewStart = calendar1.ViewStart.AddMonths(1);
            else
            if (e.KeyCode == Keys.T || e.KeyCode == Keys.H)
                calendar1.ViewStart = DateTime.Today;

        }
    }
}