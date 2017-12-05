using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DoanhTh
{
    class XuLyDuLieu
    {
        public static string connectionstring = "Provider=SQLNCLI11;Data Source=DESKTOP-5C26LMR;Integrated Security=SSPI;Initial Catalog=doanh thu";

        public static DataTable docBang(string sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From doanhthu", connectionstring);
            adapter.Fill(dt);
            return dt;
        }

        public static void ghiBang(String tenBang, DataTable dt)
        {
            String selectSql = "Select * from" + tenBang;
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, connectionstring);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

    }
}
