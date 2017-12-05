using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DoanhTh
{
    public partial class Form1 : Form
    {
        DataTable dsDoanhThu = new DataTable();
        DataView dsDoanhThuView;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public  DataTable docBang()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From doanhthu", "Provider=SQLNCLI11;Data Source=DESKTOP-5C26LMR;Integrated Security=SSPI;Initial Catalog=doanh thu");
            adapter.Fill(dt);
            return dt;
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            dsDoanhThu = docBang();
            dsDoanhThuView = new DataView(dsDoanhThu);
            dgvdsDoanhThu.DataSource = dsDoanhThu;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvdsDoanhThu.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvdsDoanhThu.SelectedRows[0].DataBoundItem).Row;
                cn.Delete();
                XuLyDuLieu.ghiBang("doanhthu", dsDoanhThu);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
