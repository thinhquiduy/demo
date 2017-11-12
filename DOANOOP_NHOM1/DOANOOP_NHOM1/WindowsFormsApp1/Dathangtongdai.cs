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
    public partial class Dathangtongdai : Form
    {
        public Dathangtongdai()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable DocBangDanhSachMonAn()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=RAIN;Integrated Security=SSPI;Initial Catalog=DanhSachMonAn";
            OleDbCommand oleCommand = new OleDbCommand();
            oleCommand.Connection = oleConnection;
            oleCommand.CommandText = "Select * From DanhSachMonAn";
            OleDbDataAdapter oledataapdapter = new OleDbDataAdapter();
            oledataapdapter.SelectCommand = oleCommand;
            DataTable dt = new DataTable();
            oledataapdapter.Fill(dt);
            return dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dathangtongdai_Load(object sender, EventArgs e)
        {
            DataTable BangDoanhSachMonAn = DocBangDanhSachMonAn();
            dgvDoanhThu.DataSource = DocBangDanhSachMonAn();
            comboBox1.DataSource = DocBangDanhSachMonAn();
            comboBox1.DisplayMember = "Tên";
            
        }
    }
}
