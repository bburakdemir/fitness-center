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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection baglanti= new SqlConnection("Data Source=DESKTOP-9L1R9UB\\MSSQLSERVER01;Initial Catalog=fCenterDb;Integrated Security=True;TrustServerCertificate=True; Connect Timeout=30;Encrypt=True;");
        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KullaniciTb.Text==""||ParolaTb.Text=="")
            {
                MessageBox.Show("Kullanıcı adı ve parola boş bırakılamaz.");
            }
            else if(KullaniciTb.Text=="admin"&&ParolaTb.Text=="123456789")
            {
                AnaSayfa anaSayfa= new AnaSayfa();
                anaSayfa.Show();
                this.Hide();   
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya parola.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciTb.Text ="";
            ParolaTb.Text = "";
        }
    }
}
