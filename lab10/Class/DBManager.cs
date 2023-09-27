using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Collections.Specialized.BitVector32;


namespace lab10
{
    internal class DBManager
    {
        //private string conStr1 = @"Server=localhost;Database=crucio;Uid=root;Pwd=1234";
        public string conStr { get; set; }
        private MySqlConnection con;
        private MySqlCommand cmd;
        private static DBManager instance;

        DBManager(string conString)
        {
            con = new MySqlConnection(conString);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            conStr = conString;
        }
        DBManager()
        {
            con = new MySqlConnection(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
            cmd = new MySqlCommand();
            cmd.Connection = con;
            conStr = @"Server=localhost;Database=crucio;Uid=root;Pwd=1234";
        }

        public static DBManager getInstance()
        {
            if (instance == null)
                instance = new DBManager();
            return instance;
        }
        public static DBManager getInstance(string conStr)
        {
            if (instance == null)
                instance = new DBManager(conStr);
            return instance;
        }

        public static void deleteInstance()
        {
            instance=null;
        }

        public void FillGrid(DataGridView dataGridView, MySqlDataReader MyR)
        {
            dataGridView.Columns.Clear();
            for (int i = 0; i < MyR.FieldCount; i++)
            {
                dataGridView.Columns.Add("Col" + i.ToString(), MyR.GetName(i));
            }

            while (MyR.Read())
            {
                string[] s = new string[MyR.FieldCount];
                for (int i = 0; i < MyR.FieldCount; i++)
                {
                    s[i] = MyR[i].ToString();
                }

                dataGridView.Rows.Add(s);
            }
        }
        public List<List<object>> selectAll(string tableName)
        {
            try
            {
                var res = new List<List<object>>();
                cmd.CommandText = "select * from " + tableName;
                con.Open();
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    List<object> row = new List<object>();
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        row.Add(r[i]);
                    }

                    res.Add(row);
                }

                con.Close();
                return res;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void selectAll(string tablename, DataGridView dataGridView)
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from " + tablename;
                MySqlDataReader myR = cmd.ExecuteReader();
                FillGrid(dataGridView, myR);
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ExecSQL(string query)
        {
            try
            {
                cmd.CommandText = query;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
            }
        }

        public void insert(string tableName, string[] fields, string[] values)
        {
            try
            {
                cmd.CommandText = "insert into " + tableName + "(" + string.Join(",", fields) + ") " +
                                  "values(" + string.Join(",", values) + ")";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void delete(string tableName, string cond)
        {
            try
            {
                if (con != null)
                    cmd.CommandText = "delete from " + tableName + " where " + cond;
                else
                    cmd.CommandText = "delete from " + tableName;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CreateTable(string tablename, string[] fields, string[] type)
        {
            string query = "";
            for (int i = 0; i < fields.Length - 1; i++)
                query += fields[i] + " " + type[i] + ",";
            query += fields[fields.Length - 1] + " " + type[fields.Length - 1];
            ExecSQL("CREATE TABLE " + tablename + " (" + query + ")");
        }

        public void CreateTable(string tablename, string[] fields, string[] type, string FK)
        {
            string query = "";
            for (int i = 0; i < fields.Length - 1; i++)
                query += fields[i] + " " + type[i] + ",";
            query += fields[fields.Length - 1] + " " + type[fields.Length - 1] + "," + FK;
            ExecSQL("CREATE TABLE " + tablename + " (" + query + ")");
        }

        public void DropTable(string tablename)
        {
            ExecSQL("DROP TABLE " + tablename);
        }

        public void DeleteFK(string tablename, string Name_FK)
        {
            ExecSQL($"alter table {tablename} drop constraint {Name_FK}");
        }

        public void DeleteAllFK(string DBName,string tableName)
        {
            try
            {
                string query =
                    $"SELECT CONSTRAINT_NAME FROM information_schema.table_constraints WHERE constraint_schema = '{DBName}' and CONSTRAINT_TYPE='FOREIGN KEY'";
                DataTable constraints = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(conStr))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(constraints);
                        }
                    }

                    foreach (DataRow row in constraints.Rows)
                    {
                        string constraintName = row["CONSTRAINT_NAME"].ToString();
                        string constraintTable = GetConstraintTable(constraintName);

                        if (constraintTable == tableName)
                        {
                            string dropConstraintQuery = $"ALTER TABLE {tableName} DROP CONSTRAINT {constraintName}";
                            ExecSQL(dropConstraintQuery);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private string GetConstraintTable(string constraintName)
        {
            string query = $"SELECT TABLE_NAME FROM information_schema.KEY_COLUMN_USAGE WHERE CONSTRAINT_NAME = '{constraintName}'";
            string table = string.Empty;

            using (MySqlConnection connection = new MySqlConnection(conStr))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        table = result.ToString();
                    }
                }
            }
            return table;
        }

        public string CreateForenKey(string[] fieldName, string[] tableName, string[] referenceFieldName)
        {
            string FK = "";
            for (int i = 0; i < fieldName.Length-1; i++)
            {
                FK += "FOREIGN KEY (" + fieldName[i] + ") REFERENCES " + tableName[i] + " (" + referenceFieldName[i] +
                      "),";
            }
            FK+= "FOREIGN KEY (" + fieldName[fieldName.Length - 1] + ") REFERENCES " + tableName[fieldName.Length - 1]
                 + " (" + referenceFieldName[fieldName.Length - 1]+")";
            return FK;
        }

        public string CreateForenKey(string fieldName, string tableName, string referenceFieldName)
        {
            return "FOREIGN KEY (" + fieldName + ") REFERENCES " + tableName + " (" + referenceFieldName + ")";
        }

        public bool Exist(string databaseName,string tableName)
        {
            bool exists = false;
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '{databaseName}' AND table_name = '{tableName}'";
                exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            return exists;
        }

        public void Select(string query,DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            cmd.CommandText= query;
            con.Open();
            MySqlDataReader myR = cmd.ExecuteReader();
            FillGrid(dataGridView, myR);
            con.Close();
        }

        public bool CheckConnection()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conStr))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}