using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace day35_01
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter DataA;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "server=.\\SQLEXPRESS;database=test; user id=sa; pwd=alencia;";
        }

        private void BTN_Call_Click(object sender, EventArgs e)
        {
            DataA = new SqlDataAdapter("SELECT * FROM testTable01", conn);
            DataSet DS01 = new DataSet();
            DataA.Fill(DS01, "testTable01");
            dataGridView1.DataSource = DS01.Tables[0];
        }

       
    }
}
