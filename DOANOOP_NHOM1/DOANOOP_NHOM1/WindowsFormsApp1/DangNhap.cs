using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DangNhap : Form
    {
        string strConnection = "Data Source=RAIN;Initial Catalog=Login;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
                string sql = " select Count(*) from [Login].[dbo].Login where TaiKhoan =@acc and MatKhau=@pass";
                conn = new SqlConnection(strConnection);                
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@acc",tbdangnhap.Text));
                command.Parameters.Add(new SqlParameter("@pass", tbmatkhau.Text));
                int x = (int)command.ExecuteScalar();
                if (x == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Nofitication");
                    BoPhanQuanLi f = new BoPhanQuanLi();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Nofitication");
                }
                
            
           
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void cbhienpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienpass.Checked)
            {
                tbmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                tbmatkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
