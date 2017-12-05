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
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            DataTable baocao = new DataTable();
            baocao = docBang();
            dgvBaoCao.DataSource = baocao;
        }
        public static DataTable docBang()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From Baocao", "Provider=SQLNCLI11;Data Source=DESKTOP-5C26LMR;Integrated Security=SSPI;Initial Catalog=baocao");
            adapter.Fill(dt);
            return dt;
        }

        private void dgvBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dthu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
