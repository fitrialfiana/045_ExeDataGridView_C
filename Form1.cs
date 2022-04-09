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
            this.dataGridView1.Columns[0].HeaderText = "No. Mahasiswa";

            
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

            //Mengubah warna kolom notelepon
            //Mengubah tulisan menjadi warna marun
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            //Mengubah latar kolom menjadi warna marun
            this.dataGridView1.Columns[5].DefaultCellStyle.SelectionBackColor = Color.Maroon;




        }
    }
}
