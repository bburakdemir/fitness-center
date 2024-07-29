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

namespace FitnessCenter
{
    public partial class PersonelListele : Form
    {
        public PersonelListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9L1R9UB\\MSSQLSERVER01;Initial Catalog=fCenterDb;Integrated Security=True;TrustServerCertificate=True; Connect Timeout=30;Encrypt=True;");

        private void adfiltrele()
        {
            baglanti.Open();
            string query = " select * from PersonelTbl where PAdSoyad= '"+PerAraTb.Text+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PerDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void personeller()
        {
            baglanti.Open();
            string query = " select * from PersonelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PerDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa= new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PersonelListele_Load(object sender, EventArgs e)
        {
            personeller();
        }

        private void PerAraTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerAraTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adfiltrele();
        }
    }
}
