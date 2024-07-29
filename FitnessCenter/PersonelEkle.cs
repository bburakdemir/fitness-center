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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9L1R9UB\\MSSQLSERVER01;Initial Catalog=fCenterDb;Integrated Security=True;TrustServerCertificate=True; Connect Timeout=30;Encrypt=True;");
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

        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PadSoyadTb.Text==""||PyasTb.Text==""||PtelnoTb.Text=="") {
                MessageBox.Show("Bilgileri eksik girdiniz. Lütfen kontrol edip tekrar deneyiniz!");
            }
            else
            {
                try
                {   
                    baglanti.Open();
                    string query = "insert into PersonelTbl values ('" + PadSoyadTb.Text + "','" + PtelnoTb.Text + "','" + PcinsiyetCb.SelectedItem.ToString()+"','"+PyasTb.Text+"','"+PzamanlamaCb.SelectedItem.ToString()+"','"+PsporturuCb.SelectedItem.ToString()+"')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel başarıyla eklendi.");
                    baglanti.Close();
                    
                    PadSoyadTb.Text = "";
                    PtelnoTb.Text = "";
                    PyasTb.Text = "";
                    PzamanlamaCb.Text = "";
                    PsporturuCb.Text = "";
                    PcinsiyetCb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PadSoyadTb.Text = "";
            PtelnoTb.Text = "";
            PyasTb.Text = "";
            PzamanlamaCb.Text = "";
            PsporturuCb.Text = "";
            PcinsiyetCb.Text = "";
        }
    }
}
