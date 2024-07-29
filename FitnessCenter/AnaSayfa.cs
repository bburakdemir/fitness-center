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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        SqlCommand baglanti= new SqlCommand("Data Source=DESKTOP-9L1R9UB\\MSSQLSERVER01;Initial Catalog=fCenterDb;Integrated Security=True;TrustServerCertificate=True; Connect Timeout=30;Encrypt=True;");
        private void button9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle= new UyeEkle(); 
            uyeEkle.Show(); 
            this.Hide();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UyeListele uyeListele= new UyeListele();    
            uyeListele.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UyeGuncelleSil uyeGuncelleSil= new UyeGuncelleSil();
            uyeGuncelleSil.Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle= new PersonelEkle();  
            personelEkle.Show();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonelListele personelListele= new PersonelListele(); 
            personelListele.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PersonelGuncelleSil personelGuncelleSil= new PersonelGuncelleSil();
            personelGuncelleSil.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SilinenUyeListele silinenUyeListele= new SilinenUyeListele();   
            silinenUyeListele.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SilinenPersonelListele silinenPersonelListele=new SilinenPersonelListele(); 
            silinenPersonelListele.Show();  
            this.Hide();    
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
