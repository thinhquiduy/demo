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

namespace WindowsFormsApp1
{
    public partial class BoPhanQuanLi : Form
    {
        public BoPhanQuanLi()
        {
            InitializeComponent();
        }

        private void BoPhanQuanLi_Load(object sender, EventArgs e)
        {
            DataTable BangDoanhMuc = DocBangDanhMuc();
            dgvDoanhThu.DataSource = DocBangDanhMuc();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable DocBangDanhMuc()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=RAIN;Integrated Security=SSPI;Initial Catalog=DanhMucMonAn";
            OleDbCommand oleCommand = new OleDbCommand();
            oleCommand.Connection = oleConnection;
            oleCommand.CommandText = "Select * From BangDoanhMuc";
            OleDbDataAdapter oledataapdapter = new OleDbDataAdapter();
            oledataapdapter.SelectCommand = oleCommand;
            DataTable dt = new DataTable();
            oledataapdapter.Fill(dt);
            return dt;
        }
    }
}
