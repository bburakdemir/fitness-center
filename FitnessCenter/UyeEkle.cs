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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9L1R9UB\\MSSQLSERVER01;Initial Catalog=fCenterDb;Integrated Security=True;TrustServerCertificate=True; Connect Timeout=30;Encrypt=True;");
        private void UyeEkle_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (UadSoyadTb.Text==""||UtelnoTb.Text==""||UyasTb.Text==""||UucretTb.Text==""||UsporturuCb.Text==""||UcinsiyetCb.Text==""||UzamanlamaCb.Text=="") {

                MessageBox.Show("Bilgileri eksik girdiniz.Lütfen kontrol edip tekrar deneyiniz.");

            }
            else
            {
                try
                {
                   baglanti.Open();
                    string query = "insert into UyeTbl values ('" + UadSoyadTb.Text + "','" + UtelnoTb.Text + "','" + UcinsiyetCb.SelectedItem.ToString() + "','" + UyasTb.Text + "','" + UzamanlamaCb.SelectedItem.ToString()+"','" + UucretTb.Text + "','" + UsporturuCb.SelectedItem.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla eklendi.");
                    baglanti.Close();

                    UadSoyadTb.Text = "";
                    UcinsiyetCb.Text = "";
                    UtelnoTb.Text = "";
                    UyasTb.Text = "";
                    UucretTb.Text = "";
                    UzamanlamaCb.Text = "";
                    UsporturuCb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UadSoyadTb.Text = "";
            UcinsiyetCb.Text = "";
            UtelnoTb.Text = "";
            UyasTb.Text = "";
            UucretTb.Text = "";
            UzamanlamaCb.Text = "";
            UsporturuCb.Text = "";

        }
    }
}
