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
    public partial class Trang_Thai_Don_Hang : Form
    {
        public Trang_Thai_Don_Hang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Trang_Thai_Don_Hang_Load(object sender, EventArgs e)
        {
            DataTable BangDSMonAn = DocBangDanhSachMonAn();
            dgvDoanhThu.DataSource = DocBangDanhSachMonAn();
            dgvDoanhThu.Columns[0].Width = 200;
            dgvDoanhThu.Columns[2].Width = 250;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        public DataTable DocBangDanhSachMonAn()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=RAIN;Integrated Security=SSPI;Initial Catalog=DSMonAn";
            OleDbCommand oleCommand = new OleDbCommand();
            oleCommand.Connection = oleConnection;
            oleCommand.CommandText = "Select * From DSMonAn";
            OleDbDataAdapter oledataapdapter = new OleDbDataAdapter();
            oledataapdapter.SelectCommand = oleCommand;
            DataTable dt = new DataTable();
            oledataapdapter.Fill(dt);
            return dt;
            
            
        }
    }
}
