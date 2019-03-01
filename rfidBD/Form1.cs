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

namespace rfidBD
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6HE2FV2\\SQLEXPRESS;Initial Catalog=rfid;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            
            if(baglanti.State ==ConnectionState.Closed)
            {
                baglanti.Open();
            }
            string s1 = txt_uid.Text;
            string s2 = txt_ad.Text;
            string s3 = txt_soyad.Text;
            cmd.CommandText = "INSERT INTO rfid_table2(input,ad,soyad) VALUES ('" + s1 + "' , '" + s2 + "' , '" +s3 + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Enes");
          
        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            serialPort1.Open();
            string entrada = serialPort1.ReadLine();
            serialPort1.Close();
            txt_uid.Text = entrada;
        }
    }
}
