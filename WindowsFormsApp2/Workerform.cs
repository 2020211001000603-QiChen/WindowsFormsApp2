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
    public partial class Workerform : Form
    {
        public Workerform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cMSDBDataSet.tblWorker.Clear();
            
        }

        private void Workerform_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cMSDBDataSet.tblWorker”中。您可以根据需要移动或移除它。
            this.tblWorkerTableAdapter.Fill(this.cMSDBDataSet.tblWorker);

        }
    }
}
