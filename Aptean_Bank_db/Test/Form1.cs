using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aptean_Bank_db;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aptean_Bank_db.Connection.Data_Access_Layer.create();
            MessageBox.Show("my value"+ Aptean_Bank_db.Connection.Data_Access_Layer.read_customer());

        }
    }
}
