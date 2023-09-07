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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //conectar
            this.Close();
            Form1 back = new Form1();
            back.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 login1 = new Form2();
            login1.Show();
            this.Close();

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7LDGQBD;Initial Catalog=inicio;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("insert into USUARIO(id, usuario, Contraseña) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
