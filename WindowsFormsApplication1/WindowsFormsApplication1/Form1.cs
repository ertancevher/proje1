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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            SqlCommand komut = new SqlCommand();
            SqlConnection baglan = new SqlConnection("Data Source=LAB8-1;Initial Catalog=PROJEDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            komut.Connection = baglan;
            baglan.Open();
            komut.Parameters.Clear();
            komut.CommandText = "Insert Into TBLOgrenciler(O_TC_Kimlik,O_Ad,O_Soyad,O_Sifre,[O_E-mail],O_Bolum,O_Sinif) Values(@t,@a,@s,@f,@e,@b,@sf)";
            komut.Parameters.AddWithValue("@t",textBox1.Text);
            komut.Parameters.AddWithValue("@a", textBox2.Text);
            komut.Parameters.AddWithValue("@s", textBox3.Text);
            komut.Parameters.AddWithValue("@f", textBox4.Text);
            komut.Parameters.AddWithValue("@e", textBox5.Text);
            komut.Parameters.AddWithValue("@b", textBox6.Text);
            komut.Parameters.AddWithValue("@sf", textBox7.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi");
            baglan.Close();
        }
    }
}
