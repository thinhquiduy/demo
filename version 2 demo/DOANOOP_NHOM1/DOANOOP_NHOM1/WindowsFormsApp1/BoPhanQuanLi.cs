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
         static DataTable dsChiNhanh;
       static DataView dsChiNhanhView;
       DataTable danhmuc;
        public BoPhanQuanLi()
        {
            InitializeComponent();
            
        }

        private void BoPhanQuanLi_Load(object sender, EventArgs e)
        {
            danhmuc = DocBangDanhMuc();
            dgvDoanhThu.DataSource = danhmuc;
            dsChiNhanh = XuLyDuLieu.docBang("Select *From DanhMucChiNhanh");
            dsChiNhanhView = new DataView(dsChiNhanh);
            dgvDanhMucChinhanh.DataSource = dsChiNhanhView;
            comboBox1.DataSource = DocBangDanhMuc();
            comboBox1.DisplayMember = "Loai";
            /// comboBox1.SelectedItem = "Tên";
            comboBox1.ValueMember = "Tên";
      
            BanHangChiNhanh f = new BanHangChiNhanh();
            f.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow cn = dsChiNhanh.NewRow();
            cn["MaCN"] = tbMaCn.Text;
            cn["Ten"] = tbTen.Text;
            cn["DiaChi"] = tbDiaChi.Text;
            cn["DienThoai"] = tbDienThoai.Text;
            cn["TinhThanh"] = tbTinhThanh.Text;
            dsChiNhanh.Rows.Add(cn);
            XuLyDuLieu.ghiBang("DanhMucChiNhanh", dsChiNhanh);
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public  DataTable DocBangDanhMucChiNhanh()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=RAIN;Integrated Security=SSPI;Initial Catalog=DanhMucChiNhanh";
            OleDbCommand oleCommand = new OleDbCommand();
            oleCommand.Connection = oleConnection;
            oleCommand.CommandText = "Select * From DanhMucChiNhanh";
            OleDbDataAdapter oledataapdapter = new OleDbDataAdapter();
            oledataapdapter.SelectCommand = oleCommand;
            DataTable dt = new DataTable();
            oledataapdapter.Fill(dt);
            return dt;
        }

        private void DanhMucChiNhanh_Load(object sender, EventArgs e)
        {
            
            //DataTable BangDanhMucChiNhanh = DocBangDanhMucChiNhanh();
            //dgvDanhMucChinhanh.DataSource = DocBangDanhMucChiNhanh();
        }

        private void dgvDanhMucChinhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex >= 0)
            //{
            //     dgvDoanhThu.DataSource = DocBangDanhMuc();
            //DocBangDanhMuc().DefaultView.RowFilter = string.Format("Loai LIKE '%{0}%'", comboBox1.Text);
            //}
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = DocBangDanhMuc();
            comboBox1.DisplayMember = "Loai";
           /// comboBox1.SelectedItem = "Tên";
            comboBox1.ValueMember = "Tên";
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           // dgvDoanhThu.DataSource = danhmuc;
            danhmuc.DefaultView.RowFilter = string.Format("Loai LIKE '%{0}%'", comboBox1.Text);
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
