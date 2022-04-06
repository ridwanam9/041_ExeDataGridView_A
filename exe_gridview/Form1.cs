using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe_gridview
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
            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.OrangeRed;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Red;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Crimson;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.DarkGreen;
            this.dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.Green;

            
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.DarkMagenta;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Crimson;
            this.dataGridView1.Columns[5].DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
        }
    }
}
