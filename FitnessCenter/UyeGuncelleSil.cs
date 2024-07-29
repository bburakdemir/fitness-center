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
    public partial class UyeGuncelleSil : Form
    {
        public UyeGuncelleSil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9L1R9UB\\MSSQLSERVER01;Initial Catalog=fCenterDb;Integrated Security=True;TrustServerCertificate=True; Connect Timeout=30;Encrypt=True;");

        private void uyeler()
        {
            baglanti.Open();
            string query = " select * from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
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

        private void UyeGuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        int key = 0;
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UyeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(UyeDGV.SelectedRows[0].Cells[0].Value.ToString());
            UadSoyadTb.Text = UyeDGV.SelectedRows[0].Cells[1].Value.ToString();
            UtelnoTb.Text = UyeDGV.SelectedRows[0].Cells[2].Value.ToString();
            UcinsiyetCb.Text = UyeDGV.SelectedRows[0].Cells[3].Value.ToString();
            UyasTb.Text = UyeDGV.SelectedRows[0].Cells[4].Value.ToString();
            UzamanlamaCb.Text = UyeDGV.SelectedRows[0].Cells[5].Value.ToString();
            UucretTb.Text = UyeDGV.SelectedRows[0].Cells[6].Value.ToString();
            UsporturuCb.Text = UyeDGV.SelectedRows[0].Cells[7].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || UadSoyadTb.Text == "" || UtelnoTb.Text == "" || UcinsiyetCb.Text == "" || UyasTb.Text == "" || UzamanlamaCb.Text == "" || UsporturuCb.Text == ""||UucretTb.Text=="")
            {
                MessageBox.Show("Bilgileri eksik girdiniz. Lütfen kontrol edip tekrar deneyiniz.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update UyeTbl set UAdSoyad='" + UadSoyadTb.Text + "',UTelefon='" + UtelnoTb.Text + "',UCinsiyet='" + UcinsiyetCb.SelectedItem.ToString() + "',UYas='" + UyasTb.Text + "',UZamanlama='" + UzamanlamaCb.SelectedItem.ToString() + "',UOdeme='"+UucretTb.Text+ "',USporTuru='" + UsporturuCb.SelectedItem.ToString() + "' where UID=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye kaydı başarıyla güncellendi.");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UadSoyadTb.Text = "";
            UtelnoTb.Text = "";
            UcinsiyetCb.Text = "";
            UyasTb.Text = "";
            UzamanlamaCb.Text = "";
            UsporturuCb.Text = "";
            UucretTb.Text = ""
;        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek üyeyi seçiniz.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from UyeTbl where UID=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye kaydı başarıyla silindi.");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
