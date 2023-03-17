using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workerform workerform = new Workerform();
            workerform.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customerform customerform = new Customerform();
            customerform.ShowDialog();
        }

        private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobDtailsform2 jobDtailsform2 = new JobDtailsform2();
            jobDtailsform2.ShowDialog();
        }

        private void reportersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reaporterform reaporterform = new Reaporterform();
            reaporterform.ShowDialog();
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
