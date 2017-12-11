using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace CBBplDGV
{
    public partial class Form1 : Form
    {
        static string conString = "Provider=SQLNCLI11;Data Source=DESKTOP-PM1OOCL;Integrated Security=SSPI;Initial Catalog=FootballPlayer";
        DataTable dt = new DataTable();
        OleDbConnection con = new OleDbConnection(conString);

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillcombo();
            dataGridView1.DataSource = loadData();
        }

        private DataTable loadData()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand cmd;
            DataSet ds = new DataSet();

            string sql = "SELECT * FROM VITRI";
            cmd = new OleDbCommand(sql, con);

            adapter.SelectCommand = cmd;
            adapter.Fill(ds);

            dt = ds.Tables[0];

            return dt;
        }

        private void fillcombo()
        {
            //them cot combobox
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Dong Doi";
            combo.Name = "combo";
            ArrayList row = new ArrayList();
            
            //them items cho combo tu datatable
            foreach(DataRow dr in dt.Rows)
            {
                row.Add(dr["Ten"].ToString());
            }

            //them vao combo
            combo.Items.AddRange(row.ToArray());

            //them vao combo column
            dataGridView1.Columns.Add(combo);
        }
    }
}
