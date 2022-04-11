using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp._1._Overview
{
    public partial class FrmOverView : Form
    {
        public FrmOverView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: SqlConnecttion
            // Step 2: SqlCommand
            // Step 3: SqlDataReader
            // Step 4: UI Control


            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            
            conn.Open();//aaaa
            //---------------
            conn.Close();
        }
    }
}
