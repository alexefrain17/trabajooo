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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string conexion = "Data Source=DESKTOP-7LDGQBD;Initial Catalog=inicio;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from USUario", cn);
                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();
                da.Fill(dt);

                DataGridView.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login5 = new Form1();
            login5.Show();
            this.Hide();
        }
    }
}
