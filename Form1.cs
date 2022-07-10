using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            model md = new model();
            {
                md.num = txt_number.Text;
                md.date = txt_number.Text;
                md.invontarynum = txt_inventorynumber.Text;
                md.object_name = txt_objectname.Text;
                md.count = txt_count.Text;
            }
            md.save();
            MessageBox.Show("item added");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
