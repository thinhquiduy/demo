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
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From DoanhThu", "Provider=SQLNCLI11;Data Source=DESKTOP-PM1OOCL;Integrated Security=SSPI;Initial Catalog=DOANHTHU");
            adapter.Fill(dt);
            return dt;
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            dsDoanhThu = docBang();
            //dsDoanhThuView = new DataView(dsDoanhThu);
            dgvdsDoanhThu.DataSource = dsDoanhThu;
            dataGridView1.DataSource = dsDoanhThu;
            dataGridView2.DataSource = dsDoanhThu;
            dataGridView3.DataSource = dsDoanhThu;
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Quy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   


        /*public string Get_Day()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 2);
            return str;
        }
        public string Get_Month()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(3, 2);
            return str;
        }
        public string Get_Year()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(6, 4);
            return str;
        }

        private void thang_TextChanged(object sender, EventArgs e)
        {
            thang.Text = Get_Month();
        }


        private void ngay_TextChanged_1(object sender, EventArgs e)
        {
            ngay.Text = Get_Day();
        }

        private void nam_TextChanged(object sender, EventArgs e)
        {
            nam.Text = Get_Year();
        }*/
    }
}
