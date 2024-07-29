using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class UyeListele : Form
    {
        public UyeListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9L1R9UB\\MSSQLSERVER01;Initial Catalog=fCenterDb;Integrated Security=True;TrustServerCertificate=True; Connect Timeout=30;Encrypt=True;");

        private void adfiltrele()
        {
            baglanti.Open();
            string query = " select * from UyeTbl where UAdSoyad='"+UyeAraTb.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);            
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = " select * from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);   
            UyeDGV.DataSource= ds.Tables[0];
            baglanti.Close();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeAraTb.Text = "";
        }

        private void UyeListele_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adfiltrele();
          
        }
    }
}
