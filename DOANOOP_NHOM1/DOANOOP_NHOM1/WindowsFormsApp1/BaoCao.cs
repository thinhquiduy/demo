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
    public partial class BaoCao : Form
    {
        DataTable dsBaocao;
        DataView dsBaocaoView;
        public BaoCao()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            DataTable BangBaoCao = DocBangBaoCao();
            dgvBaocao.DataSource = DocBangBaoCao();
           

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable DocBangBaoCao()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=RAIN;Integrated Security=SSPI;Initial Catalog=BangBaocao";
            OleDbCommand oleCommand = new OleDbCommand();
            oleCommand.Connection = oleConnection;
            oleCommand.CommandText = "Select * From BaoCao";
            OleDbDataAdapter oledataapdapter = new OleDbDataAdapter();
            oledataapdapter.SelectCommand = oleCommand;
            DataTable dt = new DataTable();
            oledataapdapter.Fill(dt);
            return dt;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
           
            dsBaocaoView = new DataView(dsBaocao);
            dgvBaocao.DataSource = dsBaocaoView;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                dsBaocaoView.RowFilter = "";
            }
            else
            {
                //or,and
                //so :=,<,>
                string str = string.Format("TenCN like '%{0}%'", textBox4.Text);
                dsBaocaoView.RowFilter = str;
            }
        }

        private void dgvBaocao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBaocao.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvBaocao.SelectedRows[0].DataBoundItem).Row;
               
            }
        }

        private void doanhthu_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
