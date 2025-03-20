using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDsederhana
{
    public partial class Form1 : Form
    {
        static string connectionString = string.Format(
            "Server=127.0.0.1; database = organisasiMahasiswa; UID = root; Password =[Sesuaikan dengan password root server kalian].");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.Open();
                string query = "SELECT NIM, Nama, Email, Telpon, Alamat FROM Mahasiswa";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMahasiswa.AutoGenerateColumns = true;
                dgvMahasiswa.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TELEPHONE_Click(object sender, EventArgs e)
        {

        }

        private void TAMBAH_Click(object sender, EventArgs e)
        {

        }
    }
}

