using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DoanhTh
{
    class XyLyDuLieu
    {
        public static string connectionstring = "Provider=SQLNCLI11;Data Source=DESKTOP-PM1OOCL;Integrated Security=SSPI;Initial Catalog=DOANHTHU";

        public static DataTable docBang()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From DoanhThu", connectionstring);
            adapter.Fill(dt);
            return dt;
        }

        public void ghiBang(String tenBang, DataTable dt)
        {
            String selectSql = "Select * from" + tenBang;
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, connectionstring);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

    }
}
