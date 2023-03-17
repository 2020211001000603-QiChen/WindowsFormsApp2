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
    public partial class JobDtailsform2 : Form
    {
        public JobDtailsform2()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarNo_Leave(object sender, EventArgs e)
        {

        }

        private void txtCarNo_TextChanged(object sender, EventArgs e)
        {

            if ((txtCarNo.Text == " ") || (txtCarNo.Text == null))
            {
                MessageBox.Show("Please Specify a valid value" + 
                    "of the car number", "Error in input");
                txtCarNo.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCarNo.Text.Length < 6)
            {
                MessageBox.Show("Please specify a valid car number");
                txtCarNo.Focus();
                return;
            }
            try
            {
                if (Convert.ToInt32(txtWorkerId.Text)<1)
                {
                    MessageBox.Show("Please specify a valid worker Id");
                    txtWorkerId.Focus();
                    return;
                }
                if(Convert.ToDateTime(dateTimePicker1.Value)>DateTime.Today)
                {
                    MessageBox.Show("Please specify valid Date");
                    dateTimePicker1.Focus();
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
