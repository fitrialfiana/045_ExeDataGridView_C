using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mengubah nama kolom sesuai instruksi
            this.dataGridView1.Columns[0].HeaderText = "No. Mahasiswa";
            this.dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
            this.dataGridView1.Columns[2].HeaderText = "Alamat Mahasiswa";
            this.dataGridView1.Columns[3].HeaderText = "Jenis Kelamin";
            this.dataGridView1.Columns[4].HeaderText = "No. Telepon";

            //Memngatur panjang kolom
            this.dataGridView1.Columns[0].Width = 120;
            this.dataGridView1.Columns[1].Width = 140;
            this.dataGridView1.Columns[2].Width = 140;
            this.dataGridView1.Columns[3].Width = 120;
            this.dataGridView1.Columns[4].Width = 110;

            //Membuat nama kolom menggunakan font Arial, berukuran 9 dan tebal (bold)
            this.dataGridView1.Columns[0].HeaderCell.Style.Font = new Font ("Arial", 9, FontStyle.Bold);
            this.dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            this.dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            this.dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            this.dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            //Membuat alignment kolom jenis kelamin menjadi tengah (center)
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            //Mengubah warna kolom no mahasiswa
            //Mengubah tulisan menjadi warna ungu
            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            //Mengubah latar kolom menjadi warna pink
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;

            //Mengubah warna kolom nama mahasiswa
            //Mengubah tulisan menjadi warna biru
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            //Mengubah latar kolom menjadi warna orage
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;

            //Mengubah warna kolom alamat mahasiswa
            //Mengubah tulisan menjadi warna birumuda
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.LightSeaGreen;
            //Mengubah latar kolom menjadi warna hijau
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;


            //Mengubah warna kolom jenis kelamin
            //Mengubah tulisan menjadi warna hijau
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            //Mengubah latar kolom menjadi warna biru tua
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            //Mengubah warna kolom no.telepon
            //Mengubah tulisan menjadi warna marun
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            //Mengubah latar kolom menjadi warna marun
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
