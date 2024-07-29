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
    public partial class PersonelGuncelleSil : Form
    {
        public PersonelGuncelleSil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9L1R9UB\\MSSQLSERVER01;Initial Catalog=fCenterDb;Integrated Security=True;TrustServerCertificate=True; Connect Timeout=30;Encrypt=True;");

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
        private void PersonelGuncelleSil_Load(object sender, EventArgs e)
        {
            personeller();
        }

        int key = 0;
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

        private void PerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key= Convert.ToInt32(PerDGV.SelectedRows[0].Cells[0].Value.ToString());
            PadSoyadTb.Text = PerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PtelnoTb.Text = PerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PcinsiyetCb.Text = PerDGV.SelectedRows[0].Cells[3].Value.ToString();
            PyasTb.Text = PerDGV.SelectedRows[0].Cells[4].Value.ToString();
            PzamanlamaCb.Text = PerDGV.SelectedRows[0].Cells[5].Value.ToString();
            PsporturuCb.Text = PerDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PadSoyadTb.Text = "";
            PtelnoTb.Text = "";
            PcinsiyetCb.Text = "";
            PyasTb.Text = "";
            PzamanlamaCb.Text = "";
            PsporturuCb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Silinecek personeli seçiniz.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from PersonelTbl where PID=" + key + ";";
                    SqlCommand komut= new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel kaydı başarıyla silindi.");
                    baglanti.Close();
                    personeller();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (key == 0|| PadSoyadTb.Text == ""||PtelnoTb.Text == ""|| PcinsiyetCb.Text == ""||PyasTb.Text == ""||PzamanlamaCb.Text == ""|| PsporturuCb.Text == "")
            {
                MessageBox.Show("Bilgileri eksik girdiniz. Lütfen kontrol edip tekrar deneyiniz.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update PersonelTbl set PAdSoyad='" + PadSoyadTb.Text + "',PTelefon='" + PtelnoTb.Text + "',PCinsiyet='" + PcinsiyetCb.SelectedItem.ToString() + "',PYas='" + PyasTb.Text + "',PZamanlama'" + PzamanlamaCb.SelectedItem.ToString()+"',PBrans='" + PsporturuCb.SelectedItem.ToString() + "' where PID="+key+";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel kaydı başarıyla güncellendi.");
                    baglanti.Close();
                    personeller();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
