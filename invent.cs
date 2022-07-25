using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace save
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            product p = new product();
            p.number = numtxt.Text;
            p.date = dateTimePicker1.Text;
            p.inventorynumber = invtxt.Text;
            p.objectname = objtxt.Text;
            p.count = counttxt.Text;
            p.price = pricetxt.Text;
            Regex regex = new Regex("@^(a-z)(z)$");
            if (regex.IsMatch(objtxt.Text)) { 
                MessageBox.Show("try ");

            }
            else
            
            if (string.IsNullOrEmpty(objtxt.Text))
            {
        
                MessageBox.Show("add name");
                errorProviderobjname.SetError(objtxt,"add name");
                
            }
            else
            {
               /* if (objtxt.MaxLength < 3)
                {
                    MessageBox.Show("less than 3 charachter");
                    errorProviderobjname.SetError(objtxt, "less than 3 charachter");
                }*/
                p.savee();
                MessageBox.Show("item added");
                newgridproduct.DataSource = null;
                newgridproduct.DataSource = p.getall();

            }
           

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void newgridproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
